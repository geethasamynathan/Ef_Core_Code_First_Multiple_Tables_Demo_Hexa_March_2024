using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_Core_Code_First_Multiple_Tables_Demo.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
       // [Column("Name")]
        // [DisplayName("Emp Name")]
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
