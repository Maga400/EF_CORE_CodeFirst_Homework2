using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class Curator : BaseEntity
{
    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Surname {get; set; }
    public ICollection<GroupCurator> GroupCurators { get; set; }

    public Curator() 
    {
    
    }
    public Curator(string name, string surname, ICollection<GroupCurator> groupCurators)
    {
        Name = name;
        Surname = surname;
        GroupCurators = groupCurators;
    }
}
