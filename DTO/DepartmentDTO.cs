using System.ComponentModel.DataAnnotations;

namespace Ef_Core_Code_First_Multiple_Tables_Demo.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public string Location { get; set; }
    }
}
