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
    public class LdapIdentitySources
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LdapIdentitySources(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLdapIdentitySourceType> CreateOrUpdateLdapIdentitySource(string LdapIdentitySourceId, NSXTLdapIdentitySourceType LdapIdentitySource)
        {
            if (LdapIdentitySourceId == null) { throw new System.ArgumentNullException("LdapIdentitySourceId cannot be null"); }
            if (LdapIdentitySource == null) { throw new System.ArgumentNullException("LdapIdentitySource cannot be null"); }
            StringBuilder CreateOrUpdateLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources/{ldap-identity-source-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateLdapIdentitySourceServiceURL.Replace("{ldap-identity-source-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapIdentitySourceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LdapIdentitySource);
            request.Resource = CreateOrUpdateLdapIdentitySourceServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLdapIdentitySourceType> ReadLdapIdentitySource(string LdapIdentitySourceId)
        {
            if (LdapIdentitySourceId == null) { throw new System.ArgumentNullException("LdapIdentitySourceId cannot be null"); }
            StringBuilder ReadLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources/{ldap-identity-source-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLdapIdentitySourceServiceURL.Replace("{ldap-identity-source-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapIdentitySourceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLdapIdentitySourceServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLdapIdentitySource(string LdapIdentitySourceId)
        {
            if (LdapIdentitySourceId == null) { throw new System.ArgumentNullException("LdapIdentitySourceId cannot be null"); }
            StringBuilder DeleteLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources/{ldap-identity-source-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLdapIdentitySourceServiceURL.Replace("{ldap-identity-source-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapIdentitySourceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLdapIdentitySourceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLdapIdentitySourceProbeResultsType> ProbeUnconfiguredLdapIdentitySource(NSXTLdapIdentitySourceType LdapIdentitySource)
        {
            if (LdapIdentitySource == null) { throw new System.ArgumentNullException("LdapIdentitySource cannot be null"); }
            StringBuilder ProbeUnconfiguredLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources?action=probe_identity_source");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LdapIdentitySource);
            request.Resource = ProbeUnconfiguredLdapIdentitySourceServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceProbeResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceProbeResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ProbeUnconfiguredLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLdapIdentitySourceListResultType> ListLdapIdentitySources(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLdapIdentitySourcesServiceURL = new StringBuilder("/aaa/ldap-identity-sources");
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
            request.Resource = ListLdapIdentitySourcesServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLdapIdentitySourcesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPeerCertificateChainType> FetchIdentitySourceLdapServerCertificate(NSXTIdentitySourceLdapServerEndpointType IdentitySourceLdapServerEndpoint)
        {
            if (IdentitySourceLdapServerEndpoint == null) { throw new System.ArgumentNullException("IdentitySourceLdapServerEndpoint cannot be null"); }
            StringBuilder FetchIdentitySourceLdapServerCertificateServiceURL = new StringBuilder("/aaa/ldap-identity-sources?action=fetch_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdentitySourceLdapServerEndpoint);
            request.Resource = FetchIdentitySourceLdapServerCertificateServiceURL.ToString();
            RestResponse<NSXTPeerCertificateChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPeerCertificateChainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FetchIdentitySourceLdapServerCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdentitySourceLdapServerProbeResultType> ProbeIdentitySourceLdapServer(NSXTIdentitySourceLdapServerType IdentitySourceLdapServer)
        {
            if (IdentitySourceLdapServer == null) { throw new System.ArgumentNullException("IdentitySourceLdapServer cannot be null"); }
            StringBuilder ProbeIdentitySourceLdapServerServiceURL = new StringBuilder("/aaa/ldap-identity-sources?action=probe_ldap_server");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdentitySourceLdapServer);
            request.Resource = ProbeIdentitySourceLdapServerServiceURL.ToString();
            RestResponse<NSXTIdentitySourceLdapServerProbeResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdentitySourceLdapServerProbeResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ProbeIdentitySourceLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLdapIdentitySourceProbeResultsType> ProbeConfiguredLdapIdentitySource(string LdapIdentitySourceId)
        {
            if (LdapIdentitySourceId == null) { throw new System.ArgumentNullException("LdapIdentitySourceId cannot be null"); }
            StringBuilder ProbeConfiguredLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources/{ldap-identity-source-id}?action=probe");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ProbeConfiguredLdapIdentitySourceServiceURL.Replace("{ldap-identity-source-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapIdentitySourceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ProbeConfiguredLdapIdentitySourceServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceProbeResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceProbeResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ProbeConfiguredLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLdapIdentitySourceSearchResultListType> SearchLdapIdentitySource(string LdapIdentitySourceId, string FilterValue)
        {
            if (LdapIdentitySourceId == null) { throw new System.ArgumentNullException("LdapIdentitySourceId cannot be null"); }
            if (FilterValue == null) { throw new System.ArgumentNullException("FilterValue cannot be null"); }
            StringBuilder SearchLdapIdentitySourceServiceURL = new StringBuilder("/aaa/ldap-identity-sources/{ldap-identity-source-id}/search");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            SearchLdapIdentitySourceServiceURL.Replace("{ldap-identity-source-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapIdentitySourceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (FilterValue != null) { request.AddQueryParameter("filter_value", FilterValue.ToString()); }
            request.Resource = SearchLdapIdentitySourceServiceURL.ToString();
            RestResponse<NSXTLdapIdentitySourceSearchResultListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLdapIdentitySourceSearchResultListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SearchLdapIdentitySourceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
