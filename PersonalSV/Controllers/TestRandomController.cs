using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using PersonalSV.Entities;
using PersonalSV.Models;
using PersonalSV.ViewModels;

namespace PersonalSV.Controllers
{
    public class TestRandomController
    {
        //
        public static List<TestRandomModel> GetAll()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<TestRandomModel>("EXEC spm_SelectTestRandom").ToList();
            };
        }

        public static bool Insert(TestRandomModel model)
        {
            var @Id = new SqlParameter("@Id", model.Id);
            var @EmployeeCode = new SqlParameter("@EmployeeCode", model.EmployeeCode);
            var @TestDate = new SqlParameter("@TestDate", model.TestDate);
            var @Term = new SqlParameter("@Term", model.Term);
            var @Round = new SqlParameter("@Round", model.Round);
            var @Result = new SqlParameter("@Result", model.Result);
            var @PersonConfirm = new SqlParameter("@PersonConfirm", model.PersonConfirm);
            var @Remark = new SqlParameter("@Remark", model.Remark);
            var @TimeIn = new SqlParameter("@TimeIn", model.TimeIn);
            var @TimeOut = new SqlParameter("@TimeOut", model.TimeOut);
            var @Status = new SqlParameter("@Status", model.Status);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_InsertTestRandom @Id, @EmployeeCode, @TestDate, @Term, @Round, @Result, @PersonConfirm, @Remark, @TimeIn, @TimeOut, @Status",
                                                                      @Id, @EmployeeCode, @TestDate, @Term, @Round, @Result, @PersonConfirm, @Remark, @TimeIn, @TimeOut, @Status) >= 1)
                    return true;
                return false;
            }
        }
    }
}
