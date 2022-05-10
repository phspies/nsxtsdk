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
    public class AggSvcInterSite
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcInterSite(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBgpNeighborRouteDetailsType> GetInterSiteEdgeNodeBgpNeighborRoutes(string EdgeNodeId, string NeighborId)
        {
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetInterSiteEdgeNodeBgpNeighborRoutesServiceURL = new StringBuilder("/transport-nodes/{edge-node-id}/inter-site/bgp/neighbors/{neighbor-id}/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInterSiteEdgeNodeBgpNeighborRoutesServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInterSiteEdgeNodeBgpNeighborRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInterSiteEdgeNodeBgpNeighborRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInterSiteEdgeNodeBgpNeighborRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterSiteBgpSummaryType> GetInterSiteEdgeNodeBgpSummary(string EdgeNodeId)
        {
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            StringBuilder GetInterSiteEdgeNodeBgpSummaryServiceURL = new StringBuilder("/transport-nodes/{edge-node-id}/inter-site/bgp/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInterSiteEdgeNodeBgpSummaryServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInterSiteEdgeNodeBgpSummaryServiceURL.ToString();
            RestResponse<NSXTInterSiteBgpSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterSiteBgpSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInterSiteEdgeNodeBgpSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborRouteDetailsType> GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutes(string EdgeNodeId, string NeighborId)
        {
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            if (NeighborId == null) { throw new System.ArgumentNullException("NeighborId cannot be null"); }
            StringBuilder GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutesServiceURL = new StringBuilder("/transport-nodes/{edge-node-id}/inter-site/bgp/neighbors/{neighbor-id}/advertised-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutesServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutesServiceURL.Replace("{neighbor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NeighborId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutesServiceURL.ToString();
            RestResponse<NSXTBgpNeighborRouteDetailsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborRouteDetailsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInterSiteEdgeNodeBgpNeighborAdvertisedRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterSiteStatisticsType> GetInterSiteEdgeNodeStatistics(string EdgeNodeId)
        {
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            StringBuilder GetInterSiteEdgeNodeStatisticsServiceURL = new StringBuilder("/transport-nodes/{edge-node-id}/inter-site/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInterSiteEdgeNodeStatisticsServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInterSiteEdgeNodeStatisticsServiceURL.ToString();
            RestResponse<NSXTNodeInterSiteStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterSiteStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInterSiteEdgeNodeStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborListResultType> ListInterSiteEdgeNodeBgpNeighbors(string EdgeNodeId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            StringBuilder ListInterSiteEdgeNodeBgpNeighborsServiceURL = new StringBuilder("/transport-nodes/{edge-node-id}/inter-site/bgp/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInterSiteEdgeNodeBgpNeighborsServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListInterSiteEdgeNodeBgpNeighborsServiceURL.ToString();
            RestResponse<NSXTBgpNeighborListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInterSiteEdgeNodeBgpNeighborsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
