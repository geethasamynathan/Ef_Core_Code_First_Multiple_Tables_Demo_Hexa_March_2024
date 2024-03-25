using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ef_Core_Code_First_Multiple_Tables_Demo.Models
{
    public class Employee
    {
        [Column("EmpId")]
        public int EmployeeId { get; set; }
        [Column("Name")]
       // [DisplayName("Emp Name")]
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        [JsonIgnore]
        public virtual Department Department { get; set; }// navigation property
    }
}
