using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net8 ....";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17 ....";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12 ....";
        course3.Price = 0;
        courses=new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //sql öğren
    //db iemeleri yapılır
    return courses;

    }

public void Add(Course course)
{
    courses.Add(course);
}

    public void Delete(int id)
    {
        Course courseDelete=courses.SingleOrDefault(c=> c.Id == id);
        if (courseDelete != null)
        {
            courses.Remove(courseDelete);
        }
        else
        {
            Console.WriteLine("Kurs blunamadı!");
        }
    }

    public void Update(Course course)
    {
        Course courseUpdate=courses.SingleOrDefault(c=> c.Id == course.Id);
        if (courseUpdate != null)
        {
            courseUpdate.Name = course.Name;
            courseUpdate.Description = course.Description;
            courseUpdate.Price = course.Price;
            courseUpdate.InstructorId= course.InstructorId;
            courseUpdate.CategoryId= course.CategoryId;
            Console.WriteLine("Güncelleme başaralı");
        }
        else
        { Console.WriteLine("Kurs bulunamadı!"); }
    }
}
