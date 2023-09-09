using CodeFirsTEFapp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Infrastructure.Repository
{
    public class InsertingObject
    {
        public Subject InsertingSubjects()
        {
            Subject subject = new Subject();
            Console.WriteLine("insert Subject name");
            subject.Name = Console.ReadLine();
            Console.WriteLine("insert Subject Id");
            subject.Id=Convert.ToInt32(Console.ReadLine());
            return subject;


        }
        public  Teacher Insertingteacher()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("insert Teacher Name=");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Insert Teacher Id=");
            teacher.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert Teacher Salary");
            teacher.Salary=Convert.ToInt32(Console.ReadLine());
            return teacher;
        }
    }
}
