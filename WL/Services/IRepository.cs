using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL.Services
{
    public interface IRepository<T> : IDisposable
    {
        List<T> Get();
        void Create(T model);
        void Update(T model);
        void Delete(int id);
        void Commit();
    }
}
