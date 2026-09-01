using FactoryManagementSystem.Interface;
using FactoryManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using poc.Interface;
using poc.Models;
using System.Collections.Generic;

namespace FactoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MasterController : ControllerBase
    {
        private readonly IMaster _master;
        public MasterController(IMaster master)
        {
            _master = master;
        }
        [HttpPost("AddCountry")]
        public IActionResult AddCountry([FromBody] objcountry dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdateCountry(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetCountryList/{countryid}")]
        public IActionResult GetCountryList(int countryid)
        {
            List<lstcountry> lst = new List<lstcountry>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            lst = _master.lstcountry(countryid, userId).ToList();
            return Ok(lst);
        }
        [HttpPost("AddState")]
        public IActionResult AddState([FromBody] objstate dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdatestate(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetStateList/{countryid}/{stateid}")]
        public IActionResult GetStateList(int countryid, int stateid)
        {
            List<lststate> lst = new List<lststate>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            lst = _master.lststate(countryid, stateid, userId).ToList();
            return Ok(lst);
        }
        [HttpPost("AddDistrict")]
        public IActionResult AddDistrict([FromBody] objdistrict dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdateDistrict(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetDistrictList/{stateid}/{districtid}")]
        public IActionResult GetDistrictList(int stateid, int districtid)
        {
            List<lstdistrict> lst = new List<lstdistrict>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            lst = _master.lstdistrict(stateid, districtid, userId).ToList();
            return Ok(lst);
        }
        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment([FromBody] objdepartment dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdateDepartment(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetDepartmentList/{departmentid}")]
        public IActionResult GetDepartmentList(int departmentid)
        {
            POCcls response = new POCcls();
            List<lstdepartment> lst = new List<lstdepartment>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            lst = _master.lstdepartment(departmentid, userId).ToList();
            return Ok(lst);
        }
        [HttpPost("AddCompany")]
        public IActionResult AddCompany([FromBody] objcompany dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdateCompany(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetCompanyList/{companyid}")]
        public IActionResult GetCompanyList(int companyid)
        {
            POCcls response = new POCcls();
            List<companylst> lst = new List<companylst>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            lst = _master.lstcompany(userId, companyid).ToList();
            return Ok(lst);
        }
        [HttpPost("AddPlant")]
        public IActionResult AddPlant([FromBody] objplant dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdatePlant(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetPlantList/{plantid}")]
        public IActionResult GetPlantList(int plantid)
        {
            POCcls response = new POCcls();
            List<plantlst> lst = new List<plantlst>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            int companyid = 0;
            lst = _master.lstplant(userId, companyid, plantid).ToList();
            return Ok(lst);
        }
        [HttpPost("Addwarehouse")]
        public IActionResult Addwarehouse([FromBody] objwarehouse dto)
        {
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            POCcls response = new POCcls();
            response = _master.AddUpdatewarehouse(dto, userId);
            return Ok(response);
        }
        [HttpGet("GetWarehouseList/{warehouseid}")]
        public IActionResult GetWarehouseList(int warehouseid)
        {
            POCcls response = new POCcls();
            List<warehouselst> lst = new List<warehouselst>();
            int userId = Convert.ToInt32(User.FindFirst("userid")?.Value);
            int companyid = 0;
            lst = _master.lstwarehouse(userId, companyid, warehouseid).ToList();
            return Ok(lst);
        }
    }
}
