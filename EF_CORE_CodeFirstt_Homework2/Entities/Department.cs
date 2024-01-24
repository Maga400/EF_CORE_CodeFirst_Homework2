using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Encodings.Web;
using System.Xml;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Department : BaseEntity
{
    [Required]
    [Range(minimum:1,maximum:5)]
    public int Building { get; set; }

    [Required]
    [Range(minimum:0,maximum:int.MaxValue)]
    [DefaultValue(0)]
    public double Financing { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    //[Index(nameof(Url), IsUnique = true)]
    public string Name { get; set; }

    [Required]
    [ForeignKey("Faculty")]
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    public ICollection<Group> Groups { get; set; }
    public Department() 
    {
    
    }
    public Department(int building, double financing, string name, int facultyId, Faculty faculty, ICollection<Group> groups)
    {
        Building = building;
        Financing = financing;
        Name = name;
        FacultyId = facultyId;
        Faculty = faculty;
        Groups = groups;
    }
}
