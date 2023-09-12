using CodeFirsTEFapp.Application.Interfaces;
using CodeFirsTEFapp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirsTEFapp.Infrastructure.Services
{
    public class Service:Iservice
    {
       private Irepository _repository;
        public Service()
        {

            _repository = new Repository.Repository();
           
        }

        public void Delete(int DeleteId)
        {
            _repository.Delete(DeleteId);
        }

        public void Getall()
        {
            _repository.Getall();
        }

        public void GetByid(int getbyId)
        {
            _repository.GetByid(getbyId);
        }

        public void Insert(string objectname)
        {
            _repository.Insert(objectname);
        }

        public void Update(int iD)
        {
            _repository.Update(iD);
        }
    }
}
