using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Product entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Product entity)
        {
            db.Products.Remove(entity);
            return Save();
        }

        public ICollection<Product> FindAll()
        {
            var List = db.Products.Include(q => q.Category).ToList();
            return List;
        }

        public Product FindById(string id)
        {
            var product = db.Products.Where(q => q.ProductId == id).FirstOrDefault();
            return product;
        }

        public bool isExists(string id)
        {
            return db.Products.Any(q => q.ProductId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Product entity)
        {
            db.Products.Update(entity);
            return Save();
        }
    }
}
