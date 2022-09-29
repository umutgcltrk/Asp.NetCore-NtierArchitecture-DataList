using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void Insert(Student t)
        {
            //Örnek iş kuralı
            if(t.StudentID != null & t.StudentNo !=null)
            {
                _studentDal.Insert(t);
            }
            else
            {
                //Hata mesajı
            }
            
        }

        public void Update(Student t)
        {
            _studentDal.Update(t);
        }
        public void Delete(Student t)
        {
            _studentDal.Delete(t);
        }

        public Student GetById(int id)
        {
            return _studentDal.GetByID(id);
        }

        public List<Student> GetListAll()
        {
          
                return _studentDal.GetListAll();
            
        }

       
    }
}
