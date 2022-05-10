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
    public class PolicyPortMirroring
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyPortMirroring(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortMirroringProfileType> CreateOrReplacePortMirroringProfile(string PortMirroringProfileId, NSXTPortMirroringProfileType PortMirroringProfile, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            if (PortMirroringProfile == null) { throw new System.ArgumentNullException("PortMirroringProfile cannot be null"); }
            StringBuilder CreateOrReplacePortMirroringProfileServiceURL = new StringBuilder("/infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplacePortMirroringProfileServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortMirroringProfile(string PortMirroringProfileId, NSXTPortMirroringProfileType PortMirroringProfile, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            if (PortMirroringProfile == null) { throw new System.ArgumentNullException("PortMirroringProfile cannot be null"); }
            StringBuilder PatchPortMirroringProfileServiceURL = new StringBuilder("/infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchPortMirroringProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortMirroringProfile(string PortMirroringProfileId, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            StringBuilder DeletePortMirroringProfileServiceURL = new StringBuilder("/infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePortMirroringProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringProfileType> ReadPortMirroringProfile(string PortMirroringProfileId)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            StringBuilder ReadPortMirroringProfileServiceURL = new StringBuilder("/infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPortMirroringProfileServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringProfileListResultType> ListPortMirroringProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPortMirroringProfilesServiceURL = new StringBuilder("/infra/port-mirroring-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortMirroringProfilesServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortMirroringProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringProfileType> GlobalGlobalInfraCreateOrReplacePortMirroringProfile(string PortMirroringProfileId, NSXTPortMirroringProfileType PortMirroringProfile, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            if (PortMirroringProfile == null) { throw new System.ArgumentNullException("PortMirroringProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplacePortMirroringProfileServiceURL = new StringBuilder("/global-infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplacePortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplacePortMirroringProfileServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplacePortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPortMirroringProfile(string PortMirroringProfileId, NSXTPortMirroringProfileType PortMirroringProfile, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            if (PortMirroringProfile == null) { throw new System.ArgumentNullException("PortMirroringProfile cannot be null"); }
            StringBuilder GlobalInfraPatchPortMirroringProfileServiceURL = new StringBuilder("/global-infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchPortMirroringProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePortMirroringProfile(string PortMirroringProfileId, bool? Override = null)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            StringBuilder GlobalInfraDeletePortMirroringProfileServiceURL = new StringBuilder("/global-infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeletePortMirroringProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringProfileType> GlobalGlobalInfraReadPortMirroringProfile(string PortMirroringProfileId)
        {
            if (PortMirroringProfileId == null) { throw new System.ArgumentNullException("PortMirroringProfileId cannot be null"); }
            StringBuilder GlobalInfraReadPortMirroringProfileServiceURL = new StringBuilder("/global-infra/port-mirroring-profiles/{port-mirroring-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPortMirroringProfileServiceURL.Replace("{port-mirroring-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPortMirroringProfileServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPortMirroringProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringProfileListResultType> GlobalGlobalInfraListPortMirroringProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPortMirroringProfilesServiceURL = new StringBuilder("/global-infra/port-mirroring-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPortMirroringProfilesServiceURL.ToString();
            RestResponse<NSXTPortMirroringProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPortMirroringProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
