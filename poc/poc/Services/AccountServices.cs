using Dapper;
using Microsoft.IdentityModel.Tokens;
using poc.Interface;
using poc.Models;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace poc.Services
{
    public class AccountServices: IAccount
    {
        private readonly DapperContext _context;
        private readonly IConfiguration _config;
        public AccountServices(DapperContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        public POCcls Registration(dtoregistration mdl)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_registration",
                    new
                    {
                        name = mdl.fullname,
                        mobilename = mdl.mobileno,
                        username = mdl.emailid,
                        userpassword = mdl.password
                    },
                    transaction: tran,
                    commandType: CommandType.StoredProcedure
                );
                tran.Commit();
                return dbresponse!;
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
        }
        public POCcls login(dtologin mdl)
        {
            using var conn = _context.CreateConnection();
            jwttokendetails jwttokendetails = new jwttokendetails();
            conn.Open();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_login",
                    new
                    {
                        username = mdl.emailid,
                        passwordhash = mdl.password
                    },
                    commandType: CommandType.StoredProcedure
                );
                if (dbresponse.responseId == 200)
                {
                    var userdetails = conn.QueryFirstOrDefault<dtoregistration>("sp_getuserdetails",
                    new
                    {
                        userid = dbresponse.lastid
                    },commandType: CommandType.StoredProcedure);
                    var token = GenerateToken(userdetails.id, mdl.emailid,userdetails.fullname);
                    jwttokendetails.token = token;
                    dbresponse.lastid = 00000;
                    dbresponse.data=jwttokendetails;
                }
                
                return dbresponse;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string GenerateToken(int userId, string email, string name)
        {
            var claims = new[]
            {
                new Claim("userid", userId.ToString()),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Name, name),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_config["Jwt:DurationInMinutes"])),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
