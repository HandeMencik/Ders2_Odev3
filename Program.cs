// See https://aka.ms/new-console-template for more information
using Ders2_Odev3.Business;
using Ders2_Odev3.DataAccess.Concretes;
using Ders2_Odev3.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Id+" "+ courses[i].Name);
}

Console.WriteLine("******");

InstructorManager instructorMenager = new(new InstructorDal());
List<Instructor> ınstructors = instructorMenager.GetAll();
for (int i = 0;i < ınstructors.Count; i++)
{
    Console.WriteLine(ınstructors[i].FirstName + " " + ınstructors[i].LastName);
}

Console.WriteLine("******");

CategoryManager categoryMenager = new(new CategoryDal());
List<Category> categories = categoryMenager.GetAll();
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].Id + " " + categories[i].Name);
}






