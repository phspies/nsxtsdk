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
    public class SystemHealthPlugin
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SystemHealthPlugin(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSystemHealthPluginProfileType> CreateSystemHealthPlugin(NSXTSystemHealthPluginProfileType SystemHealthPluginProfile)
        {
            if (SystemHealthPluginProfile == null) { throw new System.ArgumentNullException("SystemHealthPluginProfile cannot be null"); }
            StringBuilder CreateSystemHealthPluginServiceURL = new StringBuilder("/systemhealth/plugins");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SystemHealthPluginProfile);
            request.Resource = CreateSystemHealthPluginServiceURL.ToString();
            RestResponse<NSXTSystemHealthPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSystemHealthPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSystemHealthPluginProfileListType> ListAllSystemHealthPlugins(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAllSystemHealthPluginsServiceURL = new StringBuilder("/systemhealth/plugins");
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
            request.Resource = ListAllSystemHealthPluginsServiceURL.ToString();
            RestResponse<NSXTSystemHealthPluginProfileListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthPluginProfileListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllSystemHealthPluginsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSystemHealthPluginProfileType> ShowSystemHealthPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder ShowSystemHealthPluginServiceURL = new StringBuilder("/systemhealth/plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowSystemHealthPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowSystemHealthPluginServiceURL.ToString();
            RestResponse<NSXTSystemHealthPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowSystemHealthPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSystemHealthPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder DeleteSystemHealthPluginServiceURL = new StringBuilder("/systemhealth/plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSystemHealthPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSystemHealthPluginServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSystemHealthPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPluginFilePropertiesType> CreatePluginFile(string FileName, string PluginId)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder CreatePluginFileServiceURL = new StringBuilder("/systemhealth/plugins/{plugin-id}/files/{file-name}/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreatePluginFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            CreatePluginFileServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CreatePluginFileServiceURL.ToString();
            RestResponse<NSXTPluginFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPluginFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePluginFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPluginStatusListType> ShowSystemHealthPluginOnNode(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ShowSystemHealthPluginOnNodeServiceURL = new StringBuilder("/systemhealth/plugins/status/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowSystemHealthPluginOnNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowSystemHealthPluginOnNodeServiceURL.ToString();
            RestResponse<NSXTPluginStatusListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPluginStatusListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowSystemHealthPluginOnNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
