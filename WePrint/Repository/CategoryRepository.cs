using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Category entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Category entity)
        {
            db.Categories.Remove(entity);
            return Save();
        }

        public ICollection<Category> FindAll()
        {
            var List = db.Categories.ToList();
            return List;
        }

        public Category FindById(string id)
        {
            var Category = db.Categories.Where(q => q.CategoryId == id).FirstOrDefault();
            return Category;
        }

        public bool isExists(string id)
        {
            return db.Categories.Any(q => q.CategoryId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Category entity)
        {
            db.Categories.Update(entity);
            return Save();
        }
    }
}
