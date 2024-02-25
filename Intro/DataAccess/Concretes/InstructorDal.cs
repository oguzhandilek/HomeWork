using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";
            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Hait Enes";
            instructor2.LastName = "Kalaycı";
            Instructor instructor3 = new Instructor();
            instructor3.Id = 3;
            instructor3.FirstName = "Oğuzhan";
            instructor3.LastName = "Dilek";
            _instructors = new List<Instructor> { instructor1, instructor2,instructor3 };
        }
        public void Add(Instructor instructor)
        {
          
            _instructors.Add(instructor);

        }

        public void Delete(int id)
        {
            Instructor instructorDelete=_instructors.SingleOrDefault(x => x.Id == id);
            if (instructorDelete!=null)
            {
                _instructors.Remove(instructorDelete);
            }
            else
            {
                Console.WriteLine("Eğitmen bulunamadı!");
            }
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
           Instructor instructorUpdate=_instructors.SingleOrDefault(c=>c.Id == instructor.Id);
            if (instructorUpdate!=null)
            {
                instructorUpdate.FirstName = instructor.FirstName;
                instructorUpdate.LastName= instructor.LastName;
            }
        }
    }
}
