using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.GenericRepository;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.UserServices
{
    public class UserService:IUserService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }

        public void UpdateUser(int id, User updatedUser)
        {
            var user = _userRepository.GetById(id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.TcIdentityNumber = updatedUser.TcIdentityNumber;
                user.Email = updatedUser.Email;
                user.Phone = updatedUser.Phone;
                user.CarPlateNumber = updatedUser.CarPlateNumber;

                _userRepository.Update(user);
            }
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public bool PayBill(int billId)
        {
            throw new NotImplementedException();
        }

        public object GetUserBills(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
