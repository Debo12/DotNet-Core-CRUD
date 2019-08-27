using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        [Column(TypeName ="varchar(250)")]
        public string EmployeeName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmployeeCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
