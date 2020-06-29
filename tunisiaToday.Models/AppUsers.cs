using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace tunisiaToday.Models
{
    // Add profile data for application users by adding properties to the tunisiaTodayUser class
    public class AppUsers : IdentityUser
    {

        //[Required]
        //public string Name { get; set; }
        //public string StreetAddress { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string PostalCode { get; set; }


        [NotMapped]
        public string Role { get; set; }
    }
}
