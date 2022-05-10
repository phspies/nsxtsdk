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
    public class PolicySha
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySha(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTShaPluginProfileListResultType> ListShaPluginProfiles(string? AppliedToGroupPath = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? PluginPath = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListShaPluginProfilesServiceURL = new StringBuilder("/infra/sha/plugin-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedToGroupPath != null) { request.AddQueryParameter("applied_to_group_path", AppliedToGroupPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PluginPath != null) { request.AddQueryParameter("plugin_path", PluginPath.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListShaPluginProfilesServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListShaPluginProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPreDefinedPluginListResultType> ListShaPredefinedPlugins(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListShaPredefinedPluginsServiceURL = new StringBuilder("/infra/sha/pre-defined-plugins");
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
            request.Resource = ListShaPredefinedPluginsServiceURL.ToString();
            RestResponse<NSXTShaPreDefinedPluginListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPreDefinedPluginListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListShaPredefinedPluginsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPerNodeShaPluginStatusListResultType> GlobalGlobalInfraShowPluginStatusOnNode(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder GlobalInfraShowPluginStatusOnNodeServiceURL = new StringBuilder("/global-infra/sha/plugin-status/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraShowPluginStatusOnNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraShowPluginStatusOnNodeServiceURL.ToString();
            RestResponse<NSXTPerNodeShaPluginStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPerNodeShaPluginStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraShowPluginStatusOnNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPluginProfileType> CreateOrReplaceShaPluginProfile(string ShaProfileId, NSXTShaPluginProfileType ShaPluginProfile)
        {
            if (ShaProfileId == null) { throw new System.ArgumentNullException("ShaProfileId cannot be null"); }
            if (ShaPluginProfile == null) { throw new System.ArgumentNullException("ShaPluginProfile cannot be null"); }
            StringBuilder CreateOrReplaceShaPluginProfileServiceURL = new StringBuilder("/infra/sha/plugin-profiles/{sha-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceShaPluginProfileServiceURL.Replace("{sha-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ShaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ShaPluginProfile);
            request.Resource = CreateOrReplaceShaPluginProfileServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceShaPluginProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteShaPluginProfile(string ShaProfileId)
        {
            if (ShaProfileId == null) { throw new System.ArgumentNullException("ShaProfileId cannot be null"); }
            StringBuilder DeleteShaPluginProfileServiceURL = new StringBuilder("/infra/sha/plugin-profiles/{sha-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteShaPluginProfileServiceURL.Replace("{sha-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ShaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteShaPluginProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteShaPluginProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPluginProfileType> PatchShaPluginProfile(string ShaProfileId, NSXTShaPluginProfileType ShaPluginProfile)
        {
            if (ShaProfileId == null) { throw new System.ArgumentNullException("ShaProfileId cannot be null"); }
            if (ShaPluginProfile == null) { throw new System.ArgumentNullException("ShaPluginProfile cannot be null"); }
            StringBuilder PatchShaPluginProfileServiceURL = new StringBuilder("/infra/sha/plugin-profiles/{sha-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchShaPluginProfileServiceURL.Replace("{sha-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ShaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ShaPluginProfile);
            request.Resource = PatchShaPluginProfileServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchShaPluginProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPluginProfileType> ReadShaPluginProfile(string ShaProfileId)
        {
            if (ShaProfileId == null) { throw new System.ArgumentNullException("ShaProfileId cannot be null"); }
            StringBuilder ReadShaPluginProfileServiceURL = new StringBuilder("/infra/sha/plugin-profiles/{sha-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadShaPluginProfileServiceURL.Replace("{sha-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ShaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadShaPluginProfileServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadShaPluginProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPredefinedPluginType> GlobalGlobalInfraReadShaPredefinedPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder GlobalInfraReadShaPredefinedPluginServiceURL = new StringBuilder("/global-infra/sha/pre-defined-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadShaPredefinedPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadShaPredefinedPluginServiceURL.ToString();
            RestResponse<NSXTShaPredefinedPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPredefinedPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadShaPredefinedPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginType> CreateOrReplaceShaDynamicPlugin(string PluginId, NSXTShaDynamicPluginType ShaDynamicPlugin)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            if (ShaDynamicPlugin == null) { throw new System.ArgumentNullException("ShaDynamicPlugin cannot be null"); }
            StringBuilder CreateOrReplaceShaDynamicPluginServiceURL = new StringBuilder("/infra/sha/dynamic-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ShaDynamicPlugin);
            request.Resource = CreateOrReplaceShaDynamicPluginServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteShaDynamicPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder DeleteShaDynamicPluginServiceURL = new StringBuilder("/infra/sha/dynamic-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteShaDynamicPluginServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginType> PatchShaDynamicPlugin(string PluginId, NSXTShaDynamicPluginType ShaDynamicPlugin)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            if (ShaDynamicPlugin == null) { throw new System.ArgumentNullException("ShaDynamicPlugin cannot be null"); }
            StringBuilder PatchShaDynamicPluginServiceURL = new StringBuilder("/infra/sha/dynamic-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ShaDynamicPlugin);
            request.Resource = PatchShaDynamicPluginServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginType> ReadShaDynamicPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder ReadShaDynamicPluginServiceURL = new StringBuilder("/infra/sha/dynamic-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadShaDynamicPluginServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPluginProfileType> GlobalGlobalInfraReadShaPluginProfile(string ShaProfileId)
        {
            if (ShaProfileId == null) { throw new System.ArgumentNullException("ShaProfileId cannot be null"); }
            StringBuilder GlobalInfraReadShaPluginProfileServiceURL = new StringBuilder("/global-infra/sha/plugin-profiles/{sha-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadShaPluginProfileServiceURL.Replace("{sha-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ShaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadShaPluginProfileServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadShaPluginProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDynamicPluginFilePropertiesType> UploadShaDynamicPlugin(string PluginId, string FileName)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder UploadShaDynamicPluginServiceURL = new StringBuilder("/infra/sha/dynamic-plugins/{plugin-id}/files/{file-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            UploadShaDynamicPluginServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = UploadShaDynamicPluginServiceURL.ToString();
            RestResponse<NSXTDynamicPluginFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDynamicPluginFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPredefinedPluginType> ReadShaPredefinedPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder ReadShaPredefinedPluginServiceURL = new StringBuilder("/infra/sha/pre-defined-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadShaPredefinedPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadShaPredefinedPluginServiceURL.ToString();
            RestResponse<NSXTShaPredefinedPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPredefinedPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadShaPredefinedPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPerNodeShaPluginStatusListResultType> ShowPluginStatusOnNode(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ShowPluginStatusOnNodeServiceURL = new StringBuilder("/infra/sha/plugin-status/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowPluginStatusOnNodeServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowPluginStatusOnNodeServiceURL.ToString();
            RestResponse<NSXTPerNodeShaPluginStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPerNodeShaPluginStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowPluginStatusOnNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginListResultType> GlobalGlobalInfraListShaDynamicPlugins(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListShaDynamicPluginsServiceURL = new StringBuilder("/global-infra/sha/dynamic-plugins");
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
            request.Resource = GlobalInfraListShaDynamicPluginsServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListShaDynamicPluginsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginListResultType> ListShaDynamicPlugins(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListShaDynamicPluginsServiceURL = new StringBuilder("/infra/sha/dynamic-plugins");
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
            request.Resource = ListShaDynamicPluginsServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListShaDynamicPluginsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaDynamicPluginType> GlobalGlobalInfraReadShaDynamicPlugin(string PluginId)
        {
            if (PluginId == null) { throw new System.ArgumentNullException("PluginId cannot be null"); }
            StringBuilder GlobalInfraReadShaDynamicPluginServiceURL = new StringBuilder("/global-infra/sha/dynamic-plugins/{plugin-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadShaDynamicPluginServiceURL.Replace("{plugin-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PluginId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadShaDynamicPluginServiceURL.ToString();
            RestResponse<NSXTShaDynamicPluginType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaDynamicPluginType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadShaDynamicPluginServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPluginProfileListResultType> GlobalGlobalInfraListShaPluginProfiles(string? AppliedToGroupPath = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? PluginPath = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListShaPluginProfilesServiceURL = new StringBuilder("/global-infra/sha/plugin-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedToGroupPath != null) { request.AddQueryParameter("applied_to_group_path", AppliedToGroupPath.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PluginPath != null) { request.AddQueryParameter("plugin_path", PluginPath.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListShaPluginProfilesServiceURL.ToString();
            RestResponse<NSXTShaPluginProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPluginProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListShaPluginProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTShaPreDefinedPluginListResultType> GlobalGlobalInfraListShaPredefinedPlugins(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListShaPredefinedPluginsServiceURL = new StringBuilder("/global-infra/sha/pre-defined-plugins");
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
            request.Resource = GlobalInfraListShaPredefinedPluginsServiceURL.ToString();
            RestResponse<NSXTShaPreDefinedPluginListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTShaPreDefinedPluginListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListShaPredefinedPluginsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
