using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.DatabaseContext
{
    public class TeacherPupilContexts : DbContext
    {
        public DbSet<Pupil> Pupil { get; set; } = null!;//DbSet can be used to query and and save instances of its entity type. LINQ queries against a DbSet will be translated into queries against the database
        public DbSet<Teacher> Teacher { get; set; } = null!; //using DbSet indicates for EF core that there will be a table in the database called PointOfInterests
        public DbSet<TeacherPupil> TeacherPupil { get; set; } = null!;
        public TeacherPupilContexts(DbContextOptions<TeacherPupilContexts> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasData(   
                new Teacher()
                {
                    Id = 1,
                    Name = "John",
                    LastName = "Doe",
                    Sex = "Male",
                    Subject = "Math"
                },
                new Teacher()
                {
                    Id = 2,
                    Name = "Jane",
                    LastName = "Doe",
                    Sex = "Female",
                    Subject = "English"
                },
                new Teacher()
                {
                    Id = 3,
                    Name = "Bob",
                    LastName = "Smith",
                    Sex = "Male",
                    Subject = "Science"
                },
                new Teacher()
                {
                    Id = 4,
                    Name = "Mary",
                    LastName = "Johnson",
                    Sex = "Female",
                    Subject = "History"
                },
                new Teacher()
                {
                    Id = 5,
                    Name = "Tom",
                    LastName = "Williams",
                    Sex = "Male",
                    Subject = "Art"
                }
                );

            modelBuilder.Entity<Pupil>()
             .HasData(
                new Pupil()
                {
                    Id = 1,
                    Name = "Alice",
                    LastName = "Smith",
                    Sex = "Female",
                    Class = "5A"
                },
                new Pupil()
                {
                    Id = 2,
                    Name = "Bob",
                    LastName = "Johnson",
                    Sex = "Male",
                    Class = "5A"
                },
                new Pupil()
                {
                    Id = 3,
                    Name = "Charlie",
                    LastName = "Williams",
                    Sex = "Male",
                    Class = "5B"
                },
                new Pupil()
                {
                    Id = 4,
                    Name = "Diana",
                    LastName = "Miller",
                    Sex = "Female",
                    Class = "5B"
                },
                new Pupil()
                {
                    Id = 5,
                    Name = "Emily",
                    LastName = "Brown",
                    Sex = "Female",
                    Class = "5C"
                },
                new Pupil()
                {
                    Id = 6,
                    Name = "Frank",
                    LastName = "Davis",
                    Sex = "Male",
                    Class = "5C"
                },
                new Pupil()
                {
                    Id = 7,
                    Name = "Grace",
                    LastName = "Garcia",
                    Sex = "Female",
                    Class = "5D"
                },
                new Pupil()
                {
                    Id = 8,
                    Name = "Henry",
                    LastName = "Taylor",
                    Sex = "Male",
                    Class = "5D"
                }
               
               );
            modelBuilder.Entity<TeacherPupil>().HasKey(bc => new { bc.PupilId, bc.TeacherId });
            modelBuilder.Entity<TeacherPupil>()
             .HasData(
                new TeacherPupil()
                {
                    PupilId = 1,
                    TeacherId = 2
                },
                new TeacherPupil()
                {
                    PupilId = 1,
                    TeacherId = 4
                },
                new TeacherPupil()
                {
                    PupilId = 2,
                    TeacherId = 1
                },
                new TeacherPupil()
                {
                    PupilId = 2,
                    TeacherId = 5
                },
                new TeacherPupil()
                {
                    PupilId = 3,
                    TeacherId = 2
                },
                new TeacherPupil()
                {
                    PupilId = 3,
                    TeacherId = 3
                },
                new TeacherPupil()
                {
                    PupilId = 3,
                    TeacherId = 5
                },
                new TeacherPupil()
                {
                    PupilId = 4,
                    TeacherId = 5
                },
                new TeacherPupil()
                {
                    PupilId = 4,
                    TeacherId = 1
                },
                new TeacherPupil()
                {
                    PupilId = 5,
                    TeacherId = 1
                },
                new TeacherPupil()
                {
                    PupilId = 5,
                    TeacherId = 3
                },
                new TeacherPupil()
                {
                    PupilId = 5,
                    TeacherId = 2
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}

