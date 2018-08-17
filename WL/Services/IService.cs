using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WL.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetEntityById(int id);
        void  AddEntity(T model);
        void Update(T model);
        void Delete(T model);
    }
}