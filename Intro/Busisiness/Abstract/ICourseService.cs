using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Busisiness.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);
}
