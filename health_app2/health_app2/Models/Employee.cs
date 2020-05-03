using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace health_app2.Models
{
    public class Employee
    {

        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitID { get; set; }
        public string ApplicationUserID { get; set; }
        //instance of unit foreign key
        public Unit unit { get; set; }
        public ApplicationUser account { get; set; }
    }
}
