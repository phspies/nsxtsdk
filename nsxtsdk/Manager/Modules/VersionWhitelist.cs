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
    public class VersionWhitelist
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public VersionWhitelist(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTAcceptableComponentVersionListType GetVersionWhitelist()
        {
            NSXTAcceptableComponentVersionListType returnValue = default(NSXTAcceptableComponentVersionListType);
            StringBuilder GetVersionWhitelistServiceURL = new StringBuilder("/upgrade/version-whitelist");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetVersionWhitelistServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetVersionWhitelistServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTAcceptableComponentVersionListType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTAcceptableComponentVersionListType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void UpdateVersionWhitelist(string ComponentType, NSXTVersionListType VersionList)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            if (VersionList == null) { throw new System.ArgumentNullException("VersionList cannot be null"); }
            
            StringBuilder UpdateVersionWhitelistServiceURL = new StringBuilder("/upgrade/version-whitelist/{component_type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateVersionWhitelistServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(VersionList, defaultSerializationSettings));
            request.Resource = UpdateVersionWhitelistServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateVersionWhitelistServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTAcceptableComponentVersionType GetVersionWhitelistByComponent(string ComponentType)
        {
            if (ComponentType == null) { throw new System.ArgumentNullException("ComponentType cannot be null"); }
            NSXTAcceptableComponentVersionType returnValue = default(NSXTAcceptableComponentVersionType);
            StringBuilder GetVersionWhitelistByComponentServiceURL = new StringBuilder("/upgrade/version-whitelist/{component_type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetVersionWhitelistByComponentServiceURL.Replace("{component_type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVersionWhitelistByComponentServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetVersionWhitelistByComponentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTAcceptableComponentVersionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTAcceptableComponentVersionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
