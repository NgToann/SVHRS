using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PersonalSV.Models;
using PersonalSV.Entities;

namespace PersonalSV.Controllers
{
    public class WorkerCheckInController
    {
        public static List<WorkerCheckInModel> Get()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerCheckInModel>("EXEC spm_SelectWorkerCheckIn").ToList();
            };
        }
        public static List<WorkerCheckInModel> GetByEmpCode(string empCode)
        {
            var @EmployeeCode = new SqlParameter("@EmployeeCode", empCode);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerCheckInModel>("EXEC spm_SelectWorkerCheckInByEmpCode @EmployeeCode", @EmployeeCode).ToList();
            };
        }
        //
        public static List<WorkerCheckInModel> GetByDate(DateTime date)
        {
            var @CheckInDate = new SqlParameter("@CheckInDate", date);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkerCheckInModel>("EXEC spm_SelectWorkerCheckInByDate @CheckInDate", @CheckInDate).ToList();
            };
        }
        public static bool Insert(WorkerCheckInModel model)
        {
            var @Id = new SqlParameter("@Id", model.Id);
            var @EmployeeCode = new SqlParameter("@EmployeeCode", model.EmployeeCode);
            var @CheckInDate = new SqlParameter("@CheckInDate", model.CheckInDate);
            var @RecordTime = new SqlParameter("@RecordTime", model.RecordTime);
            var @CheckType = new SqlParameter("@CheckType", model.CheckType);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_InsertWorkerCheckIn @Id, @EmployeeCode, @CheckInDate, @RecordTime, @CheckType", 
                                                                         @Id, @EmployeeCode, @CheckInDate, @RecordTime, @CheckType) >= 1)
                    return true;
                return false;
            }
        }
        public static bool Delete(string id)
        {
            var @Id = new SqlParameter("@Id", id);
            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_DeleteWorkerCheckIn @Id",
                                                                         @Id) >= 1)
                    return true;
                return false;
            }
        }

        //
    }
}
