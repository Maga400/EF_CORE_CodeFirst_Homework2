using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Lecture : BaseEntity
{
    [Required]
    [Range(typeof(DateTime),minimum:"01.01.1990",maximum:"01.24.2024" )]
    public DateTime LectureDate { get; set; }

    [Required]
    [ForeignKey("Subject")]
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    [Required]
    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set;}
    public ICollection<GroupLecture> GroupLectures { get; set; }

    public Lecture() 
    {
    
    }
    public Lecture(DateTime lectureDate, int subjectId, Subject subject, int teacherId, Teacher teacher, ICollection<GroupLecture> groupLectures)
    {
        LectureDate = lectureDate;
        SubjectId = subjectId;
        Subject = subject;
        TeacherId = teacherId;
        Teacher = teacher;
        GroupLectures = groupLectures;
    }
}
