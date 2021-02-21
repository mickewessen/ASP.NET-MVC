using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPortal.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "{0}et måste vara minst {2} och max {1} bokstäver långt.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "{0}et måste vara minst {2} och max {1} bokstäver långt.", MinimumLength = 2)]
        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
