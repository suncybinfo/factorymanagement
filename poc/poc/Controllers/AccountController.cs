using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using poc.Interface;
using poc.Models;

namespace poc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _account;
        public AccountController(IAccount account)
        {
            _account = account;
        }
        [HttpPost("Registration")]
        public IActionResult Registration([FromBody] dtoregistration dto)
        {
            POCcls response = new POCcls();
            response = _account.Registration(dto);
            return Ok(response);
        }
        [HttpPost("login")]
        public IActionResult login([FromBody] dtologin dto)
        {
            POCcls response = new POCcls();
            response = _account.login(dto);
            return Ok(response);
        }

    }
}
