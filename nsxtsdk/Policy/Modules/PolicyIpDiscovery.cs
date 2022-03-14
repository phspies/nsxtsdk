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
    public class PolicyIpDiscovery
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyIpDiscovery(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileListResultType> GlobalGlobalInfraGetIpdiscoveryProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPDiscoveryProfileListResultType returnValue = default(NSXTIPDiscoveryProfileListResultType);
            StringBuilder GlobalInfraGetIpdiscoveryProfilesServiceURL = new StringBuilder("/global-infra/ip-discovery-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetIpdiscoveryProfilesServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraGetIpdiscoveryProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileType> GlobalGlobalInfraUpdateIpdiscoveryProfile(string IpDiscoveryProfileId, NSXTIPDiscoveryProfileType IpdiscoveryProfile, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            if (IpdiscoveryProfile == null) { throw new System.ArgumentNullException("IpdiscoveryProfile cannot be null"); }
            NSXTIPDiscoveryProfileType returnValue = default(NSXTIPDiscoveryProfileType);
            StringBuilder GlobalInfraUpdateIpdiscoveryProfileServiceURL = new StringBuilder("/global-infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraUpdateIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpdiscoveryProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateIpdiscoveryProfileServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + GlobalInfraUpdateIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraCreateIpdiscoveryProfile(string IpDiscoveryProfileId, NSXTIPDiscoveryProfileType IpdiscoveryProfile, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            if (IpdiscoveryProfile == null) { throw new System.ArgumentNullException("IpdiscoveryProfile cannot be null"); }
            
            StringBuilder GlobalInfraCreateIpdiscoveryProfileServiceURL = new StringBuilder("/global-infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraCreateIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpdiscoveryProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateIpdiscoveryProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + GlobalInfraCreateIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpdiscoveryProfile(string IpDiscoveryProfileId, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            
            StringBuilder GlobalInfraDeleteIpdiscoveryProfileServiceURL = new StringBuilder("/global-infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraDeleteIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpdiscoveryProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + GlobalInfraDeleteIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileType> GlobalGlobalInfraGetIpdiscoveryProfile(string IpDiscoveryProfileId)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            NSXTIPDiscoveryProfileType returnValue = default(NSXTIPDiscoveryProfileType);
            StringBuilder GlobalInfraGetIpdiscoveryProfileServiceURL = new StringBuilder("/global-infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraGetIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetIpdiscoveryProfileServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraGetIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileListResultType> GetIpdiscoveryProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPDiscoveryProfileListResultType returnValue = default(NSXTIPDiscoveryProfileListResultType);
            StringBuilder GetIpdiscoveryProfilesServiceURL = new StringBuilder("/infra/ip-discovery-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetIpdiscoveryProfilesServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpdiscoveryProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileType> UpdateIpdiscoveryProfile(string IpDiscoveryProfileId, NSXTIPDiscoveryProfileType IpdiscoveryProfile, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            if (IpdiscoveryProfile == null) { throw new System.ArgumentNullException("IpdiscoveryProfile cannot be null"); }
            NSXTIPDiscoveryProfileType returnValue = default(NSXTIPDiscoveryProfileType);
            StringBuilder UpdateIpdiscoveryProfileServiceURL = new StringBuilder("/infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpdiscoveryProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateIpdiscoveryProfileServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateIpdiscoveryProfile(string IpDiscoveryProfileId, NSXTIPDiscoveryProfileType IpdiscoveryProfile, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            if (IpdiscoveryProfile == null) { throw new System.ArgumentNullException("IpdiscoveryProfile cannot be null"); }
            
            StringBuilder CreateIpdiscoveryProfileServiceURL = new StringBuilder("/infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            CreateIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpdiscoveryProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateIpdiscoveryProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + CreateIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpdiscoveryProfile(string IpDiscoveryProfileId, bool? Override = null)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            
            StringBuilder DeleteIpdiscoveryProfileServiceURL = new StringBuilder("/infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpdiscoveryProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPDiscoveryProfileType> GetIpdiscoveryProfile(string IpDiscoveryProfileId)
        {
            if (IpDiscoveryProfileId == null) { throw new System.ArgumentNullException("IpDiscoveryProfileId cannot be null"); }
            NSXTIPDiscoveryProfileType returnValue = default(NSXTIPDiscoveryProfileType);
            StringBuilder GetIpdiscoveryProfileServiceURL = new StringBuilder("/infra/ip-discovery-profiles/{ip-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpdiscoveryProfileServiceURL.Replace("{ip-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpdiscoveryProfileServiceURL.ToString();
            IRestResponse<NSXTIPDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpdiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
