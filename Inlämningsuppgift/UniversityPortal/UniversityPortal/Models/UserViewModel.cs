using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityPortal.Data;

namespace UniversityPortal.Models
{
    public class UserViewModel:ApplicationUser
    {
        public IEnumerable<string> Roles { get; set; }
        public string Class { get; set; }       
    }
}
