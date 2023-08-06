using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.JWT.JWT_Settings_Services;
using System.Web.Providers.Entities;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtServices _jwtService;

        public AuthController(JwtServices jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            // Kullanıcı varsa ve yöneticiyse isAdmin true olacak, değilse false olacak
            var isAdmin = false;

            // Kullanıcı varsa, JWT oluşturun
            var user = new System.Web.Providers.Entities.User
            {
                UserName = "admin" // Kullanıcı adı                                   
            };

            var token = _jwtService.GenerateJwtToken(user, isAdmin);

            return Ok(new { Token = token });
        }
    }
}
