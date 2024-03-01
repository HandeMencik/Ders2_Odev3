using Ders2_Odev3.DataAccess.Abstracts;
using Ders2_Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev3.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Tümü";

            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Programlama(8)";

            categories= new List<Category> { category1, category2 };
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }
        public void Delete(Category category)
        {
            categories.Remove(category);
        }
        public void Update(Category category)
        {
            var value = categories.Where(x => x.Id == category.Id).FirstOrDefault();          
            value.Name = category.Name;

        }

    }
}
