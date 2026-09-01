using Dapper;
using poc.Interface;
using poc.Models;
using System;
using System.Data;
using System.Security.Cryptography;

namespace poc.Services
{
    public class POCServices:IPOCDemo
    {
        private readonly DapperContext _context;
        public POCServices(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<departmentdto> lstdepartment(string valuetype, int? valueId1, string? valueId2)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<departmentdto>("sp_commondropdown", new
            {
                val1 = valuetype,
                val2 = valueId1,
                val3 = valueId2
            }, commandType: System.Data.CommandType.StoredProcedure);
        }
        public IEnumerable<designationdto> lstdesignation(string valuetype, int? valueId1, string? valueId2)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<designationdto>(
                "sp_commondropdown",
                new
                {
                    val1 = valuetype,
                    val2 = valueId1,
                    val3 = valueId2
                },
                commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public IEnumerable<education> lsteducation(string valuetype, int? valueId1, string? valueId2)
        {
            using var conn = _context.CreateConnection();
            return conn.Query<education>(
                "sp_commondropdown",
                new
                {
                    val1 = valuetype,
                    val2 = valueId1,
                    val3 = valueId2
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public IEnumerable<dtoemployee> getEmployee()
        {
            using var conn = _context.CreateConnection();
            return conn.Query<dtoemployee>(
                "sp_getemployee",
                new
                {
                    empId = 0,
                    userId = 0,
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public POCcls getEmployeebyId(int id)
        {
            POCcls res=new POCcls();
            using var conn = _context.CreateConnection();
            conn.Open();
            try
            {
                var dbresponse = conn.QueryFirstOrDefault<dtoemployee>(
                    "sp_getemployee",
                    new
                    {
                        empId = id,
                        userId = 0,
                    },
                    commandType: CommandType.StoredProcedure
                );
                if (dbresponse.id > 0)
                {
                    var lsteduc = conn.Query<education>("Geteducation",
                        new
                        {
                            empId = dbresponse.id
                        },
                        commandType: CommandType.StoredProcedure
                    ).ToList();
                    dbresponse.lsteducation = lsteduc;
                }
                res.data = dbresponse;
                return res!;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public POCcls DeleteRecord(int id)
        {
            POCcls res = new POCcls();
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_deleterecord",
                    new
                    {
                        pid = id
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
        public POCcls Registration(clsemployee mdl, int userId)
        {
            using var conn = _context.CreateConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                var dbresponse = conn.QueryFirstOrDefault<POCcls>(
                    "sp_AddUpdateEmployee",
                    new
                    {
                        pId = mdl.id,
                        pemployeename = mdl.employeename,
                        pMobileno = mdl.mobile,
                        pdob = mdl.dob,
                        pGender = mdl.gender,
                        pemailId = mdl.emailid,
                        pdepartmentid = mdl.departmentid,
                        pdesignationid = mdl.designationid,
                        pcreatedby= userId
                    },
                    transaction: tran,
                    commandType: CommandType.StoredProcedure
                );
                tran.Commit();
                if (dbresponse.responseId == 200)
                {
                    conn.Execute(
                    "sp_deleteEmployeeEducation",
                    new
                    {
                        employeeId = dbresponse.lastid
                    },
                        commandType: CommandType.StoredProcedure
                    );
                    if (mdl.lsteducation.Count() > 0)
                    {
                        foreach(var item in mdl.lsteducation)
                        {
                            conn.Execute("sp_Addeducation",
                            new
                            {
                                employeeId = dbresponse.lastid,
                                EducationId = item.educationid,
                            },
                               commandType: CommandType.StoredProcedure
                            );
                        }
                    }
                }
                return dbresponse!;
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
        }
    }
}
