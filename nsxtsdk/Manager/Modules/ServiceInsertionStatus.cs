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
    public class ServiceInsertionStatus
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ServiceInsertionStatus(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTServiceInsertionStatusListResultType ListServiceInsertionStatus()
        {
            NSXTServiceInsertionStatusListResultType returnValue = default(NSXTServiceInsertionStatusListResultType);
            StringBuilder ListServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListServiceInsertionStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionStatusListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionStatusType UpdateServiceInsertionStatus(string ContextType, NSXTServiceInsertionStatusType ServiceInsertionStatus)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (ServiceInsertionStatus == null) { throw new System.ArgumentNullException("ServiceInsertionStatus cannot be null"); }
            NSXTServiceInsertionStatusType returnValue = default(NSXTServiceInsertionStatusType);
            StringBuilder UpdateServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateServiceInsertionStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionStatus, defaultSerializationSettings));
            request.Resource = UpdateServiceInsertionStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionStatusType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionStatusType GetServiceInsertionStatus(string ContextType)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            NSXTServiceInsertionStatusType returnValue = default(NSXTServiceInsertionStatusType);
            StringBuilder GetServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetServiceInsertionStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionStatusType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
