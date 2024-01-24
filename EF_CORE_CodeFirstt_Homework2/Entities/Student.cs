using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Student : BaseEntity
{
    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(minimum:0,maximum:5)]
    public int Rating { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Surname { get; set; }
    public ICollection<GroupStudent> GroupStudents { get; set; }
    public Student() 
    {
    
    }
    public Student(string name, int rating, string surname, ICollection<GroupStudent> groupStudents)
    {
        Name = name;
        Rating = rating;
        Surname = surname;
        GroupStudents = groupStudents;
    }
}
