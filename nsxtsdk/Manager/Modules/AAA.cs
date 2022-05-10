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
    public class AAA
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AAA(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTRoleWithFeaturesType> CreateOrUpdateRole(string Role, NSXTRoleWithFeaturesType RoleWithFeatures)
        {
            if (Role == null) { throw new System.ArgumentNullException("Role cannot be null"); }
            if (RoleWithFeatures == null) { throw new System.ArgumentNullException("RoleWithFeatures cannot be null"); }
            StringBuilder CreateOrUpdateRoleServiceURL = new StringBuilder("/aaa/roles/{role}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RoleWithFeatures);
            request.Resource = CreateOrUpdateRoleServiceURL.ToString();
            RestResponse<NSXTRoleWithFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRole(string Role)
        {
            if (Role == null) { throw new System.ArgumentNullException("Role cannot be null"); }
            StringBuilder DeleteRoleServiceURL = new StringBuilder("/aaa/roles/{role}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRoleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleWithFeaturesType> GetRoleInfo(string Role)
        {
            if (Role == null) { throw new System.ArgumentNullException("Role cannot be null"); }
            StringBuilder GetRoleInfoServiceURL = new StringBuilder("/aaa/roles/{role}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRoleInfoServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRoleInfoServiceURL.ToString();
            RestResponse<NSXTRoleWithFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRoleInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVidmInfoListResultType> GetGroupVidmSearchResult(string SearchString, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SearchString == null) { throw new System.ArgumentNullException("SearchString cannot be null"); }
            StringBuilder GetGroupVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetGroupVidmSearchResultServiceURL.ToString();
            RestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNewRoleType> CloneRole(string Role, NSXTNewRoleType NewRole)
        {
            if (Role == null) { throw new System.ArgumentNullException("Role cannot be null"); }
            if (NewRole == null) { throw new System.ArgumentNullException("NewRole cannot be null"); }
            StringBuilder CloneRoleServiceURL = new StringBuilder("/aaa/roles/{role}?action=clone");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CloneRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NewRole);
            request.Resource = CloneRoleServiceURL.ToString();
            RestResponse<NSXTNewRoleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNewRoleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CloneRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRecommendedFeaturePermissionListResultType> ValidateAndRecommendPermissions(NSXTFeaturePermissionArrayType FeaturePermissionArray)
        {
            if (FeaturePermissionArray == null) { throw new System.ArgumentNullException("FeaturePermissionArray cannot be null"); }
            StringBuilder ValidateAndRecommendPermissionsServiceURL = new StringBuilder("/aaa/roles?action=validate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(FeaturePermissionArray);
            request.Resource = ValidateAndRecommendPermissionsServiceURL.ToString();
            RestResponse<NSXTRecommendedFeaturePermissionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRecommendedFeaturePermissionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ValidateAndRecommendPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVidmInfoListResultType> GetUserVidmSearchResult(string SearchString, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SearchString == null) { throw new System.ArgumentNullException("SearchString cannot be null"); }
            StringBuilder GetUserVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/users");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUserVidmSearchResultServiceURL.ToString();
            RestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUserVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUserInfoType> GetCurrentUserInfo(string? RootPath = null)
        {
            StringBuilder GetCurrentUserInfoServiceURL = new StringBuilder("/aaa/user-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (RootPath != null) { request.AddQueryParameter("root_path", RootPath.ToString()); }
            request.Resource = GetCurrentUserInfoServiceURL.ToString();
            RestResponse<NSXTUserInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUserInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCurrentUserInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVidmInfoListResultType> GetVidmSearchResult(string SearchString, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SearchString == null) { throw new System.ArgumentNullException("SearchString cannot be null"); }
            StringBuilder GetVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/search");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetVidmSearchResultServiceURL.ToString();
            RestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFeaturePermissionListResultType> ListFeatures()
        {
            StringBuilder ListFeaturesServiceURL = new StringBuilder("/aaa/features-with-properties");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListFeaturesServiceURL.ToString();
            RestResponse<NSXTFeaturePermissionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFeaturePermissionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFeaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleWithFeaturesListResultType> ListRolesInfo(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListRolesInfoServiceURL = new StringBuilder("/aaa/roles-with-feature-permissions");
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
            request.Resource = ListRolesInfoServiceURL.ToString();
            RestResponse<NSXTRoleWithFeaturesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRolesInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingType> UpdateRoleBinding(string BindingId, NSXTRoleBindingType RoleBinding)
        {
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            if (RoleBinding == null) { throw new System.ArgumentNullException("RoleBinding cannot be null"); }
            StringBuilder UpdateRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRoleBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RoleBinding);
            request.Resource = UpdateRoleBindingServiceURL.ToString();
            RestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRoleBinding(string BindingId, string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder DeleteRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRoleBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IdentitySourceId != null) { request.AddQueryParameter("identity_source_id", IdentitySourceId.ToString()); }
            if (IdentitySourceType != null) { request.AddQueryParameter("identity_source_type", IdentitySourceType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Role != null) { request.AddQueryParameter("role", Role.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = DeleteRoleBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingType> GetRoleBinding(string BindingId, string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            StringBuilder GetRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRoleBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IdentitySourceId != null) { request.AddQueryParameter("identity_source_id", IdentitySourceId.ToString()); }
            if (IdentitySourceType != null) { request.AddQueryParameter("identity_source_type", IdentitySourceType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Role != null) { request.AddQueryParameter("role", Role.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetRoleBindingServiceURL.ToString();
            RestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAllStaleRoleBindings(string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder DeleteAllStaleRoleBindingsServiceURL = new StringBuilder("/aaa/role-bindings?action=delete_stale_bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IdentitySourceId != null) { request.AddQueryParameter("identity_source_id", IdentitySourceId.ToString()); }
            if (IdentitySourceType != null) { request.AddQueryParameter("identity_source_type", IdentitySourceType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Role != null) { request.AddQueryParameter("role", Role.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = DeleteAllStaleRoleBindingsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteAllStaleRoleBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleListResultType> GetAllRolesInfo()
        {
            StringBuilder GetAllRolesInfoServiceURL = new StringBuilder("/aaa/roles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetAllRolesInfoServiceURL.ToString();
            RestResponse<NSXTRoleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllRolesInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingType> CreateRoleBinding(NSXTRoleBindingType RoleBinding)
        {
            if (RoleBinding == null) { throw new System.ArgumentNullException("RoleBinding cannot be null"); }
            StringBuilder CreateRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RoleBinding);
            request.Resource = CreateRoleBindingServiceURL.ToString();
            RestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingListResultType> GetAllRoleBindings(string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GetAllRoleBindingsServiceURL = new StringBuilder("/aaa/role-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IdentitySourceId != null) { request.AddQueryParameter("identity_source_id", IdentitySourceId.ToString()); }
            if (IdentitySourceType != null) { request.AddQueryParameter("identity_source_type", IdentitySourceType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Role != null) { request.AddQueryParameter("role", Role.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetAllRoleBindingsServiceURL.ToString();
            RestResponse<NSXTRoleBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAllRoleBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
