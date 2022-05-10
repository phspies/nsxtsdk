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
    public class PolicyOspf
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyOspf(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTOspfAreaConfigType> CreateOrReplaceOspfAreaConfig(string Tier0Id, string LocaleServiceId, string AreaId, NSXTOspfAreaConfigType OspfAreaConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (AreaId == null) { throw new System.ArgumentNullException("AreaId cannot be null"); }
            if (OspfAreaConfig == null) { throw new System.ArgumentNullException("OspfAreaConfig cannot be null"); }
            StringBuilder CreateOrReplaceOspfAreaConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/areas/{area-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceOspfAreaConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceOspfAreaConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceOspfAreaConfigServiceURL.Replace("{area-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AreaId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(OspfAreaConfig);
            request.Resource = CreateOrReplaceOspfAreaConfigServiceURL.ToString();
            RestResponse<NSXTOspfAreaConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfAreaConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceOspfAreaConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfAreaConfigType> PatchOspfAreaConfig(string Tier0Id, string LocaleServiceId, string AreaId, NSXTOspfAreaConfigType OspfAreaConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (AreaId == null) { throw new System.ArgumentNullException("AreaId cannot be null"); }
            if (OspfAreaConfig == null) { throw new System.ArgumentNullException("OspfAreaConfig cannot be null"); }
            StringBuilder PatchOspfAreaConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/areas/{area-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchOspfAreaConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchOspfAreaConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchOspfAreaConfigServiceURL.Replace("{area-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AreaId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(OspfAreaConfig);
            request.Resource = PatchOspfAreaConfigServiceURL.ToString();
            RestResponse<NSXTOspfAreaConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfAreaConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchOspfAreaConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfAreaConfigType> ReadOspfAreaConfig(string Tier0Id, string LocaleServiceId, string AreaId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (AreaId == null) { throw new System.ArgumentNullException("AreaId cannot be null"); }
            StringBuilder ReadOspfAreaConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/areas/{area-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadOspfAreaConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadOspfAreaConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadOspfAreaConfigServiceURL.Replace("{area-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AreaId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadOspfAreaConfigServiceURL.ToString();
            RestResponse<NSXTOspfAreaConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfAreaConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadOspfAreaConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteOspfAreaConfig(string Tier0Id, string LocaleServiceId, string AreaId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (AreaId == null) { throw new System.ArgumentNullException("AreaId cannot be null"); }
            StringBuilder DeleteOspfAreaConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/areas/{area-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteOspfAreaConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteOspfAreaConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteOspfAreaConfigServiceURL.Replace("{area-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AreaId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteOspfAreaConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteOspfAreaConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfAreaConfigListResultType> ListPolicyOspfAreaConfig(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListPolicyOspfAreaConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf/areas");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyOspfAreaConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyOspfAreaConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyOspfAreaConfigServiceURL.ToString();
            RestResponse<NSXTOspfAreaConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfAreaConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyOspfAreaConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfRoutingConfigType> CreateOrReplaceOspfRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTOspfRoutingConfigType OspfRoutingConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (OspfRoutingConfig == null) { throw new System.ArgumentNullException("OspfRoutingConfig cannot be null"); }
            StringBuilder CreateOrReplaceOspfRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceOspfRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceOspfRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(OspfRoutingConfig);
            request.Resource = CreateOrReplaceOspfRoutingConfigServiceURL.ToString();
            RestResponse<NSXTOspfRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceOspfRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfRoutingConfigType> PatchOspfRoutingConfig(string Tier0Id, string LocaleServiceId, NSXTOspfRoutingConfigType OspfRoutingConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (OspfRoutingConfig == null) { throw new System.ArgumentNullException("OspfRoutingConfig cannot be null"); }
            StringBuilder PatchOspfRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchOspfRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchOspfRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(OspfRoutingConfig);
            request.Resource = PatchOspfRoutingConfigServiceURL.ToString();
            RestResponse<NSXTOspfRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchOspfRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOspfRoutingConfigType> ReadOspfRoutingConfig(string Tier0Id, string LocaleServiceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadOspfRoutingConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ospf");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadOspfRoutingConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadOspfRoutingConfigServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadOspfRoutingConfigServiceURL.ToString();
            RestResponse<NSXTOspfRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOspfRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadOspfRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
