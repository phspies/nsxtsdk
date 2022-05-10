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
    public class PolicyMacDiscovery
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyMacDiscovery(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTMacDiscoveryProfileListResultType> GlobalGlobalInfraGetMacDiscoveryProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraGetMacDiscoveryProfilesServiceURL = new StringBuilder("/global-infra/mac-discovery-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraGetMacDiscoveryProfilesServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetMacDiscoveryProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacDiscoveryProfileType> GlobalGlobalInfraUpdateMacDiscoveryProfile(string MacDiscoveryProfileId, NSXTMacDiscoveryProfileType MacDiscoveryProfile, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            if (MacDiscoveryProfile == null) { throw new System.ArgumentNullException("MacDiscoveryProfile cannot be null"); }
            StringBuilder GlobalInfraUpdateMacDiscoveryProfileServiceURL = new StringBuilder("/global-infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdateMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacDiscoveryProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdateMacDiscoveryProfileServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacDiscoveryProfileType> GlobalGlobalInfraGetMacDiscoveryProfile(string MacDiscoveryProfileId)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            StringBuilder GlobalInfraGetMacDiscoveryProfileServiceURL = new StringBuilder("/global-infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetMacDiscoveryProfileServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraCreateMacDiscoveryProfile(string MacDiscoveryProfileId, NSXTMacDiscoveryProfileType MacDiscoveryProfile, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            if (MacDiscoveryProfile == null) { throw new System.ArgumentNullException("MacDiscoveryProfile cannot be null"); }
            StringBuilder GlobalInfraCreateMacDiscoveryProfileServiceURL = new StringBuilder("/global-infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraCreateMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacDiscoveryProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateMacDiscoveryProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraCreateMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteMacDiscoveryProfile(string MacDiscoveryProfileId, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteMacDiscoveryProfileServiceURL = new StringBuilder("/global-infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteMacDiscoveryProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacDiscoveryProfileListResultType> GetMacDiscoveryProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetMacDiscoveryProfilesServiceURL = new StringBuilder("/infra/mac-discovery-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetMacDiscoveryProfilesServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMacDiscoveryProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacDiscoveryProfileType> UpdateMacDiscoveryProfile(string MacDiscoveryProfileId, NSXTMacDiscoveryProfileType MacDiscoveryProfile, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            if (MacDiscoveryProfile == null) { throw new System.ArgumentNullException("MacDiscoveryProfile cannot be null"); }
            StringBuilder UpdateMacDiscoveryProfileServiceURL = new StringBuilder("/infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacDiscoveryProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdateMacDiscoveryProfileServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMacDiscoveryProfileType> GetMacDiscoveryProfile(string MacDiscoveryProfileId)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            StringBuilder GetMacDiscoveryProfileServiceURL = new StringBuilder("/infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMacDiscoveryProfileServiceURL.ToString();
            RestResponse<NSXTMacDiscoveryProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMacDiscoveryProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateMacDiscoveryProfile(string MacDiscoveryProfileId, NSXTMacDiscoveryProfileType MacDiscoveryProfile, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            if (MacDiscoveryProfile == null) { throw new System.ArgumentNullException("MacDiscoveryProfile cannot be null"); }
            StringBuilder CreateMacDiscoveryProfileServiceURL = new StringBuilder("/infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacDiscoveryProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateMacDiscoveryProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteMacDiscoveryProfile(string MacDiscoveryProfileId, bool? Override = null)
        {
            if (MacDiscoveryProfileId == null) { throw new System.ArgumentNullException("MacDiscoveryProfileId cannot be null"); }
            StringBuilder DeleteMacDiscoveryProfileServiceURL = new StringBuilder("/infra/mac-discovery-profiles/{mac-discovery-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteMacDiscoveryProfileServiceURL.Replace("{mac-discovery-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacDiscoveryProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteMacDiscoveryProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteMacDiscoveryProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
