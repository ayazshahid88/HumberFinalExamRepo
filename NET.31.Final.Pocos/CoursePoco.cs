using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NET._31.Final.Pocos
{
    [Table("School_Courses")]
    public class CoursePoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid TeacherId { get; set; }  

        public string CourseName { get; set; }

        public virtual TeacherPoco Teacher { get; set; }
    } 
}
