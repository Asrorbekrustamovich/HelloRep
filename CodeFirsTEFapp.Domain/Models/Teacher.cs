using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Domain.Models
{
    public class Teacher
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("F_KEy"),Column("hello")]
        public int Salary {get; set; }
    }
    public class Subject
    {
        public string Name { get; set; }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;set; }
    }
    public class TeacherSubject
        
    {
        [ForeignKey("Subject_Fk")]
        [Key]
        public int SubjectID { get; set; }
        [ForeignKey("Teacher_Fk")]
        [Key]
        public int TeacherID { get; set; }  
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
