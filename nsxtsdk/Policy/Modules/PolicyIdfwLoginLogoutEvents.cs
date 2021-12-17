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
    public class PolicyIdfwLoginLogoutEvents
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyIdfwLoginLogoutEvents(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PostLoginLogoutEvents(NSXTLoginLogoutEventCollectionType LoginLogoutEventCollection)
        {
            if (LoginLogoutEventCollection == null) { throw new System.ArgumentNullException("LoginLogoutEventCollection cannot be null"); }
            
            StringBuilder PostLoginLogoutEventsServiceURL = new StringBuilder("/system/input/login-logout-events");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(LoginLogoutEventCollection, defaultSerializationSettings));
            request.Resource = PostLoginLogoutEventsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PostLoginLogoutEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}