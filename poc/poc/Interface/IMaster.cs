using FactoryManagementSystem.Models;
using poc.Models;

namespace FactoryManagementSystem.Interface
{
    public interface IMaster
    {
        public POCcls AddUpdateCountry(objcountry mdl, int userId);
        public IEnumerable<lstcountry> lstcountry(int countryid, int userid);
        public POCcls AddUpdatestate(objstate mdl, int userId);
        public IEnumerable<lststate> lststate(int countryid, int stateid, int userid);
        public POCcls AddUpdateDistrict(objdistrict mdl, int userId);
        public IEnumerable<lstdistrict> lstdistrict(int stateid, int districtid, int userid);
        public POCcls AddUpdateDepartment(objdepartment mdl, int userId);
        public IEnumerable<lstdepartment> lstdepartment(int departmentid, int userid);
        public POCcls AddUpdateCompany(objcompany mdl, int userId);
        public IEnumerable<companylst> lstcompany(int userid, int companyid);
        public POCcls AddUpdatePlant(objplant mdl, int userId);
        public IEnumerable<plantlst> lstplant(int userid, int companyid, int plantid);
        public POCcls AddUpdatewarehouse(objwarehouse mdl, int userId);
        public IEnumerable<warehouselst> lstwarehouse(int userid, int companyid, int warehouseid);
    }
}
