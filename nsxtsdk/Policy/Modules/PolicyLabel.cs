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
    public class PolicyLabel
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyLabel(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyLabelType> CreateOrReplacePolicyLabelForInfra(string LabelId, NSXTPolicyLabelType PolicyLabel)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            if (PolicyLabel == null) { throw new System.ArgumentNullException("PolicyLabel cannot be null"); }
            StringBuilder CreateOrReplacePolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyLabel);
            request.Resource = CreateOrReplacePolicyLabelForInfraServiceURL.ToString();
            RestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdatePolicyLabelForInfra(string LabelId, NSXTPolicyLabelType PolicyLabel)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            if (PolicyLabel == null) { throw new System.ArgumentNullException("PolicyLabel cannot be null"); }
            StringBuilder UpdatePolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdatePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyLabel);
            request.Resource = UpdatePolicyLabelForInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdatePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelType> ReadPolicyLabelForInfra(string LabelId)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            StringBuilder ReadPolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyLabelForInfraServiceURL.ToString();
            RestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyLabelForInfra(string LabelId)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            StringBuilder DeletePolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyLabelForInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelType> GlobalGlobalInfraReadPolicyLabelForInfra(string LabelId)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            StringBuilder GlobalInfraReadPolicyLabelForInfraServiceURL = new StringBuilder("/global-infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPolicyLabelForInfraServiceURL.ToString();
            RestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelListResultType> ListPolicyLabelForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels");
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
            request.Resource = ListPolicyLabelForInfraServiceURL.ToString();
            RestResponse<NSXTPolicyLabelListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelListResultType> GlobalGlobalInfraListPolicyLabelForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyLabelForInfraServiceURL = new StringBuilder("/global-infra/labels");
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
            request.Resource = GlobalInfraListPolicyLabelForInfraServiceURL.ToString();
            RestResponse<NSXTPolicyLabelListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
