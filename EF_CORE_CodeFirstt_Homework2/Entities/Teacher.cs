using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Teacher : BaseEntity
{
    [Required]
    [DefaultValue("false")]
    public bool IsProfessor { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(minimum:1,maximum:int.MaxValue)]
    public double Salary { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Surname { get; set; }
    public ICollection<Lecture> Lectures { get; set; }
    public Teacher() 
    {
        
    }
    public Teacher(bool ısProfessor, string name, double salary, string surname, ICollection<Lecture> lectures)
    {
        IsProfessor = ısProfessor;
        Name = name;
        Salary = salary;
        Surname = surname;
        Lectures = lectures;
    }
}
