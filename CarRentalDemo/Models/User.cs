namespace CarRentalDemo.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    //Napravih class User i nasledih IdentityUser zashtoto za da imam tablica Dealer mi iska Id, a tuk go vzimam Id-to ot tablicata User
    public class User : IdentityUser
    {
        [MinLength(5)]
        [MaxLength(50)]
        public string FullName { get; set; }
    }
}
