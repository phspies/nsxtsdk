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
    public class NodeMandatoryAccessControlModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeMandatoryAccessControlModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GetNodeMandatoryAccessControlReport()
        {
            
            StringBuilder GetNodeMandatoryAccessControlReportServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control/report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetNodeMandatoryAccessControlReportServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetNodeMandatoryAccessControlReportServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMandatoryAccessControlPropertiesType SetNodeMandatoryAccessControl(NSXTMandatoryAccessControlPropertiesType MandatoryAccessControlProperties)
        {
            if (MandatoryAccessControlProperties == null) { throw new System.ArgumentNullException("MandatoryAccessControlProperties cannot be null"); }
            NSXTMandatoryAccessControlPropertiesType returnValue = default(NSXTMandatoryAccessControlPropertiesType);
            StringBuilder SetNodeMandatoryAccessControlServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(MandatoryAccessControlProperties, defaultSerializationSettings));
            request.Resource = SetNodeMandatoryAccessControlServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + SetNodeMandatoryAccessControlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMandatoryAccessControlPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMandatoryAccessControlPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMandatoryAccessControlPropertiesType GetNodeMandatoryAccessControl()
        {
            NSXTMandatoryAccessControlPropertiesType returnValue = default(NSXTMandatoryAccessControlPropertiesType);
            StringBuilder GetNodeMandatoryAccessControlServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetNodeMandatoryAccessControlServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetNodeMandatoryAccessControlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMandatoryAccessControlPropertiesType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMandatoryAccessControlPropertiesType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
