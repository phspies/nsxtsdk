// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class NsxIntelligenceHostConfiguration
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NsxIntelligenceHostConfiguration(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIntelligenceHostConfigurationInfoType ResetPaceHostConfigurationReset()
        {
            NSXTIntelligenceHostConfigurationInfoType returnValue = default(NSXTIntelligenceHostConfigurationInfoType);
            StringBuilder ResetPaceHostConfigurationResetServiceURL = new StringBuilder("/intelligence/host-config?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ResetPaceHostConfigurationResetServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceHostConfigurationInfoType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIntelligenceHostConfigurationInfoType PatchPaceHostConfiguration(NSXTIntelligenceHostConfigurationInfoType IntelligenceHostConfigurationInfo)
        {
            if (IntelligenceHostConfigurationInfo == null) { throw new System.ArgumentNullException("IntelligenceHostConfigurationInfo cannot be null"); }
            NSXTIntelligenceHostConfigurationInfoType returnValue = default(NSXTIntelligenceHostConfigurationInfoType);
            StringBuilder PatchPaceHostConfigurationServiceURL = new StringBuilder("/intelligence/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IntelligenceHostConfigurationInfo, defaultSerializationSettings));
            request.Resource = PatchPaceHostConfigurationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceHostConfigurationInfoType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIntelligenceHostConfigurationInfoType GetPaceHostConfiguration()
        {
            NSXTIntelligenceHostConfigurationInfoType returnValue = default(NSXTIntelligenceHostConfigurationInfoType);
            StringBuilder GetPaceHostConfigurationServiceURL = new StringBuilder("/intelligence/host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetPaceHostConfigurationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIntelligenceHostConfigurationInfoType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
