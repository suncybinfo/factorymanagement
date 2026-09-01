namespace poc.Models
{
    public class POCcls
    {
        public int responseId { get; set; }
        public int lastid { get; set; }
        public string? responsemessage { get; set; }
        public object data { get; set; }
    }
    public class dtoregistration
    {
        public int id { get; set; }
        public string? username { get; set; }
        public string? fullname { get; set; }
        public string? mobileno { get; set; }
        public string? emailid { get; set; }
        public string? password { get; set; }
    }
    public class jwttokendetails
    {
        public string token { get; set; }
    }
    public class dtologin
    {
        public string? emailid { get; set; }
        public string? password { get; set; }
    }
    public class clsemployee
    {
        public int id { get; set; }
        public string employeename { get; set; }
        public string mobile { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string emailid { get; set; }
        public int departmentid { get; set; }
        public int designationid { get; set; }
        public List<education> lsteducation { get; set; }
    }
    public class dtoemployee
    {
        public int id { get; set; }
        public string employeename { get; set; }
        public string mobile { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string emailid { get; set; }
        public int departmentid { get; set; }
        public string departmentname { get; set; }
        public int designationid { get; set; }
        public string designationname { get; set; }
        public string createdby { get; set; }
        public string createdon { get; set; }
        public string streducation { get; set; }
        public List<education> lsteducation { get; set; }
    }
    public class education
    {
        public int educationid { get; set; }
        public string educationname { get; set; }
    }
    public class departmentdto
    {
        public int departmentid { get; set; }
        public string departmentname { get; set; }
    }
    public class designationdto
    {
        public int designationid { get; set; }
        public string designationname { get; set; }
    }
}
