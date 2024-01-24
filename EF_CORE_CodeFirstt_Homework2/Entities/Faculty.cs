using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Faculty : BaseEntity
{
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }
    public ICollection<Department> Departments { get; set; }
    public Faculty()
    {

    }
    public Faculty(string name, ICollection<Department> departments)
    {
        Name = name;
        Departments = departments;
    }
}
