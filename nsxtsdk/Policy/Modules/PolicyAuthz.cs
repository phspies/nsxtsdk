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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyAuthz
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyAuthz(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

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
        public async Task DeleteObjectPermissions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, bool? InheritanceDisabled = null, long? PageSize = null, string? PathPrefix = null, string? RoleName = null, bool? SortAscending = null, string? SortBy = null)
        {
            
            StringBuilder DeleteObjectPermissionsServiceURL = new StringBuilder("/aaa/object-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InheritanceDisabled != null) { request.AddQueryParameter("inheritance_disabled", InheritanceDisabled.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PathPrefix != null) { request.AddQueryParameter("path_prefix", PathPrefix.ToString()); }
            if (RoleName != null) { request.AddQueryParameter("role_name", RoleName.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = DeleteObjectPermissionsServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdateObjectPermissions(NSXTObjectRolePermissionGroupType ObjectRolePermissionGroup)
        {
            if (ObjectRolePermissionGroup == null) { throw new System.ArgumentNullException("ObjectRolePermissionGroup cannot be null"); }
            
            StringBuilder UpdateObjectPermissionsServiceURL = new StringBuilder("/aaa/object-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(ObjectRolePermissionGroup, defaultSerializationSettings));
            request.Resource = UpdateObjectPermissionsServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + UpdateObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTObjectRolePermissionGroupListResultType> GetObjectPermissions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, bool? InheritanceDisabled = null, long? PageSize = null, string? PathPrefix = null, string? RoleName = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTObjectRolePermissionGroupListResultType returnValue = default(NSXTObjectRolePermissionGroupListResultType);
            StringBuilder GetObjectPermissionsServiceURL = new StringBuilder("/aaa/object-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InheritanceDisabled != null) { request.AddQueryParameter("inheritance_disabled", InheritanceDisabled.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PathPrefix != null) { request.AddQueryParameter("path_prefix", PathPrefix.ToString()); }
            if (RoleName != null) { request.AddQueryParameter("role_name", RoleName.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetObjectPermissionsServiceURL.ToString();
            IRestResponse<NSXTObjectRolePermissionGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTObjectRolePermissionGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPathPermissionGroupType> GetPathPermissions(string FeatureName, string ObjectPath)
        {
            if (FeatureName == null) { throw new System.ArgumentNullException("FeatureName cannot be null"); }
            if (ObjectPath == null) { throw new System.ArgumentNullException("ObjectPath cannot be null"); }
            NSXTPathPermissionGroupType returnValue = default(NSXTPathPermissionGroupType);
            StringBuilder GetPathPermissionsServiceURL = new StringBuilder("/aaa/effective-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (FeatureName != null) { request.AddQueryParameter("feature_name", FeatureName.ToString()); }
            if (ObjectPath != null) { request.AddQueryParameter("object_path", ObjectPath.ToString()); }
            request.Resource = GetPathPermissionsServiceURL.ToString();
            IRestResponse<NSXTPathPermissionGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPathPermissionGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPathPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
