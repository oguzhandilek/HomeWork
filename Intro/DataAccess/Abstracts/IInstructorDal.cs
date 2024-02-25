using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);


}
