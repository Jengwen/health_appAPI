using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace health_app2.Models
{
    public class Record
    {
        [Required]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Temperature { get; set; }
        public int EmployeeID { get; set; }
        public int UnitID { get; set; }
        public bool Fever { get; set; }
        public bool Contact { get; set; }
        public bool VorD { get; set; }
        public bool Breath { get; set; }
        public bool Taste { get; set; }
        public string ApplicationUserID { get; set; }
        //instance of unit, employee
        public Unit unit { get; set; }
        public Employee employee { get; set; }
        public ApplicationUser account { get; set; }
    }
}
