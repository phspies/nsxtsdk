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
    public class PolicyOperations
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyOperations(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortMirroringInstanceType> CreateOrReplacePortMirroringInstance(string DomainId, string GroupId, string PortMirroringInstanceId, NSXTPortMirroringInstanceType PortMirroringInstance)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (PortMirroringInstanceId == null) { throw new System.ArgumentNullException("PortMirroringInstanceId cannot be null"); }
            if (PortMirroringInstance == null) { throw new System.ArgumentNullException("PortMirroringInstance cannot be null"); }
            StringBuilder CreateOrReplacePortMirroringInstanceServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/port-mirroring-instances/{port-mirroring-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePortMirroringInstanceServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePortMirroringInstanceServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePortMirroringInstanceServiceURL.Replace("{port-mirroring-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringInstance);
            request.Resource = CreateOrReplacePortMirroringInstanceServiceURL.ToString();
            RestResponse<NSXTPortMirroringInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePortMirroringInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePortMirroringInstance(string DomainId, string GroupId, string PortMirroringInstanceId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (PortMirroringInstanceId == null) { throw new System.ArgumentNullException("PortMirroringInstanceId cannot be null"); }
            StringBuilder DeletePortMirroringInstanceServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/port-mirroring-instances/{port-mirroring-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePortMirroringInstanceServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortMirroringInstanceServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePortMirroringInstanceServiceURL.Replace("{port-mirroring-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePortMirroringInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePortMirroringInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPortMirroringInstance(string DomainId, string GroupId, string PortMirroringInstanceId, NSXTPortMirroringInstanceType PortMirroringInstance)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (PortMirroringInstanceId == null) { throw new System.ArgumentNullException("PortMirroringInstanceId cannot be null"); }
            if (PortMirroringInstance == null) { throw new System.ArgumentNullException("PortMirroringInstance cannot be null"); }
            StringBuilder PatchPortMirroringInstanceServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/port-mirroring-instances/{port-mirroring-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPortMirroringInstanceServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortMirroringInstanceServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPortMirroringInstanceServiceURL.Replace("{port-mirroring-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PortMirroringInstance);
            request.Resource = PatchPortMirroringInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPortMirroringInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringInstanceType> ReadPortMirroringInstance(string DomainId, string GroupId, string PortMirroringInstanceId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (PortMirroringInstanceId == null) { throw new System.ArgumentNullException("PortMirroringInstanceId cannot be null"); }
            StringBuilder ReadPortMirroringInstanceServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/port-mirroring-instances/{port-mirroring-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPortMirroringInstanceServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPortMirroringInstanceServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPortMirroringInstanceServiceURL.Replace("{port-mirroring-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PortMirroringInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPortMirroringInstanceServiceURL.ToString();
            RestResponse<NSXTPortMirroringInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPortMirroringInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPortMirroringInstanceListResultType> ListPortMirroringInstances(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListPortMirroringInstancesServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/port-mirroring-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPortMirroringInstancesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPortMirroringInstancesServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPortMirroringInstancesServiceURL.ToString();
            RestResponse<NSXTPortMirroringInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortMirroringInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPortMirroringInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
