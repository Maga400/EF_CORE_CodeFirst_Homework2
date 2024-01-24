using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Subject : BaseEntity
{
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }
    public ICollection<Lecture> Lectures { get; set; }
    public Subject() 
    {
    
    }
    public Subject(string name, ICollection<Lecture> lectures)
    {
        Name = name;
        Lectures = lectures;
    }
}
