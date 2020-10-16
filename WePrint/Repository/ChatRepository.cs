using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Contracts;
using WePrint.Data;

namespace WePrint.Repository
{
    public class ChatRepository : IChatRepository
    {
        private readonly ApplicationDbContext db;
        public ChatRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public bool Create(Chat entity)
        {
            var insert = db.Add(entity);
            return Save();
        }

        public bool Delete(Chat entity)
        {
            db.Chats.Remove(entity);
            return Save();
        }

        public ICollection<Chat> FindAll()
        {
            var List = db.Chats.Include(q => q.Customer).ToList();
            return List;
        }

        public Chat FindById(string id)
        {
            var Chat = db.Chats.Where(q => q.ChatId == id).FirstOrDefault();
            return Chat;
        }

        public bool isExists(string id)
        {
            return db.Chats.Any(q => q.ChatId == id);
        }

        public bool Save()
        {
            var changes = db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Chat entity)
        {
            db.Chats.Update(entity);
            return Save();
        }
    }
}
