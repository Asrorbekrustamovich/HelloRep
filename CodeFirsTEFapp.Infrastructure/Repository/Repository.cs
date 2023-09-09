using CodeFirsTEFapp.Application.Interfaces;
using CodeFirsTEFapp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirsTEFapp.Infrastructure.Repository
{
    internal class Repository : Irepository
    {
        Appdbcontext.AppDbcontext _AppDbcontext;
        public Repository()
        {
            _AppDbcontext = new(); 
        }
        public void Delete(int DeleteId)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine(" To Which table You Wanna get");

                Console.WriteLine("Subjects");
                Console.WriteLine("Teachers");
                string choise = Console.ReadLine();
                int count=0;
                if (choise != null && choise == "Subjects")
                {
                    Subject Deletedobject = _AppDbcontext.Subjects.Select(x => x).Where(x => x.Id == DeleteId).FirstOrDefault();
                    count = _AppDbcontext.Subjects.Select(x => x).Where(x => x.Id == DeleteId).Count();
                    _AppDbcontext.Subjects.Remove(Deletedobject);
                    

                }
                else if (choise != null && choise == "Teachers")
                {
                    Teacher Deletedobject1 = _AppDbcontext.Teachers.Select(x => x).Where(x => x.Id == DeleteId).First();
                    count = _AppDbcontext.Subjects.Select(x => x).Where(x => x.Id == DeleteId).Count();
                    _AppDbcontext.Teachers.Remove(Deletedobject1);
                   
                }
                int something = 1 / count;
               

                _AppDbcontext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("there is no object with that ID");
            }
        }

        public void Getall()
        {
            List<Teacher> TeachersList = _AppDbcontext.Teachers.Select(x => x).OrderBy(x=>x.Name).ToList();
            foreach (var item in TeachersList)
            {
                Console.WriteLine(".Id="+item.Id);
                Console.WriteLine("Salary="+item.Salary);
                Console.WriteLine("Name="+item.Name);
                Console.WriteLine();
                Console.WriteLine();
            }
            List<Subject>SubjectList=_AppDbcontext.Subjects.Select(x=>x).OrderBy(x=>x.Name).ToList();
            foreach (var subject in SubjectList)
            {
                Console.WriteLine("SubjectNAme="+subject.Name);
                Console.WriteLine("Id="+subject.Id);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public async void GetByid(int getbyId)
        {
            Console.WriteLine(" To Which table You Wanna get");
            Console.WriteLine("Subjects");
            Console.WriteLine("Teachers");
            string choise = Console.ReadLine();
            if (choise != null && choise == "Subjects")
            {
                List<Subject> SubjectonthatID = await _AppDbcontext.Subjects.Select(x => x).Where(x => x.Id == getbyId).ToListAsync();
                foreach (var subject in SubjectonthatID)
                {
                    Console.WriteLine("Subject Name=" + subject.Name);
                    Console.WriteLine("Subject ID=" + subject.Id);
                    await Console.Out.WriteLineAsync();
                }
            }
            else if (choise != null && choise == "Teachers")
                {

                List<Teacher> TeacheronThatID = await _AppDbcontext.Teachers.Select(x => x).Where(x => x.Id == getbyId).ToListAsync();
                foreach (var teacher in TeacheronThatID)
                {
                    await Console.Out.WriteLineAsync("Teacher_NAme=" + teacher.Name);
                    await Console.Out.WriteLineAsync("Teacher_ID=" + teacher.Id);
                    await Console.Out.WriteLineAsync("Teacher_salary=" + teacher.Salary);
                    await Console.Out.WriteLineAsync();
                } }
        }

        public void Insert(string objectname)
        {
            try
            {
                InsertingObject insertingObject = new InsertingObject();
                if (objectname != null && objectname == "Subjects")
                {

                    _AppDbcontext.Subjects.Add(insertingObject.InsertingSubjects());
                }
                else if (objectname != null && objectname == "Teachers")
                {
                    _AppDbcontext.Teachers.Add(insertingObject.Insertingteacher());
                }
                else
                {
                    Console.WriteLine("You got wrong in inserting");
                }
                _AppDbcontext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something wrong Inserting");
            }
        }

        public void Update(int iD)
        {
            try
            {
                Console.WriteLine(" To Which table You Wanna Update");
                Console.WriteLine("Subjects");
                Console.WriteLine("Teachers");
                int count = 0;
                string choise = Console.ReadLine();
                if (choise != null && choise == "Subjects")
                {
                    var UpdateObject = _AppDbcontext.Subjects.Select(x => x).Where(x => x.Id == iD).ToList();
                    count = UpdateObject.Count;
                    Console.WriteLine("New Name=");
                    UpdateObject.First().Name = Console.ReadLine();
                }
                else if (choise != null && choise == "Teachers")
                {
                    var UpdatTeacher = _AppDbcontext.Teachers.Select(x => x).Where(x => x.Id == iD).ToList();
                    count = UpdatTeacher.Count();
                    Console.WriteLine("insert New Teacher Name=");
                    UpdatTeacher.First().Name = Console.ReadLine();
                    Console.WriteLine("Insert New Salary ");
                    UpdatTeacher.First().Salary = Convert.ToInt32(Console.ReadLine());
                    _AppDbcontext.SaveChanges();
                }
                count = 1 / count;
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is no object with that iD");
            }


        }
    }
}
