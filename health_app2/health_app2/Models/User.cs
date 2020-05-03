using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health_app2.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string ApplicationUserID { get; set; }
        public ApplicationUser account { get; set; }
    }
}
