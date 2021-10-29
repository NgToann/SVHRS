using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using PersonalSV.Entities;
using PersonalSV.Models;

namespace PersonalSV.Controllers
{
    public class WorkerLeaveDetailController
    {
        public static List<WorkerLeaveDetailModel> GetAll()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerLeaveDetailModel>("EXEC spm_SelectWorkerLeaveDetail").ToList();
            };
        }
        public static List<WorkerLeaveDetailModel> GetByEmpId(string empId)
        {
            var @EmployeeId = new SqlParameter("@EmployeeId", empId);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerLeaveDetailModel>("EXEC spm_SelectWorkerLeaveDetailByEmpId @EmployeeId", @EmployeeId).ToList();
            };
        }
        public static List<WorkerLeaveDetailModel> GetFromTo(DateTime dateFrom, DateTime dateTo)
        {
            var @DateFrom= new SqlParameter("@DateFrom", dateFrom);
            var @DateTo= new SqlParameter("@DateTo", dateTo);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerLeaveDetailModel>("EXEC spm_SelectWorkerLeaveDetailFromTo @DateFrom, @DateTo", @DateFrom, @DateTo).ToList();
            };
        }
        //
        public static bool AddRecord(WorkerLeaveDetailModel model)
        {
            var @EmployeeId = new SqlParameter("@EmployeeId", model.EmployeeID);
            var @EmployeeCode = new SqlParameter("@EmployeeCode", model.EmployeeCode);
            var @LeaveDate = new SqlParameter("@LeaveDate", model.LeaveDate);
            var @Reason = new SqlParameter("@Reason", model.Reason);
            var @Remark = new SqlParameter("@Remark", model.Remark);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 120;

                if (db.ExecuteStoreCommand("EXEC spm_InsertWorkerLeaveDetail_1 @EmployeeId, @EmployeeCode, @LeaveDate, @Reason, @Remark",
                                                                               @EmployeeId, @EmployeeCode, @LeaveDate, @Reason, @Remark) >= 1)
                    return true;
                else
                    return false;

            };
        }

        //
        public static bool Delete(WorkerLeaveDetailModel model)
        {
            var @EmployeeId = new SqlParameter("@EmployeeId", model.EmployeeID);
            var @LeaveDate = new SqlParameter("@LeaveDate", model.LeaveDate);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 120;
                if (db.ExecuteStoreCommand("EXEC spm_DeleteWorkerLeaveDetailByIdByDate @EmployeeId, @LeaveDate",
                                                                                       @EmployeeId, @LeaveDate) >= 1)
                    return true;
                else return false;
            }
        }
    }
}
