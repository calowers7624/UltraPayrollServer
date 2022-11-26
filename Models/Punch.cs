using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltraPayrollServer.Models
{
    public class Punch
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public DateTime PunchTime { get; set; }
        //true if is a punch-in, false if punch-out
        public bool InOut { get; set; }
    }
}
