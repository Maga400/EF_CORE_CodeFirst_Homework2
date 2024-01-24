using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class GroupLecture : BaseEntity
{

    [Required]
    [ForeignKey("Group")]
    public int GroupId { get; set; }
    public Group Group { get; set; }

    [Required]
    [ForeignKey("Lecture")]
    public int LectureId { get; set;}
    public Lecture Lecture { get; set;}
    public GroupLecture() 
    {
    
    }
    public GroupLecture(int groupId, Group group, int lectureId, Lecture lecture)
    {
        GroupId = groupId;
        Group = group;
        LectureId = lectureId;
        Lecture = lecture;
    }
}
