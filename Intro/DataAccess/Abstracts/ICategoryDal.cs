using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Delete(int id);
    void Update(Category category);


}
