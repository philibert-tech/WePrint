using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext db;
        public CartRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Cart entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Cart entity)
        {
            db.Carts.Remove(entity);
            return Save();
        }

        public ICollection<Cart> FindAll()
        {
            var List = db.Carts
                .Include(q => q.Product)
                .Include(q => q.Customer)
                .ToList();
            return List;
        }

        public Cart FindById(string id)
        {
            var Cart = db.Carts.Where(q => q.CartId == id).FirstOrDefault();
            return Cart;
        }

        public bool isExists(string id)
        {
            return db.Carts.Any(q => q.CartId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Cart entity)
        {
            db.Carts.Update(entity);
            return Save();
        }
    }
}
