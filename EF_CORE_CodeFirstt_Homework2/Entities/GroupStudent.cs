using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class GroupStudent : BaseEntity
{
    [Required]
    [ForeignKey("Group")]
    public int GroupId { get; set; }
    public Group Group { get; set; }

    [Required]
    [ForeignKey("Student")]
    public int StudentId { get; set;}
    public Student Student { get; set;}
    public GroupStudent() 
    {
    
    }
    public GroupStudent(int groupId, Group group, int studentId, Student student)
    {
        GroupId = groupId;
        Group = group;
        StudentId = studentId;
        Student = student;
    }
}
