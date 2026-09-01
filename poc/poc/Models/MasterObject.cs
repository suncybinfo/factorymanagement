namespace FactoryManagementSystem.Models
{
    public class MasterObject
    {
    }
    public class objcountry
    {
        public int id { get; set; }
        public string? countryname { get; set; }
        public string? countrycode { get; set; }
        public string? isdcode { get; set; }
    }
    public class lstcountry
    {
        public int id { get; set; }
        public string? countryname { get; set; }
        public string? countrycode { get; set; }
        public string? isdcode { get; set; }
        public string? status { get; set; }
        public string? createdby { get; set; }
    }
    public class objstate
    {
        public int id { get; set; }
        public int countryid { get; set; }
        public string? statename { get; set; }
        public string? statecode { get; set; }
        public string? stategstcode { get; set; }
    }
    public class lststate
    {
        public int id { get; set; }
        public string? countryname { get; set; }
        public int countryid { get; set; }
        public string? statename { get; set; }
        public string? statecode { get; set; }
        public string? stategstcode { get; set; }
        public string? status { get; set; }
        public string? createdby { get; set; }
    }
    public class objdistrict
    {
        public int id { get; set; }
        public int countryid { get; set; }
        public int stateid { get; set; }
        public string? districtname { get; set; }
        public string? districtcode { get; set; }
    }
    public class lstdistrict
    {
        public int id { get; set; }
        public int countryid { get; set; }
        public string? countryname { get; set; }
        public int stateid { get; set; }
        public string? statename { get; set; }
        public string? districtname { get; set; }
        public string? districtcode { get; set; }
        public string? status { get; set; }
        public string? createdby { get; set; }
    }
    public class objdepartment
    {
        public int id { get; set; }
        public string? departmentname { get; set; }
        public string? departmentcode { get; set; }
    }
    public class lstdepartment
    {
        public int id { get; set; }
        public string? departmentname { get; set; }
        public string? departmentcode { get; set; }
        public string? status { get; set; }
        public string? createdby { get; set; }
    }
    public class objcompany
    {
        public int id { get; set; }
        public string? companyname { get; set; }
        public string? companyshortname { get; set; }
        public int countryid { get; set; }
        public int stateid { get; set; }
        public int districtid { get; set; }
        public string? address { get; set; }
        public string? spocname { get; set; }
        public string? spocdesignation { get; set; }
        public string? spocmobileno { get; set; }
        public string? spocemailid { get; set; }
        public string? gstno { get; set; }
        public string? panno { get; set; }
    }
    public class companylst
    {
        public int id { get; set; }
        public string? companyname { get; set; }
        public string? companyshortname { get; set; }
        public int countryid { get; set; }
        public string? countryname { get; set; }
        public int stateid { get; set; }
        public string? statename { get; set; }
        public int districtid { get; set; }
        public string? districtname { get; set; }
        public string? address { get; set; }
        public string? spocname { get; set; }
        public string? spocdesignation { get; set; }
        public string? spocmobileno { get; set; }
        public string? spocemailid { get; set; }
        public string? gstno { get; set; }
        public string? panno { get; set; }
        public string? isactive { get; set; }
        public string? createdby { get; set; }
        public string? createdon { get; set; }
    }
    public class objplant
    {
        public int id { get; set; }
        public int companyid { get; set; }
        public string? plantname { get; set; }
        public string? plantcode { get; set; }
        public string? plantmanagername { get; set; }
        public string? plantmanagermobile { get; set; }
        public string? plantmanageremail { get; set; }
        public int countryid { get; set; }
        public int stateid { get; set; }
        public int districtid { get; set; }
        public string? plantaddress { get; set; }
        public int createdby { get; set; }
    }
    public class plantlst
    {
        public int id { get; set; }
        public int companyid { get; set; }
        public string? plantname { get; set; }
        public string? plantcode { get; set; }
        public string? plantmanagername { get; set; }
        public string? plantmanagermobile { get; set; }
        public string? plantmanageremail { get; set; }
        public int countryid { get; set; }
        public string? countryname { get; set; }
        public int stateid { get; set; }
        public string? statename { get; set; }
        public int districtid { get; set; }
        public string? districtname { get; set; }
        public string? plantaddress { get; set; }
        public string? isactive { get; set; }
        public string? createdby { get; set; }
        public string? createdon { get; set; }
    }
    public class objwarehouse
    {
        public int id { get; set; }
        public int companyid { get; set; }
        public string? warehousename { get; set; }
        public string? warehousecode { get; set; }
        public string? managername { get; set; }
        public string? mobile { get; set; }
        public string? email { get; set; }
        public int countryid { get; set; }
        public int stateid { get; set; }
        public int districtid { get; set; }
        public string? warehouseaddress { get; set; }
        public int createdby { get; set; }
    }
    public class warehouselst
    {
        public int id { get; set; }
        public int companyid { get; set; }
        public string? warehousename { get; set; }
        public string? warehousecode { get; set; }
        public string? managername { get; set; }
        public string? mobile { get; set; }
        public string? email { get; set; }
        public int countryid { get; set; }
        public string? countryname { get; set; }
        public int stateid { get; set; }
        public string? statename { get; set; }
        public int districtid { get; set; }
        public string? districtname { get; set; }
        public string? warehouseaddress { get; set; }
        public string? isactive { get; set; }
        public string? createdby { get; set; }
        public string? createdon { get; set; }
    }
}
