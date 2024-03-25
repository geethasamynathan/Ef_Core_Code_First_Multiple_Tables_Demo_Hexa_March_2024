using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ef_Core_Code_First_Multiple_Tables_Demo.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        [JsonIgnore]
        public IList<Employee> Employees { get; set; }
    }
}
