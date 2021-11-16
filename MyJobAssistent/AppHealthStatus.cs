using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    public class AppHealthStatus
    {
        //{"name":"papi service v2","type":"Api Gateway Health","status":"Healthy","results":[],"totalResponseTime":2.8987}

        public string Name { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public string[] Results { get; set; }

        public string TotalResponseTime { get; set; }
    }
}
