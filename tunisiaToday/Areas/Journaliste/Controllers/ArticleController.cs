﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using tunisiaToday.DataAccess.Data;
using tunisiaToday.DataAccess.Repository.IRepository;
using tunisiaToday.Models;

namespace tunisiaToday.Controllers
{
    [Area("Journaliste")]
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        /* Il faudra utiliser IUnitOfWork pour l'acces aux donnees, mais ca n'as pas marche avec await*/
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(ApplicationDbContext context
            , IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Article
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Articles.Include(a => a.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Article/Details/5
        public IActionResult Details(int id)
        {

            var article = _unitOfWork.Article.Get(id);


            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }



        // GET: Article/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_unitOfWork.Category.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Article/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,ImageUrl,Text,Previsualisation,CategoryId,estUne")] Article article)
        {
            
            

            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"img\articles");
                    var extenstion = Path.GetExtension(files[0].FileName);

                    if (article.ImageUrl != null)
                    {
                        //this is an edit and we need to remove old image
                        var imagePath = Path.Combine(webRootPath, article.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    article.ImageUrl = @"\img\articles\" + fileName + extenstion;

                }
                    article.DatePublication = DateTime.Now;

                _unitOfWork.Article.Add(article);
                _unitOfWork.Save();   

                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            return View(article);
        }

        // GET: Article/Edit/5
        public IActionResult Edit(int id)
        {
            var article = _unitOfWork.Article.Get(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_unitOfWork.Category.GetAll(), "Id", "Name", article.CategoryId);
            return View(article);
        }

        // POST: Article/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,DatePublication,Maj,Title,ImageUrl,Text,Previsualisation,CategoryId,estUne")] Article article)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string webRootPath = _hostEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(webRootPath, @"img\articles");
                        var extenstion = Path.GetExtension(files[0].FileName);

                        if (article.ImageUrl != null)
                        {
                            //this is an edit and we need to remove old image
                            var imagePath = Path.Combine(webRootPath, article.ImageUrl.TrimStart('\\'));
                            if (System.IO.File.Exists(imagePath))
                            {
                                System.IO.File.Delete(imagePath);
                            }
                        }
                        using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                        {
                            files[0].CopyTo(filesStreams);
                        }
                        article.ImageUrl = @"\img\articles\" + fileName + extenstion;
                    }

                    article.Maj = DateTime.Now;
                    _unitOfWork.Article.Update(article);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_unitOfWork.Category.GetAll(), "Id", "Name", article.CategoryId);
            return View(article);
        }


        public IActionResult Lecture(int id)
        {

            Article objFromDb = _unitOfWork.Article.Get(id);
            
            if(objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        public IActionResult ListeArticle(int id)
        {

            IEnumerable<Article> Articles = _unitOfWork.Article.GetWhereCategoryId(id);

            if (Articles == null)
            {
                return NotFound();
            }

            return View(Articles);
        }



        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Article.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            if(objFromDb.ImageUrl != null)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var imagePath = Path.Combine(webRootPath, objFromDb.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

            }
            _unitOfWork.Article.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }



        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
