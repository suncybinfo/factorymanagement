namespace FactoryManagementSystem.Models
{
    public class EmployeeObject
    {
    }
    public class Employee
    {
        public int id { get; set; }
        public string employeecode { get; set; }
        public string? photopath { get; set; }

        public string fullname { get; set; }
        public string? fatherhusbandname { get; set; }

        public DateTime dateofbirth { get; set; }
        public string gender { get; set; }
        public string? maritalstatus { get; set; }
        public string? bloodgroup { get; set; }

        public string mobilenumber { get; set; }
        public string? alternatemobilenumber { get; set; }
        public string? email { get; set; }

        public string? aadhaarnumber { get; set; }
        public string? pannumber { get; set; }

        public DateTime joiningdate { get; set; }
        public string employeetype { get; set; }

        public int? departmentid { get; set; }
        public int? designationid { get; set; }
        public int? gradeid { get; set; }
        public int? factoryid { get; set; }
        public int? shiftid { get; set; }
        public int? reportingmanagerid { get; set; }

        public string employmentstatus { get; set; }

        public int? previousexperienceyears { get; set; }
        public string? previouscompany { get; set; }
        public decimal? totalexperienceyears { get; set; }

        public string? workercategory { get; set; }
        public string? skilltrade { get; set; }
        public int? productionunitid { get; set; }
        public string? machineworkstation { get; set; }
        public string? contractorname { get; set; }
        public string? labourcardnumber { get; set; }
        public string? gatepassnumber { get; set; }
        public string? attendancecardnumber { get; set; }

        public int? shiftpatternid { get; set; }
        public string? weeklyoff { get; set; }

        public bool accommodationrequired { get; set; }
        public bool transportrequired { get; set; }

        public string? uniformsize { get; set; }
        public string? safetyshoesize { get; set; }
        public bool helmetissued { get; set; }

        public bool isactive { get; set; }
        public DateTime createddate { get; set; }
        public int? createdby { get; set; }
        public DateTime? modifieddate { get; set; }
        public int? modifiedby { get; set; }
    }
    public class EmployeeAddress
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string? currentaddress { get; set; }
        public int? currentstateid { get; set; }
        public int? currentdistrictid { get; set; }
        public int? currentcityid { get; set; }
        public string? currentpincode { get; set; }

        public bool sameascurrentaddress { get; set; }

        public string? permanentaddress { get; set; }
        public int? permanentstateid { get; set; }
        public int? permanentdistrictid { get; set; }
        public int? permanentcityid { get; set; }
        public string? permanentpincode { get; set; }
    }
    public class EmployeeBank
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string? bankname { get; set; }
        public string? accountnumber { get; set; }
        public string? ifsccode { get; set; }
        public string? branchname { get; set; }
        public string? accountholdername { get; set; }
        public string? accounttype { get; set; }

        public string? bankproofpath { get; set; }
    }
    public class EmployeeStatutory
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string? uannumber { get; set; }
        public string? pfmemberid { get; set; }
        public string? esinumber { get; set; }

        public string? pannumber { get; set; }
        public string? aadhaarnumber { get; set; }

        public bool pfapplicable { get; set; }
        public bool esiapplicable { get; set; }
        public bool ptapplicable { get; set; }
        public bool lwfapplicable { get; set; }
        public bool gratuityapplicable { get; set; }
        public bool tdsapplicable { get; set; }
    }
    public class EmployeeSalary
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string salarytype { get; set; }

        public decimal basicsalary { get; set; }
        public decimal hra { get; set; }
        public decimal conveyanceallowance { get; set; }
        public decimal medicalallowance { get; set; }
        public decimal otherallowance { get; set; }
        public decimal grosssalary { get; set; }

        public DateTime effectivefrom { get; set; }
        public DateTime? effectiveto { get; set; }
    }
    public class EmployeeNominee
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string nomineename { get; set; }
        public string relationship { get; set; }
        public DateTime? dateofbirth { get; set; }

        public decimal sharepercentage { get; set; }

        public string? mobilenumber { get; set; }
        public string? address { get; set; }
        public string? guardianname { get; set; }
    }
    public class EmployeeEmergencyContact
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public string contactpersonname { get; set; }
        public string relationship { get; set; }
        public string mobilenumber { get; set; }
        public string? alternatenumber { get; set; }
        public string? address { get; set; }
    }
    public class EmployeeDocument
    {
        public int id { get; set; }
        public int employeeid { get; set; }

        public int documenttypeid { get; set; }
        public string documentname { get; set; }
        public string? documentnumber { get; set; }

        public string filepath { get; set; }
        public string? filename { get; set; }

        public DateTime uploadeddate { get; set; }

        public bool isverified { get; set; }
        public int? verifiedby { get; set; }
        public DateTime? verifieddate { get; set; }
    }
}
