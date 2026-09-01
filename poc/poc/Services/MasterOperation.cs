using Dapper;
using FactoryManagementSystem.Interface;
using FactoryManagementSystem.Models;
using poc.Models;
using poc.Services;
using System.Data;

namespace FactoryManagementSystem.Services
{
    public class MasterOperation:IMaster
    {
        private readonly DapperContext _context;
        public MasterOperation(DapperContext context)
        {
            _context = context;
        }
        public POCcls AddUpdateCountry(objcountry mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_md_country",
                    new
                    {
                        pid = mdl.id,
                        pcountrycode = mdl.countryname,
                        pcountryname = mdl.countrycode,
                        pcountryisd = mdl.isdcode,
                        pcreatedby = userId
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
        public IEnumerable<lstcountry> lstcountry(int countryid, int userid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<lstcountry>(
                "get_country",
                new
                {
                    pcountryid = countryid,
                    puserid = userid
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }

        public POCcls AddUpdatestate(objstate mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_md_state",
                    new
                    {
                        pid = mdl.id,
                        pcountryid = mdl.countryid,
                        pstatename = mdl.statename,
                        pstatecode = mdl.statecode,
                        pstategst = mdl.stategstcode,
                        pcreatedby = userId
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
        public IEnumerable<lststate> lststate(int countryid,int stateid, int userid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<lststate>(
                "get_state",
                new
                {
                    pcountryid = countryid,
                    pstateid = stateid,
                    puserid = userid
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls AddUpdateDistrict(objdistrict mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_md_district",
                    new
                    {
                        pid = mdl.id,
                        pstateid = mdl.stateid,
                        pdistrictname = mdl.districtname,
                        pdistrictcode = mdl.districtcode,
                        pcreatedby = userId
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
        public IEnumerable<lstdistrict> lstdistrict(int stateid, int districtid, int userid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<lstdistrict>(
                "sp_getdistrict",
                new
                {
                    pstateId = stateid,
                    pdistrictid = districtid,
                    puserid = userid
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls AddUpdateDepartment(objdepartment mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_md_department",
                    new
                    {
                        pid = mdl.id,
                        pdepartmentname = mdl.departmentname,
                        pdepartmentcode = mdl.departmentcode,
                        pcreatedby = userId
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
        public IEnumerable<lstdepartment> lstdepartment(int departmentid, int userid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<lstdepartment>(
                "sp_getdepartment",
                new
                {
                    pdepartmentid = departmentid,
                    puserid = userid
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls AddUpdateCompany(objcompany mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_md_company",
                    new
                    {
                        pid = mdl.id,
                        pcompanyname = mdl.companyname,
                        pcompanyshortname = mdl.companyshortname,
                        pcountryid = mdl.countryid,
                        pstateid = mdl.stateid,
                        pdistrictid = mdl.districtid,
                        paddress = mdl.address,
                        pspocname = mdl.spocname,
                        pspocdesignation = mdl.spocdesignation,
                        pspocmobileno = mdl.spocmobileno,
                        pspocemailid = mdl.spocemailid,
                        pgstno = mdl.gstno,
                        ppanno = mdl.panno,
                        pcreatedby = userId
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
        public IEnumerable<companylst> lstcompany(int userid, int companyid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<companylst>(
                "sp_getcompany",
                new
                {
                    pcompanyid = companyid,
                    puserid = userid
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls AddUpdatePlant(objplant mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_insertupdateplant",
                    new
                    {
                        pid = mdl.id,
                        pcompanyid = mdl.companyid,
                        pplantname = mdl.plantname,
                        pplantcode = mdl.plantcode,
                        pplantmanagername = mdl.plantmanagername,
                        pplantmanagermobile = mdl.plantmanagermobile,
                        pplantmanageremail = mdl.plantmanageremail,
                        pcountryid = mdl.countryid,
                        pstateid = mdl.stateid,
                        pdistrictid = mdl.districtid,
                        pplantaddress = mdl.plantaddress,
                        pcreatedby = userId
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
        public IEnumerable<plantlst> lstplant(int userid, int companyid,int plantid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<plantlst>(
                "sp_getplant",
                new
                {
                    pcompanyid = companyid,
                    puserid = userid,
                    pplantid = plantid,
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls AddUpdatewarehouse(objwarehouse mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_insertupdatewarehouse",
                    new
                    {
                        pid = mdl.id,
                        pcompanyid = mdl.companyid,
                        pwarehousename = mdl.warehousename,
                        pwarehousecode = mdl.warehousecode,
                        pmanagername = mdl.managername,
                        pmobile = mdl.mobile,
                        pemail = mdl.email,
                        pcountryid = mdl.countryid,
                        pstateid = mdl.stateid,
                        pdistrictid = mdl.districtid,
                        pwarehouseaddress = mdl.warehouseaddress,
                        pcreatedby = userId
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
        public IEnumerable<warehouselst> lstwarehouse(int userid, int companyid, int warehouseid)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<warehouselst>(
                "sp_getwarehouse",
                new
                {
                    pcompanyid = companyid,
                    puserid = userid,
                    pwarehouseid = warehouseid,
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
    }
}
