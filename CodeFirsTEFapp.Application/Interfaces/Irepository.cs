using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Application.Interfaces
{
    public interface Irepository
    {
        public void Insert(string objectname);
        public void Update(int iD);
        public void Delete(int DeleteId);
        public void Getall();
        public void GetByid(int getbyId);
    }
}
