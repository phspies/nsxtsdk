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
    public class PolicyIPFIXSwitch
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIPFIXSwitch(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPFIXL2ProfileListResultType> GlobalGlobalInfraListIPFIXL2Profiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIPFIXL2ProfilesServiceURL = new StringBuilder("/global-infra/ipfix-l2-profiles");
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
            request.Resource = GlobalInfraListIPFIXL2ProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIPFIXL2ProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileListResultType> ListIPFIXL2CollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIPFIXL2CollectorProfilesServiceURL = new StringBuilder("/infra/ipfix-l2-collector-profiles");
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
            request.Resource = ListIPFIXL2CollectorProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIPFIXL2CollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileListResultType> GlobalGlobalInfraListIPFIXL2CollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListIPFIXL2CollectorProfilesServiceURL = new StringBuilder("/global-infra/ipfix-l2-collector-profiles");
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
            request.Resource = GlobalInfraListIPFIXL2CollectorProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListIPFIXL2CollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2ProfileType> CreateOrReplaceIPFIXL2Profile(string IpfixL2ProfileId, NSXTIPFIXL2ProfileType IPFIXL2Profile, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            if (IPFIXL2Profile == null) { throw new System.ArgumentNullException("IPFIXL2Profile cannot be null"); }
            StringBuilder CreateOrReplaceIPFIXL2ProfileServiceURL = new StringBuilder("/infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2Profile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIPFIXL2ProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIPFIXL2Profile(string IpfixL2ProfileId, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            StringBuilder DeleteIPFIXL2ProfileServiceURL = new StringBuilder("/infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIPFIXL2ProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2ProfileType> ReadIPFIXL2Profile(string IpfixL2ProfileId)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            StringBuilder ReadIPFIXL2ProfileServiceURL = new StringBuilder("/infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIPFIXL2ProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIPFIXL2Profile(string IpfixL2ProfileId, NSXTIPFIXL2ProfileType IPFIXL2Profile, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            if (IPFIXL2Profile == null) { throw new System.ArgumentNullException("IPFIXL2Profile cannot be null"); }
            StringBuilder PatchIPFIXL2ProfileServiceURL = new StringBuilder("/infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2Profile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIPFIXL2ProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileType> CreateOrReplaceIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, NSXTIPFIXL2CollectorProfileType IPFIXL2CollectorProfile, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            if (IPFIXL2CollectorProfile == null) { throw new System.ArgumentNullException("IPFIXL2CollectorProfile cannot be null"); }
            StringBuilder CreateOrReplaceIPFIXL2CollectorProfileServiceURL = new StringBuilder("/infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2CollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, NSXTIPFIXL2CollectorProfileType IPFIXL2CollectorProfile, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            if (IPFIXL2CollectorProfile == null) { throw new System.ArgumentNullException("IPFIXL2CollectorProfile cannot be null"); }
            StringBuilder PatchIPFIXL2CollectorProfileServiceURL = new StringBuilder("/infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2CollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            StringBuilder DeleteIPFIXL2CollectorProfileServiceURL = new StringBuilder("/infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileType> ReadIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            StringBuilder ReadIPFIXL2CollectorProfileServiceURL = new StringBuilder("/infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2ProfileListResultType> ListIPFIXL2Profiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIPFIXL2ProfilesServiceURL = new StringBuilder("/infra/ipfix-l2-profiles");
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
            request.Resource = ListIPFIXL2ProfilesServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIPFIXL2ProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2ProfileType> GlobalGlobalInfraCreateOrReplaceIPFIXL2Profile(string IpfixL2ProfileId, NSXTIPFIXL2ProfileType IPFIXL2Profile, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            if (IPFIXL2Profile == null) { throw new System.ArgumentNullException("IPFIXL2Profile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIPFIXL2ProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2Profile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIPFIXL2ProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIPFIXL2Profile(string IpfixL2ProfileId, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIPFIXL2ProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIPFIXL2ProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2ProfileType> GlobalGlobalInfraReadIPFIXL2Profile(string IpfixL2ProfileId)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIPFIXL2ProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIPFIXL2ProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2ProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2ProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIPFIXL2Profile(string IpfixL2ProfileId, NSXTIPFIXL2ProfileType IPFIXL2Profile, bool? Override = null)
        {
            if (IpfixL2ProfileId == null) { throw new System.ArgumentNullException("IpfixL2ProfileId cannot be null"); }
            if (IPFIXL2Profile == null) { throw new System.ArgumentNullException("IPFIXL2Profile cannot be null"); }
            StringBuilder GlobalInfraPatchIPFIXL2ProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-profiles/{ipfix-l2-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIPFIXL2ProfileServiceURL.Replace("{ipfix-l2-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2Profile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIPFIXL2ProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIPFIXL2ProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileType> GlobalGlobalInfraCreateOrReplaceIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, NSXTIPFIXL2CollectorProfileType IPFIXL2CollectorProfile, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            if (IPFIXL2CollectorProfile == null) { throw new System.ArgumentNullException("IPFIXL2CollectorProfile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceIPFIXL2CollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2CollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, NSXTIPFIXL2CollectorProfileType IPFIXL2CollectorProfile, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            if (IPFIXL2CollectorProfile == null) { throw new System.ArgumentNullException("IPFIXL2CollectorProfile cannot be null"); }
            StringBuilder GlobalInfraPatchIPFIXL2CollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IPFIXL2CollectorProfile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId, bool? Override = null)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteIPFIXL2CollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXL2CollectorProfileType> GlobalGlobalInfraReadIPFIXL2CollectorProfile(string IpfixL2CollectorProfileId)
        {
            if (IpfixL2CollectorProfileId == null) { throw new System.ArgumentNullException("IpfixL2CollectorProfileId cannot be null"); }
            StringBuilder GlobalInfraReadIPFIXL2CollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-l2-collector-profiles/{ipfix-l2-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadIPFIXL2CollectorProfileServiceURL.Replace("{ipfix-l2-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixL2CollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIPFIXL2CollectorProfileServiceURL.ToString();
            RestResponse<NSXTIPFIXL2CollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXL2CollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIPFIXL2CollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
