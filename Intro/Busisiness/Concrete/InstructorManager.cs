using Intro.Busisiness.Abstract;
using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Busisiness.Concrete;

public class InstructorManager:IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(int id)
    {
        _instructorDal.Delete(id);
    }

    public List<Instructor> GetAll()
    {
       return _instructorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
       _instructorDal.Update(instructor);   
    }
}
