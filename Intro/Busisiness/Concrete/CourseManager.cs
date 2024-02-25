using Intro.Busisiness.Abstract;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Busisiness.Concrete;

public class CourseManager:ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
       _courseDal.Add(course);
    }

    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }

    public List<Course> GetAll()
    {

        return _courseDal.GetAll();

    }

    public void Update(Course course)
    {
      _courseDal.Update(course);
    }
}
