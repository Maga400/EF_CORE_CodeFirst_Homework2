using System.ComponentModel.DataAnnotations;

namespace EF_Core_CodeFirst_Homework2.Entities;
public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public BaseEntity() 
    {
    
    }

    public BaseEntity(int ıd)
    {
        Id = ıd;
    }
}
