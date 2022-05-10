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
    public class PolicyAntreaMonitoring
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyAntreaMonitoring(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAntreaHeartbeatConfigType> UpdateAntreaHeartbeatConfig(string SiteId, string EnforcementpointId, string ClusterControlPlaneId, NSXTAntreaHeartbeatConfigType AntreaHeartbeatConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            if (AntreaHeartbeatConfig == null) { throw new System.ArgumentNullException("AntreaHeartbeatConfig cannot be null"); }
            StringBuilder UpdateAntreaHeartbeatConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}/heartbeat-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAntreaHeartbeatConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateAntreaHeartbeatConfigServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateAntreaHeartbeatConfigServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AntreaHeartbeatConfig);
            request.Resource = UpdateAntreaHeartbeatConfigServiceURL.ToString();
            RestResponse<NSXTAntreaHeartbeatConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaHeartbeatConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAntreaHeartbeatConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaHeartbeatConfigType> ReadAntreaHeartbeatConfig(string SiteId, string EnforcementpointId, string ClusterControlPlaneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            StringBuilder ReadAntreaHeartbeatConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}/heartbeat-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAntreaHeartbeatConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAntreaHeartbeatConfigServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAntreaHeartbeatConfigServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAntreaHeartbeatConfigServiceURL.ToString();
            RestResponse<NSXTAntreaHeartbeatConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaHeartbeatConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAntreaHeartbeatConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAntreaHeartbeatConfig(string SiteId, string EnforcementpointId, string ClusterControlPlaneId, NSXTAntreaHeartbeatConfigType AntreaHeartbeatConfig)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            if (AntreaHeartbeatConfig == null) { throw new System.ArgumentNullException("AntreaHeartbeatConfig cannot be null"); }
            StringBuilder PatchAntreaHeartbeatConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}/heartbeat-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAntreaHeartbeatConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchAntreaHeartbeatConfigServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchAntreaHeartbeatConfigServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AntreaHeartbeatConfig);
            request.Resource = PatchAntreaHeartbeatConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAntreaHeartbeatConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaHeartbeatConfigListResultType> ListAntreaHeartbeatConfig(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListAntreaHeartbeatConfigServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes-heartbeat-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListAntreaHeartbeatConfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListAntreaHeartbeatConfigServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAntreaHeartbeatConfigServiceURL.ToString();
            RestResponse<NSXTAntreaHeartbeatConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaHeartbeatConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAntreaHeartbeatConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaClusterListResultType> ListAntreaStatus(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListAntreaStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListAntreaStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListAntreaStatusServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAntreaStatusServiceURL.ToString();
            RestResponse<NSXTAntreaClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAntreaStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAntreaClusterInfoType> ReadAntreaStatus(string SiteId, string EnforcementpointId, string ClusterControlPlaneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            StringBuilder ReadAntreaStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAntreaStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAntreaStatusServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAntreaStatusServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAntreaStatusServiceURL.ToString();
            RestResponse<NSXTAntreaClusterInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAntreaClusterInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAntreaStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
