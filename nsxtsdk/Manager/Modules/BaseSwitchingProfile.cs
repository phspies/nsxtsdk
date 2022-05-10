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
    public class BaseSwitchingProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public BaseSwitchingProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSwitchingProfileStatusType> GetSwitchingProfileStatus(string SwitchingProfileId)
        {
            if (SwitchingProfileId == null) { throw new System.ArgumentNullException("SwitchingProfileId cannot be null"); }
            StringBuilder GetSwitchingProfileStatusServiceURL = new StringBuilder("/switching-profiles/{switching-profile-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSwitchingProfileStatusServiceURL.Replace("{switching-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SwitchingProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSwitchingProfileStatusServiceURL.ToString();
            RestResponse<NSXTSwitchingProfileStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSwitchingProfileStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSwitchingProfileStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseSwitchingProfileType> UpdateSwitchingProfile(string SwitchingProfileId, NSXTBaseSwitchingProfileType BaseSwitchingProfile)
        {
            if (SwitchingProfileId == null) { throw new System.ArgumentNullException("SwitchingProfileId cannot be null"); }
            if (BaseSwitchingProfile == null) { throw new System.ArgumentNullException("BaseSwitchingProfile cannot be null"); }
            StringBuilder UpdateSwitchingProfileServiceURL = new StringBuilder("/switching-profiles/{switching-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSwitchingProfileServiceURL.Replace("{switching-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SwitchingProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseSwitchingProfile);
            request.Resource = UpdateSwitchingProfileServiceURL.ToString();
            RestResponse<NSXTBaseSwitchingProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseSwitchingProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSwitchingProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseSwitchingProfileType> GetSwitchingProfile(string SwitchingProfileId)
        {
            if (SwitchingProfileId == null) { throw new System.ArgumentNullException("SwitchingProfileId cannot be null"); }
            StringBuilder GetSwitchingProfileServiceURL = new StringBuilder("/switching-profiles/{switching-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSwitchingProfileServiceURL.Replace("{switching-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SwitchingProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSwitchingProfileServiceURL.ToString();
            RestResponse<NSXTBaseSwitchingProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseSwitchingProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSwitchingProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSwitchingProfile(string SwitchingProfileId, bool? Unbind = null)
        {
            if (SwitchingProfileId == null) { throw new System.ArgumentNullException("SwitchingProfileId cannot be null"); }
            StringBuilder DeleteSwitchingProfileServiceURL = new StringBuilder("/switching-profiles/{switching-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSwitchingProfileServiceURL.Replace("{switching-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SwitchingProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Unbind != null) { request.AddQueryParameter("unbind", Unbind.ToString()); }
            request.Resource = DeleteSwitchingProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSwitchingProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseSwitchingProfileType> CreateSwitchingProfile(NSXTBaseSwitchingProfileType BaseSwitchingProfile)
        {
            if (BaseSwitchingProfile == null) { throw new System.ArgumentNullException("BaseSwitchingProfile cannot be null"); }
            StringBuilder CreateSwitchingProfileServiceURL = new StringBuilder("/switching-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BaseSwitchingProfile);
            request.Resource = CreateSwitchingProfileServiceURL.ToString();
            RestResponse<NSXTBaseSwitchingProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseSwitchingProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSwitchingProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSwitchingProfilesListResultType> ListSwitchingProfiles(string? Cursor = null, bool? IncludeSystemOwned = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? SwitchingProfileType = null)
        {
            StringBuilder ListSwitchingProfilesServiceURL = new StringBuilder("/switching-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeSystemOwned != null) { request.AddQueryParameter("include_system_owned", IncludeSystemOwned.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (SwitchingProfileType != null) { request.AddQueryParameter("switching_profile_type", SwitchingProfileType.ToString()); }
            request.Resource = ListSwitchingProfilesServiceURL.ToString();
            RestResponse<NSXTSwitchingProfilesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSwitchingProfilesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSwitchingProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
