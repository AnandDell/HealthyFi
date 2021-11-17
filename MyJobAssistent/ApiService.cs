using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    public class ApiService
    {
        List<AppHealthActionConfig> _appHealthConfigs = new List<AppHealthActionConfig>
            {
                new AppHealthActionConfig{ EndpointName= "FirstApi", EndPoint = "https://papi.liveoptics-dev.com/v2/api/health", ApiType="Web API" },
                new AppHealthActionConfig{ EndpointName= "SecondApi", EndPoint = "http://dellrestapi-env.eba-enmpcutb.us-east-2.elasticbeanstalk.com/health", ApiType="Web API" }
            };
        public ApiService()
        {
            //deserialize
            try
            {
                string dir = @"c:\temp";
                string serializationFile = Path.Combine(dir, "AppHealthActionConfig.bin");
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    List<AppHealthActionConfig> appHealthActionConfigs = (List<AppHealthActionConfig>)bformatter.Deserialize(stream);
                    _appHealthConfigs = appHealthActionConfigs;
                }
            }
            catch { }
        }        

        public async Task<List<AppHealthActionConfig>> GetHealthStatusList()
        {
            List<AppHealthActionConfig> appHealthConfigs = new List<AppHealthActionConfig>();

            foreach (AppHealthActionConfig appHealthConfig in _appHealthConfigs)
            {
                AppHealthStatus appHealthStatus = await GetApiHealth(appHealthConfig);

                if (appHealthStatus.Status?.ToLower() == AppHealthStatus.Healthy.ToLower())
                    appHealthConfig.BackColor = Color.Green;

                appHealthConfigs.Add(appHealthConfig);
            }

            return appHealthConfigs;
        }

        public async Task<AppHealthActionConfig> GetAppHealthActionConfig( string endPoint)
        {
            return _appHealthConfigs.FirstOrDefault(x=>x.EndPoint==endPoint);
        }

        public async Task<List<AppHealthActionConfig>> GetAppHealthActionConfigList()
        {
            return _appHealthConfigs;
        }

        public async Task<AppHealthStatus> GetApiHealth(AppHealthActionConfig appHealthConfig)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(appHealthConfig.EndPoint);

                var content = await response.Content.ReadAsStringAsync();
                var appHealthStatus = JsonConvert.DeserializeObject<AppHealthStatus>(content);
                return appHealthStatus;
            }
        }

        public async Task<List<AppHealthActionConfig>> SaveHealthConfigs(List<AppHealthActionConfig> appHealthConfigs)
        {
            _appHealthConfigs = appHealthConfigs;
            string dir = @"c:\temp";
            string serializationFile = Path.Combine(dir, "AppHealthActionConfig.bin");

            //serialize
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, appHealthConfigs);
            }
            return appHealthConfigs;
        }

        public async Task<List<AppHealthActionConfig>> UpdateHealthConfig(AppHealthActionConfig appHealthConfig)
        {
            var appHealthConfigObj = _appHealthConfigs.FirstOrDefault(x=>x.EndPoint== appHealthConfig.EndPoint);
            if (appHealthConfigObj == null)
            {
                _appHealthConfigs.Add(appHealthConfig);
                return _appHealthConfigs;
            }

            for(int counter=0; counter<_appHealthConfigs.Count; counter++)
            {
                var appConfig = _appHealthConfigs[counter];
                if (appConfig.EndPoint== appHealthConfig.EndPoint)
                {
                    _appHealthConfigs[counter] = appHealthConfig;
                }
            }
            return _appHealthConfigs;
        }
    }
}
