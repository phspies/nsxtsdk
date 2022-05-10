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
    public class PolicyTlsConfigProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTlsConfigProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyTlsConfigProfileListResultType> GlobalGlobalInfraListPolicyTlsConfigProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyTlsConfigProfilesServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles");
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
            request.Resource = GlobalInfraListPolicyTlsConfigProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyTlsConfigProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTlsConfigProfileType> UpdatePolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            StringBuilder UpdatePolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTlsConfigProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdatePolicyTlsConfigProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTlsConfigProfileType> GetPolicyTlsConfigProfile(string TlsInspectionConfigProfile)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            StringBuilder GetPolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyTlsConfigProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            StringBuilder PatchPolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTlsConfigProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchPolicyTlsConfigProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyTlsConfigProfile(string TlsInspectionConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            StringBuilder DeletePolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyTlsConfigProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTlsConfigProfileListResultType> ListPolicyTlsConfigProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyTlsConfigProfilesServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles");
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
            request.Resource = ListPolicyTlsConfigProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyTlsConfigProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTlsConfigProfileType> GlobalGlobalInfraUpdatePolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            StringBuilder GlobalInfraUpdatePolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTlsConfigProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTlsConfigProfileType> GlobalGlobalInfraGetPolicyTlsConfigProfile(string TlsInspectionConfigProfile)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            StringBuilder GlobalInfraGetPolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyTlsConfigProfileServiceURL.ToString();
            RestResponse<NSXTPolicyTlsConfigProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTlsConfigProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchPolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            StringBuilder GlobalInfraPatchPolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTlsConfigProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchPolicyTlsConfigProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeletePolicyTlsConfigProfile(string TlsInspectionConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            StringBuilder GlobalInfraDeletePolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeletePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeletePolicyTlsConfigProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeletePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
