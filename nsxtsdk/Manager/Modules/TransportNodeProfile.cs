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
    public class TransportNodeProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportNodeProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTransportNodeProfileType> UpdateTransportNodeProfile(string TransportNodeProfileId, NSXTTransportNodeProfileType TransportNodeProfile, string? EsxMgmtIfMigrationDest = null, string? IfId = null, string? PingIp = null, bool? SkipValidation = null, string? Vnic = null, string? VnicMigrationDest = null)
        {
            if (TransportNodeProfileId == null) { throw new System.ArgumentNullException("TransportNodeProfileId cannot be null"); }
            if (TransportNodeProfile == null) { throw new System.ArgumentNullException("TransportNodeProfile cannot be null"); }
            StringBuilder UpdateTransportNodeProfileServiceURL = new StringBuilder("/transport-node-profiles/{transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTransportNodeProfileServiceURL.Replace("{transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportNodeProfile);
            if (EsxMgmtIfMigrationDest != null) { request.AddQueryParameter("esx_mgmt_if_migration_dest", EsxMgmtIfMigrationDest.ToString()); }
            if (IfId != null) { request.AddQueryParameter("if_id", IfId.ToString()); }
            if (PingIp != null) { request.AddQueryParameter("ping_ip", PingIp.ToString()); }
            if (SkipValidation != null) { request.AddQueryParameter("skip_validation", SkipValidation.ToString()); }
            if (Vnic != null) { request.AddQueryParameter("vnic", Vnic.ToString()); }
            if (VnicMigrationDest != null) { request.AddQueryParameter("vnic_migration_dest", VnicMigrationDest.ToString()); }
            request.Resource = UpdateTransportNodeProfileServiceURL.ToString();
            RestResponse<NSXTTransportNodeProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportNodeProfile(string TransportNodeProfileId)
        {
            if (TransportNodeProfileId == null) { throw new System.ArgumentNullException("TransportNodeProfileId cannot be null"); }
            StringBuilder DeleteTransportNodeProfileServiceURL = new StringBuilder("/transport-node-profiles/{transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportNodeProfileServiceURL.Replace("{transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportNodeProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeProfileType> GetTransportNodeProfile(string TransportNodeProfileId)
        {
            if (TransportNodeProfileId == null) { throw new System.ArgumentNullException("TransportNodeProfileId cannot be null"); }
            StringBuilder GetTransportNodeProfileServiceURL = new StringBuilder("/transport-node-profiles/{transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeProfileServiceURL.Replace("{transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeProfileServiceURL.ToString();
            RestResponse<NSXTTransportNodeProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeProfileType> CreateTransportNodeProfile(NSXTTransportNodeProfileType TransportNodeProfile)
        {
            if (TransportNodeProfile == null) { throw new System.ArgumentNullException("TransportNodeProfile cannot be null"); }
            StringBuilder CreateTransportNodeProfileServiceURL = new StringBuilder("/transport-node-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TransportNodeProfile);
            request.Resource = CreateTransportNodeProfileServiceURL.ToString();
            RestResponse<NSXTTransportNodeProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeProfileListResultType> ListTransportNodeProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTransportNodeProfilesServiceURL = new StringBuilder("/transport-node-profiles");
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
            request.Resource = ListTransportNodeProfilesServiceURL.ToString();
            RestResponse<NSXTTransportNodeProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
