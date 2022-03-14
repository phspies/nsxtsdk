// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public AAA(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
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
            NSXTRoleWithFeaturesType returnValue = default(NSXTRoleWithFeaturesType);
            StringBuilder CreateOrUpdateRoleServiceURL = new StringBuilder("/aaa/roles/{role}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdateRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(RoleWithFeatures, defaultSerializationSettings));
            request.Resource = CreateOrUpdateRoleServiceURL.ToString();
            IRestResponse<NSXTRoleWithFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdateRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRoleServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleWithFeaturesType> GetRoleInfo(string Role)
        {
            if (Role == null) { throw new System.ArgumentNullException("Role cannot be null"); }
            NSXTRoleWithFeaturesType returnValue = default(NSXTRoleWithFeaturesType);
            StringBuilder GetRoleInfoServiceURL = new StringBuilder("/aaa/roles/{role}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetRoleInfoServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRoleInfoServiceURL.ToString();
            IRestResponse<NSXTRoleWithFeaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetRoleInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTVidmInfoListResultType returnValue = default(NSXTVidmInfoListResultType);
            StringBuilder GetGroupVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetGroupVidmSearchResultServiceURL.ToString();
            IRestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetGroupVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTNewRoleType returnValue = default(NSXTNewRoleType);
            StringBuilder CloneRoleServiceURL = new StringBuilder("/aaa/roles/{role}?action=clone");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            CloneRoleServiceURL.Replace("{role}", System.Uri.EscapeDataString(Helpers.ConvertToString(Role, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(NewRole, defaultSerializationSettings));
            request.Resource = CloneRoleServiceURL.ToString();
            IRestResponse<NSXTNewRoleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNewRoleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CloneRoleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTRecommendedFeaturePermissionListResultType returnValue = default(NSXTRecommendedFeaturePermissionListResultType);
            StringBuilder ValidateAndRecommendPermissionsServiceURL = new StringBuilder("/aaa/roles?action=validate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(FeaturePermissionArray, defaultSerializationSettings));
            request.Resource = ValidateAndRecommendPermissionsServiceURL.ToString();
            IRestResponse<NSXTRecommendedFeaturePermissionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRecommendedFeaturePermissionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ValidateAndRecommendPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTVidmInfoListResultType returnValue = default(NSXTVidmInfoListResultType);
            StringBuilder GetUserVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/users");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetUserVidmSearchResultServiceURL.ToString();
            IRestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetUserVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUserInfoType> GetCurrentUserInfo(string? RootPath = null)
        {
            NSXTUserInfoType returnValue = default(NSXTUserInfoType);
            StringBuilder GetCurrentUserInfoServiceURL = new StringBuilder("/aaa/user-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (RootPath != null) { request.AddQueryParameter("root_path", RootPath.ToString()); }
            request.Resource = GetCurrentUserInfoServiceURL.ToString();
            IRestResponse<NSXTUserInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUserInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetCurrentUserInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTVidmInfoListResultType returnValue = default(NSXTVidmInfoListResultType);
            StringBuilder GetVidmSearchResultServiceURL = new StringBuilder("/aaa/vidm/search");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchString != null) { request.AddQueryParameter("search_string", SearchString.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetVidmSearchResultServiceURL.ToString();
            IRestResponse<NSXTVidmInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVidmInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + GetVidmSearchResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFeaturePermissionListResultType> ListFeatures()
        {
            NSXTFeaturePermissionListResultType returnValue = default(NSXTFeaturePermissionListResultType);
            StringBuilder ListFeaturesServiceURL = new StringBuilder("/aaa/features-with-properties");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListFeaturesServiceURL.ToString();
            IRestResponse<NSXTFeaturePermissionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFeaturePermissionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListFeaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleWithFeaturesListResultType> ListRolesInfo(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTRoleWithFeaturesListResultType returnValue = default(NSXTRoleWithFeaturesListResultType);
            StringBuilder ListRolesInfoServiceURL = new StringBuilder("/aaa/roles-with-feature-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRolesInfoServiceURL.ToString();
            IRestResponse<NSXTRoleWithFeaturesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleWithFeaturesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListRolesInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTRoleBindingType returnValue = default(NSXTRoleBindingType);
            StringBuilder UpdateRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateRoleBindingServiceURL.Replace("{binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(RoleBinding, defaultSerializationSettings));
            request.Resource = UpdateRoleBindingServiceURL.ToString();
            IRestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
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
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingType> GetRoleBinding(string BindingId, string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            if (BindingId == null) { throw new System.ArgumentNullException("BindingId cannot be null"); }
            NSXTRoleBindingType returnValue = default(NSXTRoleBindingType);
            StringBuilder GetRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings/{binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
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
            IRestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
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
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + DeleteAllStaleRoleBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleListResultType> GetAllRolesInfo()
        {
            NSXTRoleListResultType returnValue = default(NSXTRoleListResultType);
            StringBuilder GetAllRolesInfoServiceURL = new StringBuilder("/aaa/roles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetAllRolesInfoServiceURL.ToString();
            IRestResponse<NSXTRoleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAllRolesInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTRoleBindingType returnValue = default(NSXTRoleBindingType);
            StringBuilder CreateRoleBindingServiceURL = new StringBuilder("/aaa/role-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(RoleBinding, defaultSerializationSettings));
            request.Resource = CreateRoleBindingServiceURL.ToString();
            IRestResponse<NSXTRoleBindingType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateRoleBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoleBindingListResultType> GetAllRoleBindings(string? Cursor = null, string? IdentitySourceId = null, string? IdentitySourceType = null, string? IncludedFields = null, string? Name = null, long? PageSize = null, string? Role = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            NSXTRoleBindingListResultType returnValue = default(NSXTRoleBindingListResultType);
            StringBuilder GetAllRoleBindingsServiceURL = new StringBuilder("/aaa/role-bindings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
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
            IRestResponse<NSXTRoleBindingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoleBindingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetAllRoleBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
