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
    public class IdpsReportingService
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public IdpsReportingService(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServicePropertiesType ReadIdpsReportingService()
        {
            NSXTNodeServicePropertiesType returnValue = default(NSXTNodeServicePropertiesType);
            StringBuilder ReadIdpsReportingServiceServiceURL = new StringBuilder("/node/services/idps-reporting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadIdpsReportingServiceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIdpsReportingServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeServicePropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeServicePropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateIdpsReportingServiceActionRestart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateIdpsReportingServiceActionRestartServiceURL = new StringBuilder("/node/services/idps-reporting?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateIdpsReportingServiceActionRestartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateIdpsReportingServiceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeServiceStatusPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateIdpsReportingServiceActionStart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateIdpsReportingServiceActionStartServiceURL = new StringBuilder("/node/services/idps-reporting?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateIdpsReportingServiceActionStartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateIdpsReportingServiceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeServiceStatusPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType ReadIdpsReportingServiceStatus()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder ReadIdpsReportingServiceStatusServiceURL = new StringBuilder("/node/services/idps-reporting/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadIdpsReportingServiceStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIdpsReportingServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeServiceStatusPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateIdpsReportingServiceActionStop()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateIdpsReportingServiceActionStopServiceURL = new StringBuilder("/node/services/idps-reporting?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateIdpsReportingServiceActionStopServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateIdpsReportingServiceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeServiceStatusPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
