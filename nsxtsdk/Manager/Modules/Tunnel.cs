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
    public class Tunnel
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Tunnel(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTunnelListType> QueryTunnels(string NodeId, string? BfdDiagnosticCode = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? RemoteNodeId = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Status = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder QueryTunnelsServiceURL = new StringBuilder("/transport-nodes/{node-id}/tunnels");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            QueryTunnelsServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BfdDiagnosticCode != null) { request.AddQueryParameter("bfd_diagnostic_code", BfdDiagnosticCode.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RemoteNodeId != null) { request.AddQueryParameter("remote_node_id", RemoteNodeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = QueryTunnelsServiceURL.ToString();
            RestResponse<NSXTTunnelListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTunnelListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + QueryTunnelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTunnelPropertiesType> GetTunnel(string NodeId, string TunnelName, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (TunnelName == null) { throw new System.ArgumentNullException("TunnelName cannot be null"); }
            StringBuilder GetTunnelServiceURL = new StringBuilder("/transport-nodes/{node-id}/tunnels/{tunnel-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTunnelServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTunnelServiceURL.Replace("{tunnel-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(TunnelName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTunnelServiceURL.ToString();
            RestResponse<NSXTTunnelPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTunnelPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTunnelServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
