using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NET._31.Final.Pocos
{
    [Table("School_Teachers")]
    public class TeacherPoco
    {
        [Key]
        public Guid Id { get; set; }

        public string TeacherName { get; set; }

        public virtual ICollection<CoursePoco> SchoolCourses { get; set; } 
    }
}
