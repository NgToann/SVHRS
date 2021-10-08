﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using PersonalSV.Models;
using PersonalSV.Entities;
namespace PersonalSV.Controllers
{
    public class AddressController
    {
        //
        public static List<AddressModel> GetAddresses()
        {
            using (var db = new PersonalDataEntities())
            {
                return db.ExecuteStoreQuery<AddressModel>("EXEC spm_SelectAddresses").ToList();
            };
        }
    }
}
