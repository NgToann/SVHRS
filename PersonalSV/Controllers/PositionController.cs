using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalSV.Models;
using PersonalSV.Entities;

namespace PersonalSV.Controllers
{
    public class PositionController
    {
        public static List<PositionModel> GetPositionFromSource()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<PositionModel>("EXEC spm_SelectPositionFromSource").ToList();
            };
        }
    }
}
