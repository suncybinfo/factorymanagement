using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using poc.Interface;
using poc.Models;
using System.Security.Cryptography;
using System.Security.Principal;

namespace poc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class POCDemoController : ControllerBase
    {
        private readonly IPOCDemo _pocdemo;
        public POCDemoController(IPOCDemo pocdemo)
        {
            _pocdemo = pocdemo;
        }
        [HttpGet("lstdepartment/{valuetype}/{valueId1?}/{valueId2?}")]
        public IActionResult lstdepartment(string valuetype, int? valueId1, string? valueId2)
        {
            List<departmentdto> lst = new List<departmentdto>() ;
            lst = _pocdemo.lstdepartment(valuetype, valueId1, valueId2).ToList();
            return Ok(lst);
        }
        [HttpGet("lstdesignation/{valuetype}/{valueId1}/{valueId2?}")]
        public IActionResult lstdesignation(string valuetype, int? valueId1, string? valueId2)
        {
            List<designationdto> lst = new List<designationdto>();
            lst = _pocdemo.lstdesignation(valuetype, valueId1, valueId2).ToList();
            return Ok(lst);
        }
        [HttpGet("lsteducation/{valuetype}/{valueId1?}/{valueId2?}")]
        public IActionResult lsteducation(string valuetype, int? valueId1, string? valueId2)
        {
            List<education> lst = new List<education>();
            lst = _pocdemo.lsteducation(valuetype, valueId1, valueId2).ToList();
            return Ok(lst);
        }
        [HttpGet("getEmployee")]
        public IActionResult getEmployee()
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            List<dtoemployee> lst = new List<dtoemployee>();
            lst = _pocdemo.getEmployee().ToList();
            return Ok(lst);
        }
        [HttpGet("getEmployeebyId/{id}")]
        public IActionResult getEmployeebyId(int id)
        {
            POCcls response = new POCcls();
            response = _pocdemo.getEmployeebyId(id);
            return Ok(response);
        }
        [HttpPost("EmployeeRegistration")]
        public IActionResult EmployeeRegistration([FromBody] clsemployee dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _pocdemo.Registration(dto, userId);
            return Ok(response);
        }
        [HttpGet("DeleteRecord/{id}")]
        public IActionResult DeleteRecord(int id)
        {
            POCcls response = new POCcls();
            response = _pocdemo.DeleteRecord(id);
            return Ok(response);
        }
    }
}
