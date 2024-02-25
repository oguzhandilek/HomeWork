using Intro.Busisiness.Concrete;
using Intro.DataAccess.Concretes;
using Intro.Entities;

CourseManager courseManager = new( new CourseDal());
List<Course> courses = courseManager.GetAll();

CategoryManager categoryManager = new( new CategoryDal());
List<Category> categories = categoryManager.GetAll();

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

Console.WriteLine("------------Kurslar------------");

foreach (var course in courses)
{
    Console.WriteLine(course.Name+"/"+course.Price);
}

Console.WriteLine("------------Kategoriler------------");
foreach (var category in categories)
{
 
    Console.WriteLine(category.Id+": "+category.Name);
}
Console.WriteLine("------------Eğitmenler------------");
foreach (var instructor in instructors)
{
  
    Console.WriteLine(instructor.FirstName+" "+instructor.LastName);
}

