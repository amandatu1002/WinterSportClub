using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShoppingWeb.Models
{
    public class ManageUser
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "{0}Please enter at least {2} characters.", MinimumLength = 1)]
        [Display(Name="Name")]
        public string NickName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Photo")]
        public string ImgUrl { get; set; }
    
    }
}