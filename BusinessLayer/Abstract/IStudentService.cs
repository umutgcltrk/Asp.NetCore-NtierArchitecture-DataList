using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void Insert(Student student);
        void Update(Student student);
        void Delete(Student student);
        List<Student> GetListAll();
        Student GetById(int id);
    }
}
