using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using PersonalSV.Entities;
using PersonalSV.Models;

namespace PersonalSV.Controllers
{
    public class CommonController
    {
        //
        public static PrivateDefineModel GetDefineProps()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<PrivateDefineModel>("EXEC spm_SelectPrivateDefine").FirstOrDefault();
            };
        }
    }
}
