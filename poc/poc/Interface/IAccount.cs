using poc.Models;

namespace poc.Interface
{
    public interface IAccount
    {
        public POCcls Registration(dtoregistration mdl);
        public POCcls login(dtologin mdl);
    }
}
