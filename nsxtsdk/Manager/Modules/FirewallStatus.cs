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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FirewallStatus(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTargetResourceStatusType> GetFirewallStatusOnTargetResource(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder GetFirewallStatusOnTargetResourceServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallStatusOnTargetResourceServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            GetFirewallStatusOnTargetResourceServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFirewallStatusOnTargetResourceServiceURL.ToString();
            RestResponse<NSXTTargetResourceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTargetResourceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallStatusOnTargetResourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallStatusType> UpdateFirewallStatus(string ContextType, NSXTFirewallStatusType FirewallStatus)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (FirewallStatus == null) { throw new System.ArgumentNullException("FirewallStatus cannot be null"); }
            StringBuilder UpdateFirewallStatusServiceURL = new StringBuilder("/firewall/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateFirewallStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallStatus);
            request.Resource = UpdateFirewallStatusServiceURL.ToString();
            RestResponse<NSXTFirewallStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallStatusType> GetFirewallStatus(string ContextType)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            StringBuilder GetFirewallStatusServiceURL = new StringBuilder("/firewall/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetFirewallStatusServiceURL.ToString();
            RestResponse<NSXTFirewallStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTargetResourceStatusType> EnableFirewallOnTargetResource(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder EnableFirewallOnTargetResourceServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}?action=enable_firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            EnableFirewallOnTargetResourceServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            EnableFirewallOnTargetResourceServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EnableFirewallOnTargetResourceServiceURL.ToString();
            RestResponse<NSXTTargetResourceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTargetResourceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + EnableFirewallOnTargetResourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTargetResourceStatusType> DisableFirewallOnTargetResource(string ContextType, string Id)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder DisableFirewallOnTargetResourceServiceURL = new StringBuilder("/firewall/status/{context-type}/{id}?action=disable_firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DisableFirewallOnTargetResourceServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            DisableFirewallOnTargetResourceServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DisableFirewallOnTargetResourceServiceURL.ToString();
            RestResponse<NSXTTargetResourceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTargetResourceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DisableFirewallOnTargetResourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallStatusListResultType> ListFirewallStatus()
        {
            StringBuilder ListFirewallStatusServiceURL = new StringBuilder("/firewall/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListFirewallStatusServiceURL.ToString();
            RestResponse<NSXTFirewallStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
