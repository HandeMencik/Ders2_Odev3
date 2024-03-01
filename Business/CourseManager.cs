using Ders2_Odev3.DataAccess.Abstracts;
using Ders2_Odev3.DataAccess.Concretes;
using Ders2_Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev3.Business
{
    // operasyon tutucu sınıf 
    

    public class CourseManager
    {
        //Dependency injection
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            // business rules
            return _courseDal.GetAll();
        }
        
    }
}
