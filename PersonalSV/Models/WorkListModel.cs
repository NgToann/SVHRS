using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalSV.Models
{
    public class WorkListModel
    {
        public string EmployeeID { get; set; }
        public int TestStatus { get; set; }
        public DateTime TestDate { get; set; }
        public string WorkTime { get; set; }
        public string TestTime { get; set; }
        public string Remarks { get; set; }

        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
    }
}
