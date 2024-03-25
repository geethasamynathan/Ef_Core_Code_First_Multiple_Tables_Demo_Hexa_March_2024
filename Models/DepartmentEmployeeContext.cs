using Microsoft.EntityFrameworkCore;
using Ef_Core_Code_First_Multiple_Tables_Demo.DTO;

namespace Ef_Core_Code_First_Multiple_Tables_Demo.Models
{
    public class DepartmentEmployeeContext:DbContext
    {
        public DepartmentEmployeeContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Ef_Core_Code_First_Multiple_Tables_Demo.DTO.DepartmentDTO> DepartmentDTO { get; set; } = default!;
    }
}
