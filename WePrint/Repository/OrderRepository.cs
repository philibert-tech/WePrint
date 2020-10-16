using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext db;
        public OrderRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Order entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Order entity)
        {
            db.Orders.Remove(entity);
            return Save();
        }

        public ICollection<Order> FindAll()
        {
            var List = db.Orders
                .Include(q => q.Product)
                 .Include(q => q.Customer)
                .ToList();
            return List;
        }

        public Order FindById(string id)
        {
            var Order = db.Orders.Where(q => q.OrderId == id).FirstOrDefault();
            return Order;
        }

        public bool isExists(string id)
        {
            return db.Orders.Any(q => q.OrderId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Order entity)
        {
            db.Orders.Update(entity);
            return Save();
        }
    }
}
