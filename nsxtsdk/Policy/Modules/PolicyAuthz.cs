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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyAuthz(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task DeleteObjectPermissions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, bool? InheritanceDisabled = null, long? PageSize = null, string? PathPrefix = null, string? RoleName = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder DeleteObjectPermissionsServiceURL = new StringBuilder("/aaa/object-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
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
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
                Method = Method.Patch
            };
            request.AddJsonBody(ObjectRolePermissionGroup);
            request.Resource = UpdateObjectPermissionsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTObjectRolePermissionGroupListResultType> GetObjectPermissions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, bool? InheritanceDisabled = null, long? PageSize = null, string? PathPrefix = null, string? RoleName = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetObjectPermissionsServiceURL = new StringBuilder("/aaa/object-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
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
            RestResponse<NSXTObjectRolePermissionGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTObjectRolePermissionGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetObjectPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
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
            StringBuilder GetPathPermissionsServiceURL = new StringBuilder("/aaa/effective-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (FeatureName != null) { request.AddQueryParameter("feature_name", FeatureName.ToString()); }
            if (ObjectPath != null) { request.AddQueryParameter("object_path", ObjectPath.ToString()); }
            request.Resource = GetPathPermissionsServiceURL.ToString();
            RestResponse<NSXTPathPermissionGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPathPermissionGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPathPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
