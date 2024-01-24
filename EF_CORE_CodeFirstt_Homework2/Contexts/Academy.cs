using EF_Core_CodeFirst_Homework2.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EF_Core_CodeFirst_Homework2.Contexts;
public class AcademyDBContext : DbContext
{ 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=AcademyyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculty { get; set;}
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set; }
    public DbSet<GroupLecture> GroupsLectures { get; set; }
    public DbSet<GroupStudent> GroupsStudents { get; set;}
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

}
