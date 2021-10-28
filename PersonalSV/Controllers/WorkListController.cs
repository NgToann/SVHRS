using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PersonalSV.Models;
using PersonalSV.Entities;

namespace PersonalSV.Controllers
{
    public class WorkListController
    {
        public static List<WorkListModel> Get()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkListModel>("EXEC spm_SelectWorkList").ToList();
            };
        }
        //
        public static List<WorkListModel> GetByDate(DateTime date)
        {
            var @TestDate = new SqlParameter("@TestDate", date);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkListModel>("EXEC spm_SelectWorkListByDate @TestDate", @TestDate).ToList();
            };
        }

        public static List<WorkListModel> GetByEmpId(string empId)
        {
            var @EmployeeID = new SqlParameter("@EmployeeID", empId);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<WorkListModel>("EXEC spm_SelectWorkListByEmpId @EmployeeID", @EmployeeID).ToList();
            };
        }

        public static bool UpdateTestStatus(WorkListModel model)
        {
            var @EmployeeID = new SqlParameter("@EmployeeID", model.EmployeeID);
            var @TestDate = new SqlParameter("@TestDate", model.TestDate);
            var @TestStatus= new SqlParameter("@TestStatus", model.TestStatus);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_UpdateWorkListWhenScanOut @EmployeeID, @TestDate, @TestStatus",
                                                                               @EmployeeID, @TestDate, @TestStatus) >= 1)
                    return true;
                return false;
            }
        }

        public static bool Insert(WorkListModel model)
        {
            var @EmployeeID     = new SqlParameter("@EmployeeID", model.EmployeeID);
            var @TestDate       = new SqlParameter("@TestDate", model.TestDate);
            var @TestStatus     = new SqlParameter("@TestStatus", model.TestStatus);            
            var @TestTime       = new SqlParameter("@TestTime", model.TestTime);
            var @WorkTime       = new SqlParameter("@WorkTime", model.WorkTime);
            var @Remarks        = new SqlParameter("@Remarks", model.Remarks);
            
            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_InsertWorkList_1 @EmployeeID, @TestDate, @TestStatus, @TestTime, @WorkTime, @Remarks",
                                                                      @EmployeeID, @TestDate, @TestStatus, @TestTime, @WorkTime, @Remarks) >= 1)
                    return true;
                return false;
            }
        }

        public static bool DeleteWorkListByIdByDate(WorkListModel model)
        {
            var @EmployeeID = new SqlParameter("@EmployeeID", model.EmployeeID);
            var @TestDate   = new SqlParameter("@TestDate", model.TestDate);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;

                if (db.ExecuteStoreCommand("EXEC spm_DeleteWorkListByEmpIdByDate @EmployeeID, @TestDate",
                                                                                 @EmployeeID, @TestDate) >= 1)
                    return true;
                return false;
            }
        }
    }
}
