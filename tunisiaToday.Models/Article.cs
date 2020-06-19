using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tunisiaToday.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Titre")]
        public string Title { get; set; }

        [Required, DataType(DataType.MultilineText)]
        [Display(Name = "Contenu")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Categorie")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public DateTime DatePublication { get; set; }


        public DateTime Maj { get; set; }

        [Required]
        [Display(Name="L'article est à  la une :")]
        public bool estUne { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [StringLength(maximumLength: 300, MinimumLength = 6, ErrorMessage = "Attention, champ obligatioire. Veuillez entrez une prévisualisation suffisament courte pour donner un aperçu de l'article.")]
        public string Previsualisation { get; set; }

    }
}
