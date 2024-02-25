using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Backend";
            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Frontend";
            Category category3 = new Category();
            category3.Id = 3;
            category3.Name = "FullStack";
            _categories = new List<Category> { category1, category2, category3 };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
           Category deleteCategory=_categories.SingleOrDefault(c=>c.Id == id);
            if (deleteCategory != null)
            {
                _categories.Remove(deleteCategory);

            }
            else
            {
                Console.WriteLine("Kategori bulunamadı!");
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
           Category categoryUpdate=_categories.SingleOrDefault(c=> c.Id == category.Id);
            if (categoryUpdate != null)
            {
                category.Name = categoryUpdate.Name;
            }
            else
            { Console.WriteLine("Kategori bulunamadı!");
            }
        }
    }
}
