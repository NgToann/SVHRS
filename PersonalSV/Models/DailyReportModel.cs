using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalSV.ViewModels;
using System.ComponentModel;

namespace PersonalSV.Models
{
    public class DailyReportModel : BaseViewModel
    {
        public DateTime DateSearch { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string DepartmentName { get; set; }
        public string TimeIn { get; set; }
        public string TimeInView { get; set; }
        public string TimeOut { get; set; }
        public string TimeOutView { get; set; }
        public string LV1 { get; set; }
        public string LV2 { get; set; }
        public string LV3 { get; set; }
        public string Remarks { get; set; }
        
        private string _Reason;
        public string Reason
        {
            get { return _Reason; }
            set
            {
                _Reason = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Reason"));
            }
        }
    }
}
