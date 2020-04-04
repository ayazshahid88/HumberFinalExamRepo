using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NET._31.Final.Pocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NET._31.Final.EFRepo
{
    public class NET31FinalContext : DbContext
    {
        public DbSet<CoursePoco> SchoolCourses { get; set; }
        public DbSet<TeacherPoco> SchoolTeachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string _connStr = "Data Source=Ayaz-PC\\HUMBERBRIDGING;Initial Catalog=Final_Exam_DB;Integrated Security=True";

            optionsBuilder.UseSqlServer(_connStr);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CoursePoco>(entity =>
            {
                entity.ToTable("School_Courses");

                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Teacher)
                .WithMany(p => p.SchoolCourses)
                .HasForeignKey(e => e.TeacherId);

            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
