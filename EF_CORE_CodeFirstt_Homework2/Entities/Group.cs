using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Group : BaseEntity
{
    [Column(TypeName = "nvarchar(10)")]
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(minimum:1,maximum:5)]
    public int Year { get; set; }

    [Required]
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<GroupCurator> GroupCurators { get; set; }
    public ICollection<GroupStudent> GroupStudents { get; set; }
    public ICollection<GroupLecture> GroupLectures { get; set; }
    public Group() 
    {

    }
    public Group(string name, int year, int departmentId, Department department, ICollection<GroupCurator> groupCurators, ICollection<GroupStudent> groupStudents, ICollection<GroupLecture> groupLectures)
    {
        Name = name;
        Year = year;
        DepartmentId = departmentId;
        Department = department;
        GroupCurators = groupCurators;
        GroupStudents = groupStudents;
        GroupLectures = groupLectures;
    }
}
