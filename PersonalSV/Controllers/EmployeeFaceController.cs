using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using PersonalSV.Entities;
using PersonalSV.Models;
using PersonalSV.ViewModels;

namespace PersonalSV.Controllers
{
    public class EmployeeFaceController
    {
        public static EmployeeFaceModel GetImageByID(string empoyeeId)
        {
            var @EmployeeID = new SqlParameter("@EmployeeID", empoyeeId);
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<EmployeeFaceModel>("EXEC spm_SelectEmployeeFaceByID @EmployeeID", @EmployeeID).FirstOrDefault();
            };
        }
    }
}
