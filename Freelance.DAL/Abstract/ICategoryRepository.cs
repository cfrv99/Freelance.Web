using Freelance.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelance.DAL.Abstract
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
        IQueryable<Category> GetCategories();

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
