using CodeFirsTEFapp.Application.Interfaces;
using CodeFirsTEFapp.Infrastructure.Services;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Presentation
{
    public  class Controller
    {
       private Iservice _service;
        public Controller()
        {
          _service = new Service();
        }
        public  void Start()
        {
            bool istrue = true;
            while (istrue)
            {
                Console.WriteLine("1.insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.getall");
                Console.WriteLine("5.GetbyID");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("insert object name");
                        Console.WriteLine("Teachers or Subjects");
                        string objectname=Console.ReadLine();
                        _service.Insert(objectname);break;
                    case 2:
                        Console.WriteLine("Insert UPdateID=");
                        int UpdateID = Convert.ToInt32(Console.ReadLine());
                        _service.Update(UpdateID);break;
                    case 3:
                        Console.WriteLine("Insert DeleteID=");
                        int DeleteID= Convert.ToInt32(Console.ReadLine());
                        _service.Delete(DeleteID);
                        break;
                    case 4:  _service.Getall(); break;

                    case 5:
                        Console.WriteLine("insert Id that you wanna get");
                        int Choisetoget = Convert.ToInt32(Console.ReadLine()); _service.GetByid(Choisetoget); break;
                }
            }
        }
    }
}
