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
    public class PolicyIPFIXDFW
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIPFIXDFW(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPFIXDFWCollectorProfileType> GlobalGlobalInfraCreateOrReplaceIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixdfwcollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            StringBuilder GlobalInfraPatchIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixdfwcollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> GlobalGlobalInfraReadIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> CreateOrReplaceIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            StringBuilder CreateOrReplaceIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipfixdfwprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpfixdfwprofileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixdfwprofile(string IpfixDfwProfileId, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            StringBuilder DeleteIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpfixdfwprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            StringBuilder PatchIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipfixdfwprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpfixdfwprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> ReadIpfixdfwprofile(string IpfixDfwProfileId)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            StringBuilder ReadIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpfixdfwprofileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileListResultType> ListIpfixdfwprofiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixdfwprofilesServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles");
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
            request.Resource = ListIpfixdfwprofilesServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixdfwprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileListResultType> ListIpfixdfwcollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIpfixdfwcollectorProfilesServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles");
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
            request.Resource = ListIpfixdfwcollectorProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpfixdfwcollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> CreateOrReplaceIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            StringBuilder CreateOrReplaceIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixdfwcollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            StringBuilder PatchIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpfixdfwcollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> ReadIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            StringBuilder ReadIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            StringBuilder DeleteIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpfixdfwcollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileListResultType> GlobalGlobalInfraListIpfixdfwprofiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIpfixdfwprofilesServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles");
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
            request.Resource = GlobalInfraListIpfixdfwprofilesServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIpfixdfwprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> GlobalGlobalInfraCreateOrReplaceIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipfixdfwprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpfixdfwprofile(string IpfixDfwProfileId, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpfixdfwprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            StringBuilder GlobalInfraPatchIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ipfixdfwprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpfixdfwprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> GlobalGlobalInfraReadIpfixdfwprofile(string IpfixDfwProfileId)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpfixdfwprofileServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileListResultType> GlobalGlobalInfraListIpfixdfwcollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIpfixdfwcollectorProfilesServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles");
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
            request.Resource = GlobalInfraListIpfixdfwcollectorProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXDFWCollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIpfixdfwcollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
