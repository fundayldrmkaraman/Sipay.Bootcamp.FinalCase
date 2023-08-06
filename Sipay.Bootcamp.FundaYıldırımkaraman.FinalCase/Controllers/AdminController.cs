using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.ApartmentServices;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.BillServices;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.MessageServices;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Business.UserServices;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;
        private readonly IUserService _userService;
        private readonly IBillService _billService;
        private readonly IMessageService _messageService;

        public AdminController(IApartmentService apartmentService, IUserService userService,
                               IBillService billService, IMessageService messageService)
        {
            _apartmentService = apartmentService;
            _userService = userService;
            _billService = billService;
            _messageService = messageService;
        }

        // Daire bilgilerini eklemek için API
        [HttpPost("apartments")]
        public IActionResult AddApartment(Apartment apartment)
        {
            _apartmentService.AddApartment(apartment);
            return Ok(apartment);
        }

        // Daire bilgilerini güncellemek için API
        [HttpPut("apartments/{id}")]
        public IActionResult UpdateApartment(int id, Apartment updatedApartment)
        {
            _apartmentService.UpdateApartment(id, updatedApartment);
            return Ok(updatedApartment);
        }

        // Daire bilgilerini silmek için API
        [HttpDelete("apartments/{id}")]
        public IActionResult DeleteApartment(int id)
        {
            _apartmentService.DeleteApartment(id);
            return Ok();
        }

        // Kullanıcı bilgilerini eklemek için API
        [HttpPost("users")]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok(user);
        }

        // Kullanıcı bilgilerini güncellemek için API
        [HttpPut("users/{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            _userService.UpdateUser(id, updatedUser);
            return Ok(updatedUser);
        }

        // Kullanıcı bilgilerini silmek için API
        [HttpDelete("users/{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        // Aidat ve fatura bilgilerini eklemek için API
        [HttpPost("bills")]
        public IActionResult AddBill(Bill bill)
        {
            _billService.AddBill(bill);
            return Ok(bill);
        }

        // Aidat ve fatura bilgilerini güncellemek için API
        [HttpPut("bills/{id}")]
        public IActionResult UpdateBill(int id, Bill updatedBill)
        {
            _billService.UpdateBill(id, updatedBill);
            return Ok(updatedBill);
        }

        // Aidat ve fatura bilgilerini silmek için API
        [HttpDelete("bills/{id}")]
        public IActionResult DeleteBill(int id)
        {
            _billService.DeleteBill(id);
            return Ok();
        }

        // Kullanıcılara mesaj göndermek için API
        [HttpPost("messages")]
        public IActionResult SendMessage(Message message)
        {
            _messageService.SendMessage(message);
            return Ok(message);
        }
    }
}
