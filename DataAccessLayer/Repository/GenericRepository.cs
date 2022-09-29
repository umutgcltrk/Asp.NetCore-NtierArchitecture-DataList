using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private ConnectingContext context = new ConnectingContext();
        public void Insert(T t)
        {
            context.Add(t);
        }
        public void Update(T t)
        {
            context.Update(t);
        }
        public void Delete(T t)
        {
            context.Remove(t);
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }


        
    }
}
