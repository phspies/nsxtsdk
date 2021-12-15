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
    public class AuthenticationPolicyModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public AuthenticationPolicyModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTAuthenticationPolicyPropertiesType UpdateAuthenticationPolicyProperties(NSXTAuthenticationPolicyPropertiesType AuthenticationPolicyProperties)
        {
            if (AuthenticationPolicyProperties == null) { throw new System.ArgumentNullException("AuthenticationPolicyProperties cannot be null"); }
            NSXTAuthenticationPolicyPropertiesType returnValue = default(NSXTAuthenticationPolicyPropertiesType);
            StringBuilder UpdateAuthenticationPolicyPropertiesServiceURL = new StringBuilder("/node/aaa/auth-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(AuthenticationPolicyProperties, defaultSerializationSettings));
            request.Resource = UpdateAuthenticationPolicyPropertiesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTAuthenticationPolicyPropertiesType>(response.Content, defaultSerializationSettings);
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
        public NSXTAuthenticationPolicyPropertiesType ReadAuthenticationPolicyProperties()
        {
            NSXTAuthenticationPolicyPropertiesType returnValue = default(NSXTAuthenticationPolicyPropertiesType);
            StringBuilder ReadAuthenticationPolicyPropertiesServiceURL = new StringBuilder("/node/aaa/auth-policy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadAuthenticationPolicyPropertiesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTAuthenticationPolicyPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
