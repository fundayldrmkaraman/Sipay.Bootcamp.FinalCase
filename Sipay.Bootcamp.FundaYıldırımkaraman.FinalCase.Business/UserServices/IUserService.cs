using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.UserServices
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(int id, User updatedUser);
        void DeleteUser(int id);
        void SendMessage(Message message);
        bool PayBill(int billId);
        object GetUserBills(int userId);
    }
}
