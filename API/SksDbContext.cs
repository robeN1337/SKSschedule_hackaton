using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class SksDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Stud> Students { get; set; }
        public DbSet<Prep> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Ekz> Ekz { get; set; }
        public DbSet<Mera> Mera { get; set; }
        public DbSet<Timetable> Timetable { get; set; }


    }
}
