using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UniversityPortal.Data;

namespace UniversityPortal.Models
{
    public class CreateUserViewModel
    {
        [Required]
        //[RegularExpression("^[A-Z][a-zA-Z]")]
        [StringLength(100, ErrorMessage = "{0}et måste vara minst {2} och max {1} bokstäver långt.", MinimumLength = 2)]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Required]
        //[RegularExpression("^[a-z ,.'-]+$/i", ErrorMessage = "Otillåtna tecken, använd A-Ö")]
        [StringLength(100, ErrorMessage = "{0}et måste vara minst {2} och max {1} bokstäver långt.", MinimumLength = 2)]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Detta är ej en giltig e-postadress")]
        [Display(Name = "E-postadress")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0}et måste vara minst {2} och max {1} karaktärer.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenord")]
        [Compare("Password", ErrorMessage = "Lösenorden matcher inte varandra.")]
        public string ConfirmPassword { get; set; }

        //[Required]
        //public string Role { get; set; }

    }
}
