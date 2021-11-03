using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalSV.Models
{
    public class PrivateDefineModel
    {
        public int PrivateDefineId { get; set; }
        public int NoOfValueDate { get; set; }
        public DateTime StartDateScanWorkerCheckIn { get; set; }
        public int TestRandomRatio { get; set; }
        public string AfternoonStone { get; set; }
        public double RemindTestDate { get; set; }
        public double WaitingMinutes { get; set; }
        public string Factory { get; set; }
        public double AlarmMinutes { get; set; }
        public string Results { get; set; }
        public double F1Round { get; set; }
        public double F1Schedule { get; set; }
    }
}
