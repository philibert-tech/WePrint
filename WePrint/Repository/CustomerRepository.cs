using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext db;
        public CustomerRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Customer entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Customer entity)
        {
            db.Customers.Remove(entity);
            return Save();
        }

        public ICollection<Customer> FindAll()
        {
            var List = db.Customers.ToList();
            return List;
        }

        public Customer FindById(string id)
        {
            var Customer = db.Customers.Where(q => q.Id == id).FirstOrDefault();
            return Customer;
        }


        public bool isExists(string id)
        {
            return db.Customers.Any(q => q.Id == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Customer entity)
        {
            db.Customers.Update(entity);
            return Save();
        }
    }
}
