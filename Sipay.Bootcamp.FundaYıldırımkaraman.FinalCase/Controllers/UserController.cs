using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.UserServices;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("bills/{userId}")]
        public IActionResult GetUserBills(int userId)
        {
            var userBills = _userService.GetUserBills(userId);
            if (userBills == null)
            {
                return NotFound();
            }

            return Ok(userBills);
        }

        [HttpPost("paybill")]
        public IActionResult PayBill(int billId)
        {
            var success = _userService.PayBill(billId);
            if (!success)
            {
                return NotFound();
            }

            return Ok(new { Message = "Fatura ödeme işlemi başarıyla tamamlandı." });
        }

        [HttpPost("sendmessage")]
        public IActionResult SendMessage(int userId, string content)
        { 
            var message = new Message
            {
                UserId = userId,
                Content = content,
                IsRead = false,
                CreatedAt = DateTime.Now
            };

            _userService.SendMessage(message);

            return Ok(new { Message = "Mesaj başarıyla gönderildi." });
        }
    }
}
