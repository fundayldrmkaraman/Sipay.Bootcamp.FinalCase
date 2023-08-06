using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.MessageServices
{
    public interface IMessageService
    {
        void AddMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(int id);
        Message GetMessageById(int id);
        List<Message> GetAllMessages();
        void SendMessage(Message message);
    }
}
