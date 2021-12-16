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
    public class AggSvcDnsForwarder
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public AggSvcDnsForwarder(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsForwarderStatisticsType GetDnsForwarderStatistics(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            NSXTDnsForwarderStatisticsType returnValue = default(NSXTDnsForwarderStatisticsType);
            StringBuilder GetDnsForwarderStatisticsServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetDnsForwarderStatisticsServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsForwarderStatisticsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetDnsForwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsForwarderStatisticsType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsForwarderStatisticsType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsForwarderStatusType GetDnsForwarderStatus(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            NSXTDnsForwarderStatusType returnValue = default(NSXTDnsForwarderStatusType);
            StringBuilder GetDnsForwarderStatusServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetDnsForwarderStatusServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsForwarderStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetDnsForwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsForwarderStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsForwarderStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
