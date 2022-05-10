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
    public class ClusterControlPlane
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterControlPlane(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterControlPlaneType> CreateOrUpdateClusterControlPlane(string SiteId, string EnforcementpointId, string ClusterControlPlaneId, NSXTClusterControlPlaneType ClusterControlPlane)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            if (ClusterControlPlane == null) { throw new System.ArgumentNullException("ClusterControlPlane cannot be null"); }
            StringBuilder CreateOrUpdateClusterControlPlaneServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateClusterControlPlaneServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateClusterControlPlaneServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateClusterControlPlaneServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ClusterControlPlane);
            request.Resource = CreateOrUpdateClusterControlPlaneServiceURL.ToString();
            RestResponse<NSXTClusterControlPlaneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterControlPlaneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateClusterControlPlaneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterControlPlaneType> GetClusterControlPlane(string SiteId, string EnforcementpointId, string ClusterControlPlaneId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            StringBuilder GetClusterControlPlaneServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetClusterControlPlaneServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetClusterControlPlaneServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetClusterControlPlaneServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetClusterControlPlaneServiceURL.ToString();
            RestResponse<NSXTClusterControlPlaneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterControlPlaneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetClusterControlPlaneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteClusterControlPlane(string SiteId, string EnforcementpointId, string ClusterControlPlaneId, bool? Cascade = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (ClusterControlPlaneId == null) { throw new System.ArgumentNullException("ClusterControlPlaneId cannot be null"); }
            StringBuilder DeleteClusterControlPlaneServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes/{cluster-control-plane-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteClusterControlPlaneServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteClusterControlPlaneServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteClusterControlPlaneServiceURL.Replace("{cluster-control-plane-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterControlPlaneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteClusterControlPlaneServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteClusterControlPlaneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterControlPlaneListResultType> ListClusterControlPlane(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListClusterControlPlaneServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/cluster-control-planes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListClusterControlPlaneServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListClusterControlPlaneServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListClusterControlPlaneServiceURL.ToString();
            RestResponse<NSXTClusterControlPlaneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterControlPlaneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListClusterControlPlaneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
