using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    public class AppHealthActionConfig : AppHealthConfig
    {
        public string ActionEndpoint { get; set; }

        public string ActionEndpointType { get; set; }

        public string TriggerToEmailAddress { get; set; } = "hackathondell2021@gmail.com";

        public string TriggerFromEmailAddresses { get; set; }

        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }

        public bool IsTriggeredByEmail { get; set; }

        public bool IsTriggeredByNotification { get; set; }

        public bool IsTriggeredByDateTime { get; set; }

        public DateTime TimeToExecute { get; set; }

        public bool Daily { get; set; }
        public bool Weekly { get; set; }
        public bool Monthly { get; set; }
    }
}
