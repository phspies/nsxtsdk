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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class RegistrationTokenEndPoint
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public RegistrationTokenEndPoint(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteRegistrationToken(string Token)
        {
            if (Token == null) { throw new System.ArgumentNullException("Token cannot be null"); }
            
            StringBuilder DeleteRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token/{token}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRegistrationTokenServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRegistrationTokenType GetRegistrationToken(string Token)
        {
            if (Token == null) { throw new System.ArgumentNullException("Token cannot be null"); }
            NSXTRegistrationTokenType returnValue = default(NSXTRegistrationTokenType);
            StringBuilder GetRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token/{token}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetRegistrationTokenServiceURL.Replace("{token}", System.Uri.EscapeDataString(Helpers.ConvertToString(Token, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRegistrationTokenServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTRegistrationTokenType>(response.Content, defaultSerializationSettings);
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
        public NSXTRegistrationTokenType CreateRegistrationToken()
        {
            NSXTRegistrationTokenType returnValue = default(NSXTRegistrationTokenType);
            StringBuilder CreateRegistrationTokenServiceURL = new StringBuilder("/aaa/registration-token");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateRegistrationTokenServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTRegistrationTokenType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}