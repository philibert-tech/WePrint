using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext db;
        public AccountRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Account entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Account entity)
        {
            db.Accounts.Remove(entity);
            return Save();
        }

        public ICollection<Account> FindAll()
        {
            var List = db.Accounts.Include(q => q.Customer).ToList();
            return List;
        }

        public Account FindById(string id)
        {
            var Account = db.Accounts.Where(q => q.AccountId == id).FirstOrDefault();
            return Account;
        }

        public bool isExists(string id)
        {
            return db.Accounts.Any(q => q.AccountId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Account entity)
        {
            db.Accounts.Update(entity);
            return Save();
        }
    }
}
