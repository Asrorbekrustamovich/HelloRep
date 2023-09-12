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
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary {get; set; }
        List<TeacherSubject> teacherSubjects;
    }
    public class Subject
    {
        public string Name { get; set; }
        public int Id { get;set; }
        List<TeacherSubject> teacherSubjects;

    }
    public class TeacherSubject
        
    {
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }  
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
