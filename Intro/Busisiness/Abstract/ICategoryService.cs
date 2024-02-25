using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Busisiness.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();

    void Add(Category category);
    void Update(Category category);
    void Delete(int id);
}
