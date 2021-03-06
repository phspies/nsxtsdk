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
    public class PolicyLoadBalancer
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyLoadBalancer(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLBServiceListResultType> ListLbservices(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbservicesServiceURL = new StringBuilder("/infra/lb-services");
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
            request.Resource = ListLbservicesServiceURL.ToString();
            RestResponse<NSXTLBServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbservicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbSslCipherAndProtocolListResultType> ListSslCiphersAndProtocols(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSslCiphersAndProtocolsServiceURL = new StringBuilder("/infra/lb-ssl-ciphers-and-protocols");
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
            request.Resource = ListSslCiphersAndProtocolsServiceURL.ToString();
            RestResponse<NSXTLbSslCipherAndProtocolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbSslCipherAndProtocolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSslCiphersAndProtocolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBClientSslProfileType> UpdateLbclientSslProfile(string LbClientSslProfileId, NSXTLBClientSslProfileType LbclientSslProfile)
        {
            if (LbClientSslProfileId == null) { throw new System.ArgumentNullException("LbClientSslProfileId cannot be null"); }
            if (LbclientSslProfile == null) { throw new System.ArgumentNullException("LbclientSslProfile cannot be null"); }
            StringBuilder UpdateLbclientSslProfileServiceURL = new StringBuilder("/infra/lb-client-ssl-profiles/{lb-client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbclientSslProfileServiceURL.Replace("{lb-client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbclientSslProfile);
            request.Resource = UpdateLbclientSslProfileServiceURL.ToString();
            RestResponse<NSXTLBClientSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBClientSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbclientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbclientSslProfile(string LbClientSslProfileId, bool? Force = null)
        {
            if (LbClientSslProfileId == null) { throw new System.ArgumentNullException("LbClientSslProfileId cannot be null"); }
            StringBuilder DeleteLbclientSslProfileServiceURL = new StringBuilder("/infra/lb-client-ssl-profiles/{lb-client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbclientSslProfileServiceURL.Replace("{lb-client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbclientSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbclientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbclientSslProfile(string LbClientSslProfileId, NSXTLBClientSslProfileType LbclientSslProfile)
        {
            if (LbClientSslProfileId == null) { throw new System.ArgumentNullException("LbClientSslProfileId cannot be null"); }
            if (LbclientSslProfile == null) { throw new System.ArgumentNullException("LbclientSslProfile cannot be null"); }
            StringBuilder PatchLbclientSslProfileServiceURL = new StringBuilder("/infra/lb-client-ssl-profiles/{lb-client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbclientSslProfileServiceURL.Replace("{lb-client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbclientSslProfile);
            request.Resource = PatchLbclientSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbclientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBClientSslProfileType> ReadLbclientSslProfile(string LbClientSslProfileId)
        {
            if (LbClientSslProfileId == null) { throw new System.ArgumentNullException("LbClientSslProfileId cannot be null"); }
            StringBuilder ReadLbclientSslProfileServiceURL = new StringBuilder("/infra/lb-client-ssl-profiles/{lb-client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbclientSslProfileServiceURL.Replace("{lb-client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbclientSslProfileServiceURL.ToString();
            RestResponse<NSXTLBClientSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBClientSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbclientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServiceType> UpdateLbservice(string LbServiceId, NSXTLBServiceType Lbservice)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (Lbservice == null) { throw new System.ArgumentNullException("Lbservice cannot be null"); }
            StringBuilder UpdateLbserviceServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbserviceServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Lbservice);
            request.Resource = UpdateLbserviceServiceURL.ToString();
            RestResponse<NSXTLBServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServiceType> ReadLbservice(string LbServiceId)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            StringBuilder ReadLbserviceServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbserviceServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbserviceServiceURL.ToString();
            RestResponse<NSXTLBServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbservice(string LbServiceId, NSXTLBServiceType Lbservice)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            if (Lbservice == null) { throw new System.ArgumentNullException("Lbservice cannot be null"); }
            StringBuilder PatchLbserviceServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbserviceServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Lbservice);
            request.Resource = PatchLbserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbservice(string LbServiceId, bool? Force = null)
        {
            if (LbServiceId == null) { throw new System.ArgumentNullException("LbServiceId cannot be null"); }
            StringBuilder DeleteLbserviceServiceURL = new StringBuilder("/infra/lb-services/{lb-service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbserviceServiceURL.Replace("{lb-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbserviceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPersistenceProfileListResultType> ListLbpersistenceProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbpersistenceProfilesServiceURL = new StringBuilder("/infra/lb-persistence-profiles");
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
            request.Resource = ListLbpersistenceProfilesServiceURL.ToString();
            RestResponse<NSXTLBPersistenceProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPersistenceProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbpersistenceProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBClientSslProfileListResultType> ListLbclientSslProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbclientSslProfilesServiceURL = new StringBuilder("/infra/lb-client-ssl-profiles");
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
            request.Resource = ListLbclientSslProfilesServiceURL.ToString();
            RestResponse<NSXTLBClientSslProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBClientSslProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbclientSslProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServerSslProfileListResultType> ListLbserverSslProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbserverSslProfilesServiceURL = new StringBuilder("/infra/lb-server-ssl-profiles");
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
            request.Resource = ListLbserverSslProfilesServiceURL.ToString();
            RestResponse<NSXTLBServerSslProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServerSslProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbserverSslProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBMonitorProfileListResultType> ListLbmonitorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbmonitorProfilesServiceURL = new StringBuilder("/infra/lb-monitor-profiles");
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
            request.Resource = ListLbmonitorProfilesServiceURL.ToString();
            RestResponse<NSXTLBMonitorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBMonitorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbmonitorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPersistenceProfileType> UpdateLbpersistenceProfile(string LbPersistenceProfileId, NSXTLBPersistenceProfileType LbpersistenceProfile)
        {
            if (LbPersistenceProfileId == null) { throw new System.ArgumentNullException("LbPersistenceProfileId cannot be null"); }
            if (LbpersistenceProfile == null) { throw new System.ArgumentNullException("LbpersistenceProfile cannot be null"); }
            StringBuilder UpdateLbpersistenceProfileServiceURL = new StringBuilder("/infra/lb-persistence-profiles/{lb-persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbpersistenceProfileServiceURL.Replace("{lb-persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbpersistenceProfile);
            request.Resource = UpdateLbpersistenceProfileServiceURL.ToString();
            RestResponse<NSXTLBPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbpersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbpersistenceProfile(string LbPersistenceProfileId, NSXTLBPersistenceProfileType LbpersistenceProfile)
        {
            if (LbPersistenceProfileId == null) { throw new System.ArgumentNullException("LbPersistenceProfileId cannot be null"); }
            if (LbpersistenceProfile == null) { throw new System.ArgumentNullException("LbpersistenceProfile cannot be null"); }
            StringBuilder PatchLbpersistenceProfileServiceURL = new StringBuilder("/infra/lb-persistence-profiles/{lb-persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbpersistenceProfileServiceURL.Replace("{lb-persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbpersistenceProfile);
            request.Resource = PatchLbpersistenceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbpersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPersistenceProfileType> ReadLbpersistenceProfile(string LbPersistenceProfileId)
        {
            if (LbPersistenceProfileId == null) { throw new System.ArgumentNullException("LbPersistenceProfileId cannot be null"); }
            StringBuilder ReadLbpersistenceProfileServiceURL = new StringBuilder("/infra/lb-persistence-profiles/{lb-persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbpersistenceProfileServiceURL.Replace("{lb-persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbpersistenceProfileServiceURL.ToString();
            RestResponse<NSXTLBPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbpersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbpersistenceProfile(string LbPersistenceProfileId, bool? Force = null)
        {
            if (LbPersistenceProfileId == null) { throw new System.ArgumentNullException("LbPersistenceProfileId cannot be null"); }
            StringBuilder DeleteLbpersistenceProfileServiceURL = new StringBuilder("/infra/lb-persistence-profiles/{lb-persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbpersistenceProfileServiceURL.Replace("{lb-persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbpersistenceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbpersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServerSslProfileType> UpdateLbserverSslProfile(string LbServerSslProfileId, NSXTLBServerSslProfileType LbserverSslProfile)
        {
            if (LbServerSslProfileId == null) { throw new System.ArgumentNullException("LbServerSslProfileId cannot be null"); }
            if (LbserverSslProfile == null) { throw new System.ArgumentNullException("LbserverSslProfile cannot be null"); }
            StringBuilder UpdateLbserverSslProfileServiceURL = new StringBuilder("/infra/lb-server-ssl-profiles/{lb-server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbserverSslProfileServiceURL.Replace("{lb-server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbserverSslProfile);
            request.Resource = UpdateLbserverSslProfileServiceURL.ToString();
            RestResponse<NSXTLBServerSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServerSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbserverSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbserverSslProfile(string LbServerSslProfileId, NSXTLBServerSslProfileType LbserverSslProfile)
        {
            if (LbServerSslProfileId == null) { throw new System.ArgumentNullException("LbServerSslProfileId cannot be null"); }
            if (LbserverSslProfile == null) { throw new System.ArgumentNullException("LbserverSslProfile cannot be null"); }
            StringBuilder PatchLbserverSslProfileServiceURL = new StringBuilder("/infra/lb-server-ssl-profiles/{lb-server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbserverSslProfileServiceURL.Replace("{lb-server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbserverSslProfile);
            request.Resource = PatchLbserverSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbserverSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbserverSslProfile(string LbServerSslProfileId, bool? Force = null)
        {
            if (LbServerSslProfileId == null) { throw new System.ArgumentNullException("LbServerSslProfileId cannot be null"); }
            StringBuilder DeleteLbserverSslProfileServiceURL = new StringBuilder("/infra/lb-server-ssl-profiles/{lb-server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbserverSslProfileServiceURL.Replace("{lb-server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbserverSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbserverSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBServerSslProfileType> ReadLbserverSslProfile(string LbServerSslProfileId)
        {
            if (LbServerSslProfileId == null) { throw new System.ArgumentNullException("LbServerSslProfileId cannot be null"); }
            StringBuilder ReadLbserverSslProfileServiceURL = new StringBuilder("/infra/lb-server-ssl-profiles/{lb-server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbserverSslProfileServiceURL.Replace("{lb-server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbserverSslProfileServiceURL.ToString();
            RestResponse<NSXTLBServerSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBServerSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbserverSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBMonitorProfileType> UpdateLbmonitorProfile(string LbMonitorProfileId, NSXTLBMonitorProfileType LbmonitorProfile)
        {
            if (LbMonitorProfileId == null) { throw new System.ArgumentNullException("LbMonitorProfileId cannot be null"); }
            if (LbmonitorProfile == null) { throw new System.ArgumentNullException("LbmonitorProfile cannot be null"); }
            StringBuilder UpdateLbmonitorProfileServiceURL = new StringBuilder("/infra/lb-monitor-profiles/{lb-monitor-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbmonitorProfileServiceURL.Replace("{lb-monitor-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbMonitorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbmonitorProfile);
            request.Resource = UpdateLbmonitorProfileServiceURL.ToString();
            RestResponse<NSXTLBMonitorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBMonitorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbmonitorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBMonitorProfileType> ReadLbmonitorProfile(string LbMonitorProfileId)
        {
            if (LbMonitorProfileId == null) { throw new System.ArgumentNullException("LbMonitorProfileId cannot be null"); }
            StringBuilder ReadLbmonitorProfileServiceURL = new StringBuilder("/infra/lb-monitor-profiles/{lb-monitor-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbmonitorProfileServiceURL.Replace("{lb-monitor-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbMonitorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbmonitorProfileServiceURL.ToString();
            RestResponse<NSXTLBMonitorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBMonitorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbmonitorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbmonitorProfile(string LbMonitorProfileId, bool? Force = null)
        {
            if (LbMonitorProfileId == null) { throw new System.ArgumentNullException("LbMonitorProfileId cannot be null"); }
            StringBuilder DeleteLbmonitorProfileServiceURL = new StringBuilder("/infra/lb-monitor-profiles/{lb-monitor-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbmonitorProfileServiceURL.Replace("{lb-monitor-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbMonitorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbmonitorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbmonitorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbmonitorProfile(string LbMonitorProfileId, NSXTLBMonitorProfileType LbmonitorProfile)
        {
            if (LbMonitorProfileId == null) { throw new System.ArgumentNullException("LbMonitorProfileId cannot be null"); }
            if (LbmonitorProfile == null) { throw new System.ArgumentNullException("LbmonitorProfile cannot be null"); }
            StringBuilder PatchLbmonitorProfileServiceURL = new StringBuilder("/infra/lb-monitor-profiles/{lb-monitor-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbmonitorProfileServiceURL.Replace("{lb-monitor-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbMonitorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbmonitorProfile);
            request.Resource = PatchLbmonitorProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbmonitorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBVirtualServerType> UpdateLbvirtualServer(string LbVirtualServerId, NSXTLBVirtualServerType LbvirtualServer)
        {
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            if (LbvirtualServer == null) { throw new System.ArgumentNullException("LbvirtualServer cannot be null"); }
            StringBuilder UpdateLbvirtualServerServiceURL = new StringBuilder("/infra/lb-virtual-servers/{lb-virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbvirtualServerServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbvirtualServer);
            request.Resource = UpdateLbvirtualServerServiceURL.ToString();
            RestResponse<NSXTLBVirtualServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBVirtualServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbvirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbvirtualServer(string LbVirtualServerId, bool? Force = null)
        {
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            StringBuilder DeleteLbvirtualServerServiceURL = new StringBuilder("/infra/lb-virtual-servers/{lb-virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbvirtualServerServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbvirtualServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbvirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbvirtualServer(string LbVirtualServerId, NSXTLBVirtualServerType LbvirtualServer)
        {
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            if (LbvirtualServer == null) { throw new System.ArgumentNullException("LbvirtualServer cannot be null"); }
            StringBuilder PatchLbvirtualServerServiceURL = new StringBuilder("/infra/lb-virtual-servers/{lb-virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbvirtualServerServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbvirtualServer);
            request.Resource = PatchLbvirtualServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbvirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBVirtualServerType> ReadLbvirtualServer(string LbVirtualServerId)
        {
            if (LbVirtualServerId == null) { throw new System.ArgumentNullException("LbVirtualServerId cannot be null"); }
            StringBuilder ReadLbvirtualServerServiceURL = new StringBuilder("/infra/lb-virtual-servers/{lb-virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbvirtualServerServiceURL.Replace("{lb-virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbVirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbvirtualServerServiceURL.ToString();
            RestResponse<NSXTLBVirtualServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBVirtualServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbvirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBAppProfileListResultType> ListLbappProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbappProfilesServiceURL = new StringBuilder("/infra/lb-app-profiles");
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
            request.Resource = ListLbappProfilesServiceURL.ToString();
            RestResponse<NSXTLBAppProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBAppProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbappProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPoolListResultType> ListLbpools(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbpoolsServiceURL = new StringBuilder("/infra/lb-pools");
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
            request.Resource = ListLbpoolsServiceURL.ToString();
            RestResponse<NSXTLBPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbpoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPoolType> UpdateLbpool(string LbPoolId, NSXTLBPoolType Lbpool)
        {
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            if (Lbpool == null) { throw new System.ArgumentNullException("Lbpool cannot be null"); }
            StringBuilder UpdateLbpoolServiceURL = new StringBuilder("/infra/lb-pools/{lb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbpoolServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Lbpool);
            request.Resource = UpdateLbpoolServiceURL.ToString();
            RestResponse<NSXTLBPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBPoolType> ReadLbpool(string LbPoolId)
        {
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            StringBuilder ReadLbpoolServiceURL = new StringBuilder("/infra/lb-pools/{lb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbpoolServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbpoolServiceURL.ToString();
            RestResponse<NSXTLBPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbpool(string LbPoolId, NSXTLBPoolType Lbpool)
        {
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            if (Lbpool == null) { throw new System.ArgumentNullException("Lbpool cannot be null"); }
            StringBuilder PatchLbpoolServiceURL = new StringBuilder("/infra/lb-pools/{lb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbpoolServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Lbpool);
            request.Resource = PatchLbpoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbpool(string LbPoolId, bool? Force = null)
        {
            if (LbPoolId == null) { throw new System.ArgumentNullException("LbPoolId cannot be null"); }
            StringBuilder DeleteLbpoolServiceURL = new StringBuilder("/infra/lb-pools/{lb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbpoolServiceURL.Replace("{lb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbpoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBAppProfileType> UpdateLbappProfile(string LbAppProfileId, NSXTLBAppProfileType LbappProfile)
        {
            if (LbAppProfileId == null) { throw new System.ArgumentNullException("LbAppProfileId cannot be null"); }
            if (LbappProfile == null) { throw new System.ArgumentNullException("LbappProfile cannot be null"); }
            StringBuilder UpdateLbappProfileServiceURL = new StringBuilder("/infra/lb-app-profiles/{lb-app-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLbappProfileServiceURL.Replace("{lb-app-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbAppProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbappProfile);
            request.Resource = UpdateLbappProfileServiceURL.ToString();
            RestResponse<NSXTLBAppProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBAppProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLbappProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchLbappProfile(string LbAppProfileId, NSXTLBAppProfileType LbappProfile)
        {
            if (LbAppProfileId == null) { throw new System.ArgumentNullException("LbAppProfileId cannot be null"); }
            if (LbappProfile == null) { throw new System.ArgumentNullException("LbappProfile cannot be null"); }
            StringBuilder PatchLbappProfileServiceURL = new StringBuilder("/infra/lb-app-profiles/{lb-app-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchLbappProfileServiceURL.Replace("{lb-app-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbAppProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbappProfile);
            request.Resource = PatchLbappProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchLbappProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLbappProfile(string LbAppProfileId, bool? Force = null)
        {
            if (LbAppProfileId == null) { throw new System.ArgumentNullException("LbAppProfileId cannot be null"); }
            StringBuilder DeleteLbappProfileServiceURL = new StringBuilder("/infra/lb-app-profiles/{lb-app-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLbappProfileServiceURL.Replace("{lb-app-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbAppProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteLbappProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLbappProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBAppProfileType> ReadLbappProfile(string LbAppProfileId)
        {
            if (LbAppProfileId == null) { throw new System.ArgumentNullException("LbAppProfileId cannot be null"); }
            StringBuilder ReadLbappProfileServiceURL = new StringBuilder("/infra/lb-app-profiles/{lb-app-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLbappProfileServiceURL.Replace("{lb-app-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LbAppProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLbappProfileServiceURL.ToString();
            RestResponse<NSXTLBAppProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBAppProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLbappProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLBVirtualServerListResultType> ListLbvirtualServers(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLbvirtualServersServiceURL = new StringBuilder("/infra/lb-virtual-servers");
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
            request.Resource = ListLbvirtualServersServiceURL.ToString();
            RestResponse<NSXTLBVirtualServerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLBVirtualServerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLbvirtualServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
