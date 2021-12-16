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
    public class FirewallStatus
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public FirewallStatus(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTargetResourceStatusType GetFirewallStatusOnTargetResource(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            NSXTTargetResourceStatusType returnValue = default(NSXTTargetResourceStatusType);
            StringBuilder GetFirewallStatusOnTargetResourceServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetFirewallStatusOnTargetResourceServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            GetFirewallStatusOnTargetResourceServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFirewallStatusOnTargetResourceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetFirewallStatusOnTargetResourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTargetResourceStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTargetResourceStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFirewallStatusType UpdateFirewallStatus(string ContextType, NSXTFirewallStatusType FirewallStatus)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (FirewallStatus == null) { throw new System.ArgumentNullException("FirewallStatus cannot be null"); }
            NSXTFirewallStatusType returnValue = default(NSXTFirewallStatusType);
            StringBuilder UpdateFirewallStatusServiceURL = new StringBuilder("/firewall/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateFirewallStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(FirewallStatus, defaultSerializationSettings));
            request.Resource = UpdateFirewallStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTFirewallStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTFirewallStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFirewallStatusType GetFirewallStatus(string ContextType)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            NSXTFirewallStatusType returnValue = default(NSXTFirewallStatusType);
            StringBuilder GetFirewallStatusServiceURL = new StringBuilder("/firewall/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetFirewallStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFirewallStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTFirewallStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTFirewallStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTargetResourceStatusType EnableFirewallOnTargetResourceEnableFirewall(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            NSXTTargetResourceStatusType returnValue = default(NSXTTargetResourceStatusType);
            StringBuilder EnableFirewallOnTargetResourceEnableFirewallServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}?action=enable_firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            EnableFirewallOnTargetResourceEnableFirewallServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            EnableFirewallOnTargetResourceEnableFirewallServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EnableFirewallOnTargetResourceEnableFirewallServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + EnableFirewallOnTargetResourceEnableFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTargetResourceStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTargetResourceStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTargetResourceStatusType DisableFirewallOnTargetResourceDisableFirewall(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            NSXTTargetResourceStatusType returnValue = default(NSXTTargetResourceStatusType);
            StringBuilder DisableFirewallOnTargetResourceDisableFirewallServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}?action=disable_firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            DisableFirewallOnTargetResourceDisableFirewallServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            DisableFirewallOnTargetResourceDisableFirewallServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DisableFirewallOnTargetResourceDisableFirewallServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + DisableFirewallOnTargetResourceDisableFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTargetResourceStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTargetResourceStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFirewallStatusListResultType ListFirewallStatus()
        {
            NSXTFirewallStatusListResultType returnValue = default(NSXTFirewallStatusListResultType);
            StringBuilder ListFirewallStatusServiceURL = new StringBuilder("/firewall/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListFirewallStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTFirewallStatusListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTFirewallStatusListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
