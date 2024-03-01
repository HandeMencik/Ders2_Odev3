using Ders2_Odev3.DataAccess.Abstracts;
using Ders2_Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev3.DataAccess.Concretes
{

    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET) ";
            course1.Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız. ";
           

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course2.Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
           

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
            

            Course course4 = new Course();
            course4.Id = 4;
            course4.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";


            Course course5 = new Course();
            course5.Id = 5;
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";


            Course course6 = new Course();
            course6.Id = 6;
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course6.Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";


            Course course7 = new Course();
            course7.Id = 7;
            course7.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course7.Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";


            Course course8 = new Course();
            course8.Id = 8;
            course8.Name = "Programlamaya Giriş için Temel Kurs";
            course8.Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.";


            courses = new List<Course> {course1, course2, course3, course4, course5, course6, course7, course8};
        }
        public List<Course> GetAll()
        {
            // burada db işlemleri yapılır
         
            return courses;
        }
        public void Add(Course course)
        {

            courses.Add(course);
        }
        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public void Update(Course course)
        {
            var value = courses.Where(x => x.Id == course.Id).FirstOrDefault();
            value.Description = course.Description;           
            value.Name = course.Name;
            
        }
    }
}
