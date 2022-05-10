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
    public class PolicyConstraints
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyConstraints(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTConstraintListResultType> GlobalGlobalInfraListTenantConstraints(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListTenantConstraintsServiceURL = new StringBuilder("/global-infra/constraints");
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
            request.Resource = GlobalInfraListTenantConstraintsServiceURL.ToString();
            RestResponse<NSXTConstraintListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConstraintListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTenantConstraintsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConstraintType> CreateOrReplaceTenantConstraint(string ConstraintId, NSXTConstraintType Constraint)
        {
            if (ConstraintId == null) { throw new System.ArgumentNullException("ConstraintId cannot be null"); }
            if (Constraint == null) { throw new System.ArgumentNullException("Constraint cannot be null"); }
            StringBuilder CreateOrReplaceTenantConstraintServiceURL = new StringBuilder("/infra/constraints/{constraint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTenantConstraintServiceURL.Replace("{constraint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConstraintId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Constraint);
            request.Resource = CreateOrReplaceTenantConstraintServiceURL.ToString();
            RestResponse<NSXTConstraintType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConstraintType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTenantConstraintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTenantConstraint(string ConstraintId)
        {
            if (ConstraintId == null) { throw new System.ArgumentNullException("ConstraintId cannot be null"); }
            StringBuilder DeleteTenantConstraintServiceURL = new StringBuilder("/infra/constraints/{constraint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTenantConstraintServiceURL.Replace("{constraint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConstraintId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTenantConstraintServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTenantConstraintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTenantConstraint(string ConstraintId, NSXTConstraintType Constraint)
        {
            if (ConstraintId == null) { throw new System.ArgumentNullException("ConstraintId cannot be null"); }
            if (Constraint == null) { throw new System.ArgumentNullException("Constraint cannot be null"); }
            StringBuilder PatchTenantConstraintServiceURL = new StringBuilder("/infra/constraints/{constraint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTenantConstraintServiceURL.Replace("{constraint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConstraintId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Constraint);
            request.Resource = PatchTenantConstraintServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTenantConstraintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConstraintType> ReadTenantConstraint(string ConstraintId)
        {
            if (ConstraintId == null) { throw new System.ArgumentNullException("ConstraintId cannot be null"); }
            StringBuilder ReadTenantConstraintServiceURL = new StringBuilder("/infra/constraints/{constraint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTenantConstraintServiceURL.Replace("{constraint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConstraintId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTenantConstraintServiceURL.ToString();
            RestResponse<NSXTConstraintType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConstraintType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTenantConstraintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConstraintListResultType> ListTenantConstraints(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTenantConstraintsServiceURL = new StringBuilder("/infra/constraints");
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
            request.Resource = ListTenantConstraintsServiceURL.ToString();
            RestResponse<NSXTConstraintListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConstraintListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTenantConstraintsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConstraintType> GlobalGlobalInfraReadTenantConstraint(string ConstraintId)
        {
            if (ConstraintId == null) { throw new System.ArgumentNullException("ConstraintId cannot be null"); }
            StringBuilder GlobalInfraReadTenantConstraintServiceURL = new StringBuilder("/global-infra/constraints/{constraint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTenantConstraintServiceURL.Replace("{constraint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConstraintId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTenantConstraintServiceURL.ToString();
            RestResponse<NSXTConstraintType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConstraintType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTenantConstraintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
