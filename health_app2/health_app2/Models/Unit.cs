using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health_app2.Models
{
    public class Unit
    {
        [Required]
        public int Id { get; set; }
        public string ApplicationUserID { get; set; }
        public ApplicationUser account { get; set; }
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
}
