using Ders2_Odev3.DataAccess.Abstracts;
using Ders2_Odev3.DataAccess.Concretes;
using Ders2_Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//business dataccess i newleyemez X
namespace Ders2_Odev3.Business
{
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
    }
}
