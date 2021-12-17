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
    public class NodeNSXMessagingManagerService
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeNSXMessagingManagerService(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType ReadNsxmessagingManagerServiceStatus()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder ReadNsxmessagingManagerServiceStatusServiceURL = new StringBuilder("/node/services/messaging-manager/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadNsxmessagingManagerServiceStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadNsxmessagingManagerServiceStatusServiceURL.ToString() + " did not complete successfull";
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
        public NSXTNodeServiceStatusPropertiesType CreateNsxmessagingManagerServiceActionStart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateNsxmessagingManagerServiceActionStartServiceURL = new StringBuilder("/node/services/messaging-manager?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateNsxmessagingManagerServiceActionStartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateNsxmessagingManagerServiceActionStartServiceURL.ToString() + " did not complete successfull";
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
        public NSXTNodeServiceStatusPropertiesType CreateNsxmessagingManagerServiceActionStop()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateNsxmessagingManagerServiceActionStopServiceURL = new StringBuilder("/node/services/messaging-manager?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateNsxmessagingManagerServiceActionStopServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateNsxmessagingManagerServiceActionStopServiceURL.ToString() + " did not complete successfull";
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
        public NSXTNodeServiceStatusPropertiesType CreateNsxmessagingManagerServiceActionRestart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateNsxmessagingManagerServiceActionRestartServiceURL = new StringBuilder("/node/services/messaging-manager?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateNsxmessagingManagerServiceActionRestartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateNsxmessagingManagerServiceActionRestartServiceURL.ToString() + " did not complete successfull";
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
        public NSXTNodeServicePropertiesType ReadNsxmessagingManagerService()
        {
            NSXTNodeServicePropertiesType returnValue = default(NSXTNodeServicePropertiesType);
            StringBuilder ReadNsxmessagingManagerServiceServiceURL = new StringBuilder("/node/services/messaging-manager");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadNsxmessagingManagerServiceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadNsxmessagingManagerServiceServiceURL.ToString() + " did not complete successfull";
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
    }
}