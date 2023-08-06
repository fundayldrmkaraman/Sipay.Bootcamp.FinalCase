using Microsoft.EntityFrameworkCore;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.FinalcaseDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.MessageServices
{
    public class MessageService:IMessageService
    {
        private readonly FinalcaseDbContext _context;

        public MessageService(FinalcaseDbContext context)
        {
            _context = context;
        }

        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public void UpdateMessage(Message message)
        {
            _context.Messages.Update(message);
            _context.SaveChanges();
        }

        public void DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
        }

        public Message GetMessageById(int id)
        {
            return _context.Messages.Include(m => m.User).FirstOrDefault(m => m.Id == id);
        }

        public List<Message> GetAllMessages()
        {
            return _context.Messages.Include(m => m.User).ToList();
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
