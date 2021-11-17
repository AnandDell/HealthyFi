using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    [Serializable]
    public class AppHealthActionConfig 
    {
        public AppHealthActionConfig()
        {
            BackColor = Color.Red;
        }
        public string EndpointName { get; set; }
        public string EndPoint { get; set; }
        public string ApiType { get; set; }
        public Color BackColor { get; set; }
        public string ActionEndpoint { get; set; }
        public string ActionEndpointType { get; set; }
        public string TriggerToEmailAddress { get; set; } = "hackathondell2021@gmail.com";
        public string TriggerFromEmailAddresses { get; set; } = "Anand_Kumar_tripathi@Dell.com;Prabal_Khajanchi@Dell.com;Ajeya.Kumar@Dell.com;Jitesh_Kumaradesara@Dell.com;Pinkey_Ratnani@Dell.com;Sachin_Koshti@Dell.com";
        public string EmailSubject { get; set; } = "restart the service";
        public string EmailBody { get; set; } = "urgently required to restart service";
        public bool IsTriggeredByEmail { get; set; } = true;
        public bool IsTriggeredByNotification { get; set; }
        public bool IsTriggeredByDateTime { get; set; }
        public DateTime TimeToExecute { get; set; } = DateTime.Now;
        public bool Daily { get; set; } = true;
        public bool Weekly { get; set; } = true;
        public bool Monthly { get; set; } = true;
    }
}
