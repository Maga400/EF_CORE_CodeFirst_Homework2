using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class GroupCurator : BaseEntity
{
    [Required]
    [ForeignKey("Curator")]
    public int CuratorId { get; set; }
    public Curator Curator { get; set; }

    [Required]
    [ForeignKey("Group")]
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public GroupCurator()
    {

    }
    public GroupCurator(int curatorId, Curator curator, int groupId, Group group)
    {
        CuratorId = curatorId;
        Curator = curator;
        GroupId = groupId;
        Group = group;
    }
}
