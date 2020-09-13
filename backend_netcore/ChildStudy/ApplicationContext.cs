using ChildStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace ChildStudy
{
    public class ApplicationContext : DbContext
    { 
        //public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Way> Ways { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Timetable> Timetable { get; set; }
        public DbSet<Raiting> Raitings { get; set; }

        //Add-Migration Initial
        //Update-Database
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=195.128.126.208;Port=5432;Database=hakaton;Username=postgres;Password=ldflwfnmgznm25");
        }
    }
}
