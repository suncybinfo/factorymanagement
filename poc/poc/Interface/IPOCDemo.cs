using poc.Models;

namespace poc.Interface
{
    public interface IPOCDemo
    {
        public IEnumerable<departmentdto> lstdepartment(string valuetype, int? valueId1, string? valueId2);
        public IEnumerable<designationdto> lstdesignation(string valuetype, int? valueId1, string? valueId2);
        public IEnumerable<education> lsteducation(string valuetype, int? valueId1, string?  valueId2);
        public IEnumerable<dtoemployee> getEmployee();
        public POCcls DeleteRecord(int id);
        public POCcls getEmployeebyId(int id);
        public POCcls Registration(clsemployee mdl, int userId);
    }
}
