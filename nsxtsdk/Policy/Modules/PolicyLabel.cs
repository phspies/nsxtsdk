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
    public class PolicyLabel
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyLabel(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

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
        public async Task<NSXTPolicyLabelType> CreateOrReplacePolicyLabelForInfra(string LabelId, NSXTPolicyLabelType PolicyLabel)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            if (PolicyLabel == null) { throw new System.ArgumentNullException("PolicyLabel cannot be null"); }
            NSXTPolicyLabelType returnValue = default(NSXTPolicyLabelType);
            StringBuilder CreateOrReplacePolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplacePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyLabel, defaultSerializationSettings));
            request.Resource = CreateOrReplacePolicyLabelForInfraServiceURL.ToString();
            IRestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplacePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyLabel, defaultSerializationSettings));
            request.Resource = UpdatePolicyLabelForInfraServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + UpdatePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelType> ReadPolicyLabelForInfra(string LabelId)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            NSXTPolicyLabelType returnValue = default(NSXTPolicyLabelType);
            StringBuilder ReadPolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyLabelForInfraServiceURL.ToString();
            IRestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyLabelForInfraServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelType> GlobalGlobalInfraReadPolicyLabelForInfra(string LabelId)
        {
            if (LabelId == null) { throw new System.ArgumentNullException("LabelId cannot be null"); }
            NSXTPolicyLabelType returnValue = default(NSXTPolicyLabelType);
            StringBuilder GlobalInfraReadPolicyLabelForInfraServiceURL = new StringBuilder("/global-infra/labels/{label-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraReadPolicyLabelForInfraServiceURL.Replace("{label-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LabelId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPolicyLabelForInfraServiceURL.ToString();
            IRestResponse<NSXTPolicyLabelType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraReadPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelListResultType> ListPolicyLabelForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyLabelListResultType returnValue = default(NSXTPolicyLabelListResultType);
            StringBuilder ListPolicyLabelForInfraServiceURL = new StringBuilder("/infra/labels");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyLabelForInfraServiceURL.ToString();
            IRestResponse<NSXTPolicyLabelListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyLabelListResultType> GlobalGlobalInfraListPolicyLabelForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyLabelListResultType returnValue = default(NSXTPolicyLabelListResultType);
            StringBuilder GlobalInfraListPolicyLabelForInfraServiceURL = new StringBuilder("/global-infra/labels");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyLabelForInfraServiceURL.ToString();
            IRestResponse<NSXTPolicyLabelListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyLabelListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListPolicyLabelForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
