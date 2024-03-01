using Ders2_Odev3.DataAccess.Abstracts;
using Ders2_Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev3.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> ınstructors;
        public InstructorDal() 
        {
            Instructor ınstructor1 = new Instructor();
            ınstructor1.Id = 1;
            ınstructor1.FirstName = "Engin";
            ınstructor1.LastName = "Demirog";

            Instructor ınstructor2 = new Instructor();
            ınstructor2.Id = 2;
            ınstructor2.FirstName = "Halit Enes";
            ınstructor2.LastName = "Kalaycı";

            ınstructors = new List<Instructor> { ınstructor1, ınstructor2 };

        }
        public List<Instructor> GetAll()
        {
            return ınstructors;
        }
        public void Add(Instructor ınstructor)
        {
            ınstructors.Add(ınstructor);
        }
        public void Delete(Instructor ınstructor)
        {
            ınstructors.Remove(ınstructor);
        }
        public void Update(Instructor ınstructor)
        {
            var value = ınstructors.Where(x => x.Id == ınstructor.Id).FirstOrDefault();
            value.FirstName = ınstructor.FirstName;
            value.LastName = ınstructor.LastName;
            

        }

    }
}
