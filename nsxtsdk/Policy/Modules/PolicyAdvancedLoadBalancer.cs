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
    public class PolicyAdvancedLoadBalancer
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyAdvancedLoadBalancer(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTALBServerAutoScalePolicyApiResponseType> ListAlbserverAutoScalePolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbserverAutoScalePolicyServiceURL = new StringBuilder("/infra/alb-server-auto-scale-policies");
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
            request.Resource = ListAlbserverAutoScalePolicyServiceURL.ToString();
            RestResponse<NSXTALBServerAutoScalePolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBServerAutoScalePolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbserverAutoScalePolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolType> UpdateAlbpool(string AlbPoolId, NSXTALBPoolType Albpool)
        {
            if (AlbPoolId == null) { throw new System.ArgumentNullException("AlbPoolId cannot be null"); }
            if (Albpool == null) { throw new System.ArgumentNullException("Albpool cannot be null"); }
            StringBuilder UpdateAlbpoolServiceURL = new StringBuilder("/infra/alb-pools/{alb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbpoolServiceURL.Replace("{alb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albpool);
            request.Resource = UpdateAlbpoolServiceURL.ToString();
            RestResponse<NSXTALBPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbpool(string AlbPoolId, NSXTALBPoolType Albpool)
        {
            if (AlbPoolId == null) { throw new System.ArgumentNullException("AlbPoolId cannot be null"); }
            if (Albpool == null) { throw new System.ArgumentNullException("Albpool cannot be null"); }
            StringBuilder PatchAlbpoolServiceURL = new StringBuilder("/infra/alb-pools/{alb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbpoolServiceURL.Replace("{alb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albpool);
            request.Resource = PatchAlbpoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolType> ReadAlbpool(string AlbPoolId)
        {
            if (AlbPoolId == null) { throw new System.ArgumentNullException("AlbPoolId cannot be null"); }
            StringBuilder ReadAlbpoolServiceURL = new StringBuilder("/infra/alb-pools/{alb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbpoolServiceURL.Replace("{alb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbpoolServiceURL.ToString();
            RestResponse<NSXTALBPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbpool(string AlbPoolId, bool? Force = null)
        {
            if (AlbPoolId == null) { throw new System.ArgumentNullException("AlbPoolId cannot be null"); }
            StringBuilder DeleteAlbpoolServiceURL = new StringBuilder("/infra/alb-pools/{alb-pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbpoolServiceURL.Replace("{alb-pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbpoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSecurityPolicyApiResponseType> ListAlbsecurityPolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbsecurityPolicyServiceURL = new StringBuilder("/infra/alb-security-policies");
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
            request.Resource = ListAlbsecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBSecurityPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSecurityPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbsecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWebhookApiResponseType> ListAlbwebhook(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbwebhookServiceURL = new StringBuilder("/infra/alb-webhooks");
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
            request.Resource = ListAlbwebhookServiceURL.ToString();
            RestResponse<NSXTALBWebhookApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWebhookApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbwebhookServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBTrafficCloneProfileApiResponseType> ListAlbtrafficCloneProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbtrafficCloneProfileServiceURL = new StringBuilder("/infra/alb-traffic-clone-profiles");
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
            request.Resource = ListAlbtrafficCloneProfileServiceURL.ToString();
            RestResponse<NSXTALBTrafficCloneProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBTrafficCloneProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbtrafficCloneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHardwareSecurityModuleGroupType> UpdateAlbhardwareSecurityModuleGroup(string AlbHardwaresecuritymodulegroupId, NSXTALBHardwareSecurityModuleGroupType AlbhardwareSecurityModuleGroup)
        {
            if (AlbHardwaresecuritymodulegroupId == null) { throw new System.ArgumentNullException("AlbHardwaresecuritymodulegroupId cannot be null"); }
            if (AlbhardwareSecurityModuleGroup == null) { throw new System.ArgumentNullException("AlbhardwareSecurityModuleGroup cannot be null"); }
            StringBuilder UpdateAlbhardwareSecurityModuleGroupServiceURL = new StringBuilder("/infra/alb-hardware-security-module-groups/{alb-hardwaresecuritymodulegroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbhardwareSecurityModuleGroupServiceURL.Replace("{alb-hardwaresecuritymodulegroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHardwaresecuritymodulegroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhardwareSecurityModuleGroup);
            request.Resource = UpdateAlbhardwareSecurityModuleGroupServiceURL.ToString();
            RestResponse<NSXTALBHardwareSecurityModuleGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHardwareSecurityModuleGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbhardwareSecurityModuleGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbhardwareSecurityModuleGroup(string AlbHardwaresecuritymodulegroupId, bool? Force = null)
        {
            if (AlbHardwaresecuritymodulegroupId == null) { throw new System.ArgumentNullException("AlbHardwaresecuritymodulegroupId cannot be null"); }
            StringBuilder DeleteAlbhardwareSecurityModuleGroupServiceURL = new StringBuilder("/infra/alb-hardware-security-module-groups/{alb-hardwaresecuritymodulegroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbhardwareSecurityModuleGroupServiceURL.Replace("{alb-hardwaresecuritymodulegroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHardwaresecuritymodulegroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbhardwareSecurityModuleGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbhardwareSecurityModuleGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbhardwareSecurityModuleGroup(string AlbHardwaresecuritymodulegroupId, NSXTALBHardwareSecurityModuleGroupType AlbhardwareSecurityModuleGroup)
        {
            if (AlbHardwaresecuritymodulegroupId == null) { throw new System.ArgumentNullException("AlbHardwaresecuritymodulegroupId cannot be null"); }
            if (AlbhardwareSecurityModuleGroup == null) { throw new System.ArgumentNullException("AlbhardwareSecurityModuleGroup cannot be null"); }
            StringBuilder PatchAlbhardwareSecurityModuleGroupServiceURL = new StringBuilder("/infra/alb-hardware-security-module-groups/{alb-hardwaresecuritymodulegroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbhardwareSecurityModuleGroupServiceURL.Replace("{alb-hardwaresecuritymodulegroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHardwaresecuritymodulegroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhardwareSecurityModuleGroup);
            request.Resource = PatchAlbhardwareSecurityModuleGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbhardwareSecurityModuleGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHardwareSecurityModuleGroupType> ReadAlbhardwareSecurityModuleGroup(string AlbHardwaresecuritymodulegroupId)
        {
            if (AlbHardwaresecuritymodulegroupId == null) { throw new System.ArgumentNullException("AlbHardwaresecuritymodulegroupId cannot be null"); }
            StringBuilder ReadAlbhardwareSecurityModuleGroupServiceURL = new StringBuilder("/infra/alb-hardware-security-module-groups/{alb-hardwaresecuritymodulegroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbhardwareSecurityModuleGroupServiceURL.Replace("{alb-hardwaresecuritymodulegroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHardwaresecuritymodulegroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbhardwareSecurityModuleGroupServiceURL.ToString();
            RestResponse<NSXTALBHardwareSecurityModuleGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHardwareSecurityModuleGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbhardwareSecurityModuleGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWebhookType> UpdateAlbwebhook(string AlbWebhookId, NSXTALBWebhookType Albwebhook)
        {
            if (AlbWebhookId == null) { throw new System.ArgumentNullException("AlbWebhookId cannot be null"); }
            if (Albwebhook == null) { throw new System.ArgumentNullException("Albwebhook cannot be null"); }
            StringBuilder UpdateAlbwebhookServiceURL = new StringBuilder("/infra/alb-webhooks/{alb-webhook-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbwebhookServiceURL.Replace("{alb-webhook-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWebhookId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albwebhook);
            request.Resource = UpdateAlbwebhookServiceURL.ToString();
            RestResponse<NSXTALBWebhookType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWebhookType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbwebhookServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWebhookType> ReadAlbwebhook(string AlbWebhookId)
        {
            if (AlbWebhookId == null) { throw new System.ArgumentNullException("AlbWebhookId cannot be null"); }
            StringBuilder ReadAlbwebhookServiceURL = new StringBuilder("/infra/alb-webhooks/{alb-webhook-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbwebhookServiceURL.Replace("{alb-webhook-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWebhookId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbwebhookServiceURL.ToString();
            RestResponse<NSXTALBWebhookType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWebhookType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbwebhookServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbwebhook(string AlbWebhookId, bool? Force = null)
        {
            if (AlbWebhookId == null) { throw new System.ArgumentNullException("AlbWebhookId cannot be null"); }
            StringBuilder DeleteAlbwebhookServiceURL = new StringBuilder("/infra/alb-webhooks/{alb-webhook-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbwebhookServiceURL.Replace("{alb-webhook-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWebhookId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbwebhookServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbwebhookServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbwebhook(string AlbWebhookId, NSXTALBWebhookType Albwebhook)
        {
            if (AlbWebhookId == null) { throw new System.ArgumentNullException("AlbWebhookId cannot be null"); }
            if (Albwebhook == null) { throw new System.ArgumentNullException("Albwebhook cannot be null"); }
            StringBuilder PatchAlbwebhookServiceURL = new StringBuilder("/infra/alb-webhooks/{alb-webhook-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbwebhookServiceURL.Replace("{alb-webhook-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWebhookId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albwebhook);
            request.Resource = PatchAlbwebhookServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbwebhookServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSOPolicyType> UpdateAlbssopolicy(string AlbSsopolicyId, NSXTALBSSOPolicyType Albssopolicy)
        {
            if (AlbSsopolicyId == null) { throw new System.ArgumentNullException("AlbSsopolicyId cannot be null"); }
            if (Albssopolicy == null) { throw new System.ArgumentNullException("Albssopolicy cannot be null"); }
            StringBuilder UpdateAlbssopolicyServiceURL = new StringBuilder("/infra/alb-sso-policies/{alb-ssopolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbssopolicyServiceURL.Replace("{alb-ssopolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSsopolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albssopolicy);
            request.Resource = UpdateAlbssopolicyServiceURL.ToString();
            RestResponse<NSXTALBSSOPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSOPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbssopolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbssopolicy(string AlbSsopolicyId, NSXTALBSSOPolicyType Albssopolicy)
        {
            if (AlbSsopolicyId == null) { throw new System.ArgumentNullException("AlbSsopolicyId cannot be null"); }
            if (Albssopolicy == null) { throw new System.ArgumentNullException("Albssopolicy cannot be null"); }
            StringBuilder PatchAlbssopolicyServiceURL = new StringBuilder("/infra/alb-sso-policies/{alb-ssopolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbssopolicyServiceURL.Replace("{alb-ssopolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSsopolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albssopolicy);
            request.Resource = PatchAlbssopolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbssopolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbssopolicy(string AlbSsopolicyId, bool? Force = null)
        {
            if (AlbSsopolicyId == null) { throw new System.ArgumentNullException("AlbSsopolicyId cannot be null"); }
            StringBuilder DeleteAlbssopolicyServiceURL = new StringBuilder("/infra/alb-sso-policies/{alb-ssopolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbssopolicyServiceURL.Replace("{alb-ssopolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSsopolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbssopolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbssopolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSOPolicyType> ReadAlbssopolicy(string AlbSsopolicyId)
        {
            if (AlbSsopolicyId == null) { throw new System.ArgumentNullException("AlbSsopolicyId cannot be null"); }
            StringBuilder ReadAlbssopolicyServiceURL = new StringBuilder("/infra/alb-sso-policies/{alb-ssopolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbssopolicyServiceURL.Replace("{alb-ssopolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSsopolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbssopolicyServiceURL.ToString();
            RestResponse<NSXTALBSSOPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSOPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbssopolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolApiResponseType> ListAlbpool(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbpoolServiceURL = new StringBuilder("/infra/alb-pools");
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
            request.Resource = ListAlbpoolServiceURL.ToString();
            RestResponse<NSXTALBPoolApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbpoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHardwareSecurityModuleGroupApiResponseType> ListAlbhardwareSecurityModuleGroup(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbhardwareSecurityModuleGroupServiceURL = new StringBuilder("/infra/alb-hardware-security-module-groups");
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
            request.Resource = ListAlbhardwareSecurityModuleGroupServiceURL.ToString();
            RestResponse<NSXTALBHardwareSecurityModuleGroupApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHardwareSecurityModuleGroupApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbhardwareSecurityModuleGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAutoScaleLaunchConfigType> UpdateAlbautoScaleLaunchConfig(string AlbAutoscalelaunchconfigId, NSXTALBAutoScaleLaunchConfigType AlbautoScaleLaunchConfig)
        {
            if (AlbAutoscalelaunchconfigId == null) { throw new System.ArgumentNullException("AlbAutoscalelaunchconfigId cannot be null"); }
            if (AlbautoScaleLaunchConfig == null) { throw new System.ArgumentNullException("AlbautoScaleLaunchConfig cannot be null"); }
            StringBuilder UpdateAlbautoScaleLaunchConfigServiceURL = new StringBuilder("/infra/alb-auto-scale-launch-configs/{alb-autoscalelaunchconfig-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbautoScaleLaunchConfigServiceURL.Replace("{alb-autoscalelaunchconfig-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAutoscalelaunchconfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbautoScaleLaunchConfig);
            request.Resource = UpdateAlbautoScaleLaunchConfigServiceURL.ToString();
            RestResponse<NSXTALBAutoScaleLaunchConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAutoScaleLaunchConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbautoScaleLaunchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAutoScaleLaunchConfigType> ReadAlbautoScaleLaunchConfig(string AlbAutoscalelaunchconfigId)
        {
            if (AlbAutoscalelaunchconfigId == null) { throw new System.ArgumentNullException("AlbAutoscalelaunchconfigId cannot be null"); }
            StringBuilder ReadAlbautoScaleLaunchConfigServiceURL = new StringBuilder("/infra/alb-auto-scale-launch-configs/{alb-autoscalelaunchconfig-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbautoScaleLaunchConfigServiceURL.Replace("{alb-autoscalelaunchconfig-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAutoscalelaunchconfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbautoScaleLaunchConfigServiceURL.ToString();
            RestResponse<NSXTALBAutoScaleLaunchConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAutoScaleLaunchConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbautoScaleLaunchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbautoScaleLaunchConfig(string AlbAutoscalelaunchconfigId, bool? Force = null)
        {
            if (AlbAutoscalelaunchconfigId == null) { throw new System.ArgumentNullException("AlbAutoscalelaunchconfigId cannot be null"); }
            StringBuilder DeleteAlbautoScaleLaunchConfigServiceURL = new StringBuilder("/infra/alb-auto-scale-launch-configs/{alb-autoscalelaunchconfig-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbautoScaleLaunchConfigServiceURL.Replace("{alb-autoscalelaunchconfig-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAutoscalelaunchconfigId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbautoScaleLaunchConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbautoScaleLaunchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbautoScaleLaunchConfig(string AlbAutoscalelaunchconfigId, NSXTALBAutoScaleLaunchConfigType AlbautoScaleLaunchConfig)
        {
            if (AlbAutoscalelaunchconfigId == null) { throw new System.ArgumentNullException("AlbAutoscalelaunchconfigId cannot be null"); }
            if (AlbautoScaleLaunchConfig == null) { throw new System.ArgumentNullException("AlbautoScaleLaunchConfig cannot be null"); }
            StringBuilder PatchAlbautoScaleLaunchConfigServiceURL = new StringBuilder("/infra/alb-auto-scale-launch-configs/{alb-autoscalelaunchconfig-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbautoScaleLaunchConfigServiceURL.Replace("{alb-autoscalelaunchconfig-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAutoscalelaunchconfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbautoScaleLaunchConfig);
            request.Resource = PatchAlbautoScaleLaunchConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbautoScaleLaunchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationPersistenceProfileApiResponseType> ListAlbapplicationPersistenceProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbapplicationPersistenceProfileServiceURL = new StringBuilder("/infra/alb-application-persistence-profiles");
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
            request.Resource = ListAlbapplicationPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationPersistenceProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationPersistenceProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbapplicationPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyPSMGroupType> UpdateAlbwafPolicyPsmgroup(string AlbWafpolicypsmgroupId, NSXTALBWafPolicyPSMGroupType AlbwafPolicyPsmgroup)
        {
            if (AlbWafpolicypsmgroupId == null) { throw new System.ArgumentNullException("AlbWafpolicypsmgroupId cannot be null"); }
            if (AlbwafPolicyPsmgroup == null) { throw new System.ArgumentNullException("AlbwafPolicyPsmgroup cannot be null"); }
            StringBuilder UpdateAlbwafPolicyPsmgroupServiceURL = new StringBuilder("/infra/alb-waf-policy-psm-groups/{alb-wafpolicypsmgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbwafPolicyPsmgroupServiceURL.Replace("{alb-wafpolicypsmgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicypsmgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafPolicyPsmgroup);
            request.Resource = UpdateAlbwafPolicyPsmgroupServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyPSMGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyPSMGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbwafPolicyPsmgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyPSMGroupType> ReadAlbwafPolicyPsmgroup(string AlbWafpolicypsmgroupId)
        {
            if (AlbWafpolicypsmgroupId == null) { throw new System.ArgumentNullException("AlbWafpolicypsmgroupId cannot be null"); }
            StringBuilder ReadAlbwafPolicyPsmgroupServiceURL = new StringBuilder("/infra/alb-waf-policy-psm-groups/{alb-wafpolicypsmgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbwafPolicyPsmgroupServiceURL.Replace("{alb-wafpolicypsmgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicypsmgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbwafPolicyPsmgroupServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyPSMGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyPSMGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbwafPolicyPsmgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbwafPolicyPsmgroup(string AlbWafpolicypsmgroupId, NSXTALBWafPolicyPSMGroupType AlbwafPolicyPsmgroup)
        {
            if (AlbWafpolicypsmgroupId == null) { throw new System.ArgumentNullException("AlbWafpolicypsmgroupId cannot be null"); }
            if (AlbwafPolicyPsmgroup == null) { throw new System.ArgumentNullException("AlbwafPolicyPsmgroup cannot be null"); }
            StringBuilder PatchAlbwafPolicyPsmgroupServiceURL = new StringBuilder("/infra/alb-waf-policy-psm-groups/{alb-wafpolicypsmgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbwafPolicyPsmgroupServiceURL.Replace("{alb-wafpolicypsmgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicypsmgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafPolicyPsmgroup);
            request.Resource = PatchAlbwafPolicyPsmgroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbwafPolicyPsmgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbwafPolicyPsmgroup(string AlbWafpolicypsmgroupId, bool? Force = null)
        {
            if (AlbWafpolicypsmgroupId == null) { throw new System.ArgumentNullException("AlbWafpolicypsmgroupId cannot be null"); }
            StringBuilder DeleteAlbwafPolicyPsmgroupServiceURL = new StringBuilder("/infra/alb-waf-policy-psm-groups/{alb-wafpolicypsmgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbwafPolicyPsmgroupServiceURL.Replace("{alb-wafpolicypsmgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicypsmgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbwafPolicyPsmgroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbwafPolicyPsmgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBServerAutoScalePolicyType> UpdateAlbserverAutoScalePolicy(string AlbServerautoscalepolicyId, NSXTALBServerAutoScalePolicyType AlbserverAutoScalePolicy)
        {
            if (AlbServerautoscalepolicyId == null) { throw new System.ArgumentNullException("AlbServerautoscalepolicyId cannot be null"); }
            if (AlbserverAutoScalePolicy == null) { throw new System.ArgumentNullException("AlbserverAutoScalePolicy cannot be null"); }
            StringBuilder UpdateAlbserverAutoScalePolicyServiceURL = new StringBuilder("/infra/alb-server-auto-scale-policies/{alb-serverautoscalepolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbserverAutoScalePolicyServiceURL.Replace("{alb-serverautoscalepolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbServerautoscalepolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbserverAutoScalePolicy);
            request.Resource = UpdateAlbserverAutoScalePolicyServiceURL.ToString();
            RestResponse<NSXTALBServerAutoScalePolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBServerAutoScalePolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbserverAutoScalePolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBServerAutoScalePolicyType> ReadAlbserverAutoScalePolicy(string AlbServerautoscalepolicyId)
        {
            if (AlbServerautoscalepolicyId == null) { throw new System.ArgumentNullException("AlbServerautoscalepolicyId cannot be null"); }
            StringBuilder ReadAlbserverAutoScalePolicyServiceURL = new StringBuilder("/infra/alb-server-auto-scale-policies/{alb-serverautoscalepolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbserverAutoScalePolicyServiceURL.Replace("{alb-serverautoscalepolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbServerautoscalepolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbserverAutoScalePolicyServiceURL.ToString();
            RestResponse<NSXTALBServerAutoScalePolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBServerAutoScalePolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbserverAutoScalePolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbserverAutoScalePolicy(string AlbServerautoscalepolicyId, NSXTALBServerAutoScalePolicyType AlbserverAutoScalePolicy)
        {
            if (AlbServerautoscalepolicyId == null) { throw new System.ArgumentNullException("AlbServerautoscalepolicyId cannot be null"); }
            if (AlbserverAutoScalePolicy == null) { throw new System.ArgumentNullException("AlbserverAutoScalePolicy cannot be null"); }
            StringBuilder PatchAlbserverAutoScalePolicyServiceURL = new StringBuilder("/infra/alb-server-auto-scale-policies/{alb-serverautoscalepolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbserverAutoScalePolicyServiceURL.Replace("{alb-serverautoscalepolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbServerautoscalepolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbserverAutoScalePolicy);
            request.Resource = PatchAlbserverAutoScalePolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbserverAutoScalePolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbserverAutoScalePolicy(string AlbServerautoscalepolicyId, bool? Force = null)
        {
            if (AlbServerautoscalepolicyId == null) { throw new System.ArgumentNullException("AlbServerautoscalepolicyId cannot be null"); }
            StringBuilder DeleteAlbserverAutoScalePolicyServiceURL = new StringBuilder("/infra/alb-server-auto-scale-policies/{alb-serverautoscalepolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbserverAutoScalePolicyServiceURL.Replace("{alb-serverautoscalepolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbServerautoscalepolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbserverAutoScalePolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbserverAutoScalePolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBProtocolParserApiResponseType> ListAlbprotocolParser(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbprotocolParserServiceURL = new StringBuilder("/infra/alb-protocol-parsers");
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
            request.Resource = ListAlbprotocolParserServiceURL.ToString();
            RestResponse<NSXTALBProtocolParserApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBProtocolParserApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbprotocolParserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> UpdateAlbpoolGroupDeploymentPolicy(string AlbPoolgroupdeploymentpolicyId, NSXTALBPoolGroupDeploymentPolicyType AlbpoolGroupDeploymentPolicy)
        {
            if (AlbPoolgroupdeploymentpolicyId == null) { throw new System.ArgumentNullException("AlbPoolgroupdeploymentpolicyId cannot be null"); }
            if (AlbpoolGroupDeploymentPolicy == null) { throw new System.ArgumentNullException("AlbpoolGroupDeploymentPolicy cannot be null"); }
            StringBuilder UpdateAlbpoolGroupDeploymentPolicyServiceURL = new StringBuilder("/infra/alb-pool-group-deployment-policies/{alb-poolgroupdeploymentpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbpoolGroupDeploymentPolicyServiceURL.Replace("{alb-poolgroupdeploymentpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupdeploymentpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpoolGroupDeploymentPolicy);
            request.Resource = UpdateAlbpoolGroupDeploymentPolicyServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbpoolGroupDeploymentPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbpoolGroupDeploymentPolicy(string AlbPoolgroupdeploymentpolicyId, bool? Force = null)
        {
            if (AlbPoolgroupdeploymentpolicyId == null) { throw new System.ArgumentNullException("AlbPoolgroupdeploymentpolicyId cannot be null"); }
            StringBuilder DeleteAlbpoolGroupDeploymentPolicyServiceURL = new StringBuilder("/infra/alb-pool-group-deployment-policies/{alb-poolgroupdeploymentpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbpoolGroupDeploymentPolicyServiceURL.Replace("{alb-poolgroupdeploymentpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupdeploymentpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbpoolGroupDeploymentPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbpoolGroupDeploymentPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbpoolGroupDeploymentPolicy(string AlbPoolgroupdeploymentpolicyId, NSXTALBPoolGroupDeploymentPolicyType AlbpoolGroupDeploymentPolicy)
        {
            if (AlbPoolgroupdeploymentpolicyId == null) { throw new System.ArgumentNullException("AlbPoolgroupdeploymentpolicyId cannot be null"); }
            if (AlbpoolGroupDeploymentPolicy == null) { throw new System.ArgumentNullException("AlbpoolGroupDeploymentPolicy cannot be null"); }
            StringBuilder PatchAlbpoolGroupDeploymentPolicyServiceURL = new StringBuilder("/infra/alb-pool-group-deployment-policies/{alb-poolgroupdeploymentpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbpoolGroupDeploymentPolicyServiceURL.Replace("{alb-poolgroupdeploymentpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupdeploymentpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpoolGroupDeploymentPolicy);
            request.Resource = PatchAlbpoolGroupDeploymentPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbpoolGroupDeploymentPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupDeploymentPolicyType> ReadAlbpoolGroupDeploymentPolicy(string AlbPoolgroupdeploymentpolicyId)
        {
            if (AlbPoolgroupdeploymentpolicyId == null) { throw new System.ArgumentNullException("AlbPoolgroupdeploymentpolicyId cannot be null"); }
            StringBuilder ReadAlbpoolGroupDeploymentPolicyServiceURL = new StringBuilder("/infra/alb-pool-group-deployment-policies/{alb-poolgroupdeploymentpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbpoolGroupDeploymentPolicyServiceURL.Replace("{alb-poolgroupdeploymentpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupdeploymentpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbpoolGroupDeploymentPolicyServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupDeploymentPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbpoolGroupDeploymentPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBL4PolicySetApiResponseType> ListALBL4PolicySet(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListALBL4PolicySetServiceURL = new StringBuilder("/infra/alb-l4-policy-sets");
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
            request.Resource = ListALBL4PolicySetServiceURL.ToString();
            RestResponse<NSXTALBL4PolicySetApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBL4PolicySetApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListALBL4PolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVirtualServiceType> UpdateAlbvirtualService(string AlbVirtualserviceId, NSXTALBVirtualServiceType AlbvirtualService)
        {
            if (AlbVirtualserviceId == null) { throw new System.ArgumentNullException("AlbVirtualserviceId cannot be null"); }
            if (AlbvirtualService == null) { throw new System.ArgumentNullException("AlbvirtualService cannot be null"); }
            StringBuilder UpdateAlbvirtualServiceServiceURL = new StringBuilder("/infra/alb-virtual-services/{alb-virtualservice-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbvirtualServiceServiceURL.Replace("{alb-virtualservice-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVirtualserviceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvirtualService);
            request.Resource = UpdateAlbvirtualServiceServiceURL.ToString();
            RestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbvirtualServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbvirtualService(string AlbVirtualserviceId, NSXTALBVirtualServiceType AlbvirtualService)
        {
            if (AlbVirtualserviceId == null) { throw new System.ArgumentNullException("AlbVirtualserviceId cannot be null"); }
            if (AlbvirtualService == null) { throw new System.ArgumentNullException("AlbvirtualService cannot be null"); }
            StringBuilder PatchAlbvirtualServiceServiceURL = new StringBuilder("/infra/alb-virtual-services/{alb-virtualservice-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbvirtualServiceServiceURL.Replace("{alb-virtualservice-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVirtualserviceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvirtualService);
            request.Resource = PatchAlbvirtualServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbvirtualServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVirtualServiceType> ReadAlbvirtualService(string AlbVirtualserviceId)
        {
            if (AlbVirtualserviceId == null) { throw new System.ArgumentNullException("AlbVirtualserviceId cannot be null"); }
            StringBuilder ReadAlbvirtualServiceServiceURL = new StringBuilder("/infra/alb-virtual-services/{alb-virtualservice-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbvirtualServiceServiceURL.Replace("{alb-virtualservice-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVirtualserviceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbvirtualServiceServiceURL.ToString();
            RestResponse<NSXTALBVirtualServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbvirtualServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbvirtualService(string AlbVirtualserviceId, bool? Force = null)
        {
            if (AlbVirtualserviceId == null) { throw new System.ArgumentNullException("AlbVirtualserviceId cannot be null"); }
            StringBuilder DeleteAlbvirtualServiceServiceURL = new StringBuilder("/infra/alb-virtual-services/{alb-virtualservice-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbvirtualServiceServiceURL.Replace("{alb-virtualservice-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVirtualserviceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbvirtualServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbvirtualServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBIpAddrGroupType> UpdateAlbipAddrGroup(string AlbIpaddrgroupId, NSXTALBIpAddrGroupType AlbipAddrGroup)
        {
            if (AlbIpaddrgroupId == null) { throw new System.ArgumentNullException("AlbIpaddrgroupId cannot be null"); }
            if (AlbipAddrGroup == null) { throw new System.ArgumentNullException("AlbipAddrGroup cannot be null"); }
            StringBuilder UpdateAlbipAddrGroupServiceURL = new StringBuilder("/infra/alb-ip-addr-groups/{alb-ipaddrgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbipAddrGroupServiceURL.Replace("{alb-ipaddrgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbIpaddrgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbipAddrGroup);
            request.Resource = UpdateAlbipAddrGroupServiceURL.ToString();
            RestResponse<NSXTALBIpAddrGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBIpAddrGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbipAddrGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBIpAddrGroupType> ReadAlbipAddrGroup(string AlbIpaddrgroupId)
        {
            if (AlbIpaddrgroupId == null) { throw new System.ArgumentNullException("AlbIpaddrgroupId cannot be null"); }
            StringBuilder ReadAlbipAddrGroupServiceURL = new StringBuilder("/infra/alb-ip-addr-groups/{alb-ipaddrgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbipAddrGroupServiceURL.Replace("{alb-ipaddrgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbIpaddrgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbipAddrGroupServiceURL.ToString();
            RestResponse<NSXTALBIpAddrGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBIpAddrGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbipAddrGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbipAddrGroup(string AlbIpaddrgroupId, bool? Force = null)
        {
            if (AlbIpaddrgroupId == null) { throw new System.ArgumentNullException("AlbIpaddrgroupId cannot be null"); }
            StringBuilder DeleteAlbipAddrGroupServiceURL = new StringBuilder("/infra/alb-ip-addr-groups/{alb-ipaddrgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbipAddrGroupServiceURL.Replace("{alb-ipaddrgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbIpaddrgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbipAddrGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbipAddrGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbipAddrGroup(string AlbIpaddrgroupId, NSXTALBIpAddrGroupType AlbipAddrGroup)
        {
            if (AlbIpaddrgroupId == null) { throw new System.ArgumentNullException("AlbIpaddrgroupId cannot be null"); }
            if (AlbipAddrGroup == null) { throw new System.ArgumentNullException("AlbipAddrGroup cannot be null"); }
            StringBuilder PatchAlbipAddrGroupServiceURL = new StringBuilder("/infra/alb-ip-addr-groups/{alb-ipaddrgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbipAddrGroupServiceURL.Replace("{alb-ipaddrgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbIpaddrgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbipAddrGroup);
            request.Resource = PatchAlbipAddrGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbipAddrGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHealthMonitorApiResponseType> ListAlbhealthMonitor(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbhealthMonitorServiceURL = new StringBuilder("/infra/alb-health-monitors");
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
            request.Resource = ListAlbhealthMonitorServiceURL.ToString();
            RestResponse<NSXTALBHealthMonitorApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthMonitorApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbhealthMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLKeyAndCertificateApiResponseType> ListAlbsslkeyAndCertificate(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbsslkeyAndCertificateServiceURL = new StringBuilder("/infra/alb-ssl-key-and-certificates");
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
            request.Resource = ListAlbsslkeyAndCertificateServiceURL.ToString();
            RestResponse<NSXTALBSSLKeyAndCertificateApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbsslkeyAndCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyPSMGroupApiResponseType> ListAlbwafPolicyPsmgroup(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbwafPolicyPsmgroupServiceURL = new StringBuilder("/infra/alb-waf-policy-psm-groups");
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
            request.Resource = ListAlbwafPolicyPsmgroupServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyPSMGroupApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyPSMGroupApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbwafPolicyPsmgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkSecurityPolicyApiResponseType> ListAlbnetworkSecurityPolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbnetworkSecurityPolicyServiceURL = new StringBuilder("/infra/alb-network-security-policies");
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
            request.Resource = ListAlbnetworkSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBNetworkSecurityPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkSecurityPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbnetworkSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLProfileApiResponseType> ListAlbsslprofile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbsslprofileServiceURL = new StringBuilder("/infra/alb-ssl-profiles");
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
            request.Resource = ListAlbsslprofileServiceURL.ToString();
            RestResponse<NSXTALBSSLProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbsslprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbOnBoardingWorkflow(string ManagedBy)
        {
            if (ManagedBy == null) { throw new System.ArgumentNullException("ManagedBy cannot be null"); }
            StringBuilder DeleteAlbOnBoardingWorkflowServiceURL = new StringBuilder("/infra/alb-onboarding-workflow/{managed-by}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbOnBoardingWorkflowServiceURL.Replace("{managed-by}", System.Uri.EscapeDataString(Helpers.ConvertToString(ManagedBy, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteAlbOnBoardingWorkflowServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbOnBoardingWorkflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageProfileApiResponseType> ListAlberrorPageProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlberrorPageProfileServiceURL = new StringBuilder("/infra/alb-error-page-profiles");
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
            request.Resource = ListAlberrorPageProfileServiceURL.ToString();
            RestResponse<NSXTALBErrorPageProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlberrorPageProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAuthTokenType> GetAlbauthToken(NSXTALBAuthTokenType AlbauthToken)
        {
            if (AlbauthToken == null) { throw new System.ArgumentNullException("AlbauthToken cannot be null"); }
            StringBuilder GetAlbauthTokenServiceURL = new StringBuilder("/infra/alb-auth-token");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(AlbauthToken);
            request.Resource = GetAlbauthTokenServiceURL.ToString();
            RestResponse<NSXTALBAuthTokenType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAuthTokenType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GetAlbauthTokenServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVsVipType> UpdateAlbvsVip(string AlbVsvipId, NSXTALBVsVipType AlbvsVip)
        {
            if (AlbVsvipId == null) { throw new System.ArgumentNullException("AlbVsvipId cannot be null"); }
            if (AlbvsVip == null) { throw new System.ArgumentNullException("AlbvsVip cannot be null"); }
            StringBuilder UpdateAlbvsVipServiceURL = new StringBuilder("/infra/alb-vs-vips/{alb-vsvip-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbvsVipServiceURL.Replace("{alb-vsvip-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsvipId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvsVip);
            request.Resource = UpdateAlbvsVipServiceURL.ToString();
            RestResponse<NSXTALBVsVipType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVsVipType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbvsVipServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVsVipType> ReadAlbvsVip(string AlbVsvipId)
        {
            if (AlbVsvipId == null) { throw new System.ArgumentNullException("AlbVsvipId cannot be null"); }
            StringBuilder ReadAlbvsVipServiceURL = new StringBuilder("/infra/alb-vs-vips/{alb-vsvip-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbvsVipServiceURL.Replace("{alb-vsvip-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsvipId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbvsVipServiceURL.ToString();
            RestResponse<NSXTALBVsVipType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVsVipType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbvsVipServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbvsVip(string AlbVsvipId, bool? Force = null)
        {
            if (AlbVsvipId == null) { throw new System.ArgumentNullException("AlbVsvipId cannot be null"); }
            StringBuilder DeleteAlbvsVipServiceURL = new StringBuilder("/infra/alb-vs-vips/{alb-vsvip-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbvsVipServiceURL.Replace("{alb-vsvip-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsvipId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbvsVipServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbvsVipServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbvsVip(string AlbVsvipId, NSXTALBVsVipType AlbvsVip)
        {
            if (AlbVsvipId == null) { throw new System.ArgumentNullException("AlbVsvipId cannot be null"); }
            if (AlbvsVip == null) { throw new System.ArgumentNullException("AlbvsVip cannot be null"); }
            StringBuilder PatchAlbvsVipServiceURL = new StringBuilder("/infra/alb-vs-vips/{alb-vsvip-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbvsVipServiceURL.Replace("{alb-vsvip-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsvipId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvsVip);
            request.Resource = PatchAlbvsVipServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbvsVipServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHTTPPolicySetType> UpdateAlbhttppolicySet(string AlbHttppolicysetId, NSXTALBHTTPPolicySetType AlbhttppolicySet)
        {
            if (AlbHttppolicysetId == null) { throw new System.ArgumentNullException("AlbHttppolicysetId cannot be null"); }
            if (AlbhttppolicySet == null) { throw new System.ArgumentNullException("AlbhttppolicySet cannot be null"); }
            StringBuilder UpdateAlbhttppolicySetServiceURL = new StringBuilder("/infra/alb-http-policy-sets/{alb-httppolicyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbhttppolicySetServiceURL.Replace("{alb-httppolicyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHttppolicysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhttppolicySet);
            request.Resource = UpdateAlbhttppolicySetServiceURL.ToString();
            RestResponse<NSXTALBHTTPPolicySetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHTTPPolicySetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbhttppolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbhttppolicySet(string AlbHttppolicysetId, bool? Force = null)
        {
            if (AlbHttppolicysetId == null) { throw new System.ArgumentNullException("AlbHttppolicysetId cannot be null"); }
            StringBuilder DeleteAlbhttppolicySetServiceURL = new StringBuilder("/infra/alb-http-policy-sets/{alb-httppolicyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbhttppolicySetServiceURL.Replace("{alb-httppolicyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHttppolicysetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbhttppolicySetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbhttppolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHTTPPolicySetType> ReadAlbhttppolicySet(string AlbHttppolicysetId)
        {
            if (AlbHttppolicysetId == null) { throw new System.ArgumentNullException("AlbHttppolicysetId cannot be null"); }
            StringBuilder ReadAlbhttppolicySetServiceURL = new StringBuilder("/infra/alb-http-policy-sets/{alb-httppolicyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbhttppolicySetServiceURL.Replace("{alb-httppolicyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHttppolicysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbhttppolicySetServiceURL.ToString();
            RestResponse<NSXTALBHTTPPolicySetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHTTPPolicySetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbhttppolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbhttppolicySet(string AlbHttppolicysetId, NSXTALBHTTPPolicySetType AlbhttppolicySet)
        {
            if (AlbHttppolicysetId == null) { throw new System.ArgumentNullException("AlbHttppolicysetId cannot be null"); }
            if (AlbhttppolicySet == null) { throw new System.ArgumentNullException("AlbhttppolicySet cannot be null"); }
            StringBuilder PatchAlbhttppolicySetServiceURL = new StringBuilder("/infra/alb-http-policy-sets/{alb-httppolicyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbhttppolicySetServiceURL.Replace("{alb-httppolicyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHttppolicysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhttppolicySet);
            request.Resource = PatchAlbhttppolicySetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbhttppolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBStringGroupApiResponseType> ListAlbstringGroup(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbstringGroupServiceURL = new StringBuilder("/infra/alb-string-groups");
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
            request.Resource = ListAlbstringGroupServiceURL.ToString();
            RestResponse<NSXTALBStringGroupApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBStringGroupApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbstringGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBDnsPolicyType> UpdateAlbdnsPolicy(string AlbDnspolicyId, NSXTALBDnsPolicyType AlbdnsPolicy)
        {
            if (AlbDnspolicyId == null) { throw new System.ArgumentNullException("AlbDnspolicyId cannot be null"); }
            if (AlbdnsPolicy == null) { throw new System.ArgumentNullException("AlbdnsPolicy cannot be null"); }
            StringBuilder UpdateAlbdnsPolicyServiceURL = new StringBuilder("/infra/alb-dns-policies/{alb-dnspolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbdnsPolicyServiceURL.Replace("{alb-dnspolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbDnspolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbdnsPolicy);
            request.Resource = UpdateAlbdnsPolicyServiceURL.ToString();
            RestResponse<NSXTALBDnsPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBDnsPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbdnsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbdnsPolicy(string AlbDnspolicyId, NSXTALBDnsPolicyType AlbdnsPolicy)
        {
            if (AlbDnspolicyId == null) { throw new System.ArgumentNullException("AlbDnspolicyId cannot be null"); }
            if (AlbdnsPolicy == null) { throw new System.ArgumentNullException("AlbdnsPolicy cannot be null"); }
            StringBuilder PatchAlbdnsPolicyServiceURL = new StringBuilder("/infra/alb-dns-policies/{alb-dnspolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbdnsPolicyServiceURL.Replace("{alb-dnspolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbDnspolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbdnsPolicy);
            request.Resource = PatchAlbdnsPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbdnsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBDnsPolicyType> ReadAlbdnsPolicy(string AlbDnspolicyId)
        {
            if (AlbDnspolicyId == null) { throw new System.ArgumentNullException("AlbDnspolicyId cannot be null"); }
            StringBuilder ReadAlbdnsPolicyServiceURL = new StringBuilder("/infra/alb-dns-policies/{alb-dnspolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbdnsPolicyServiceURL.Replace("{alb-dnspolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbDnspolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbdnsPolicyServiceURL.ToString();
            RestResponse<NSXTALBDnsPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBDnsPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbdnsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbdnsPolicy(string AlbDnspolicyId, bool? Force = null)
        {
            if (AlbDnspolicyId == null) { throw new System.ArgumentNullException("AlbDnspolicyId cannot be null"); }
            StringBuilder DeleteAlbdnsPolicyServiceURL = new StringBuilder("/infra/alb-dns-policies/{alb-dnspolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbdnsPolicyServiceURL.Replace("{alb-dnspolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbDnspolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbdnsPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbdnsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSecurityPolicyType> UpdateAlbsecurityPolicy(string AlbSecuritypolicyId, NSXTALBSecurityPolicyType AlbsecurityPolicy)
        {
            if (AlbSecuritypolicyId == null) { throw new System.ArgumentNullException("AlbSecuritypolicyId cannot be null"); }
            if (AlbsecurityPolicy == null) { throw new System.ArgumentNullException("AlbsecurityPolicy cannot be null"); }
            StringBuilder UpdateAlbsecurityPolicyServiceURL = new StringBuilder("/infra/alb-security-policies/{alb-securitypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbsecurityPolicyServiceURL.Replace("{alb-securitypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbsecurityPolicy);
            request.Resource = UpdateAlbsecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbsecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbsecurityPolicy(string AlbSecuritypolicyId, NSXTALBSecurityPolicyType AlbsecurityPolicy)
        {
            if (AlbSecuritypolicyId == null) { throw new System.ArgumentNullException("AlbSecuritypolicyId cannot be null"); }
            if (AlbsecurityPolicy == null) { throw new System.ArgumentNullException("AlbsecurityPolicy cannot be null"); }
            StringBuilder PatchAlbsecurityPolicyServiceURL = new StringBuilder("/infra/alb-security-policies/{alb-securitypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbsecurityPolicyServiceURL.Replace("{alb-securitypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbsecurityPolicy);
            request.Resource = PatchAlbsecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbsecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSecurityPolicyType> ReadAlbsecurityPolicy(string AlbSecuritypolicyId)
        {
            if (AlbSecuritypolicyId == null) { throw new System.ArgumentNullException("AlbSecuritypolicyId cannot be null"); }
            StringBuilder ReadAlbsecurityPolicyServiceURL = new StringBuilder("/infra/alb-security-policies/{alb-securitypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbsecurityPolicyServiceURL.Replace("{alb-securitypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbsecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbsecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbsecurityPolicy(string AlbSecuritypolicyId, bool? Force = null)
        {
            if (AlbSecuritypolicyId == null) { throw new System.ArgumentNullException("AlbSecuritypolicyId cannot be null"); }
            StringBuilder DeleteAlbsecurityPolicyServiceURL = new StringBuilder("/infra/alb-security-policies/{alb-securitypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbsecurityPolicyServiceURL.Replace("{alb-securitypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbsecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbsecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkSecurityPolicyType> UpdateAlbnetworkSecurityPolicy(string AlbNetworksecuritypolicyId, NSXTALBNetworkSecurityPolicyType AlbnetworkSecurityPolicy)
        {
            if (AlbNetworksecuritypolicyId == null) { throw new System.ArgumentNullException("AlbNetworksecuritypolicyId cannot be null"); }
            if (AlbnetworkSecurityPolicy == null) { throw new System.ArgumentNullException("AlbnetworkSecurityPolicy cannot be null"); }
            StringBuilder UpdateAlbnetworkSecurityPolicyServiceURL = new StringBuilder("/infra/alb-network-security-policies/{alb-networksecuritypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbnetworkSecurityPolicyServiceURL.Replace("{alb-networksecuritypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworksecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbnetworkSecurityPolicy);
            request.Resource = UpdateAlbnetworkSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBNetworkSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbnetworkSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbnetworkSecurityPolicy(string AlbNetworksecuritypolicyId, bool? Force = null)
        {
            if (AlbNetworksecuritypolicyId == null) { throw new System.ArgumentNullException("AlbNetworksecuritypolicyId cannot be null"); }
            StringBuilder DeleteAlbnetworkSecurityPolicyServiceURL = new StringBuilder("/infra/alb-network-security-policies/{alb-networksecuritypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbnetworkSecurityPolicyServiceURL.Replace("{alb-networksecuritypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworksecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbnetworkSecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbnetworkSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkSecurityPolicyType> ReadAlbnetworkSecurityPolicy(string AlbNetworksecuritypolicyId)
        {
            if (AlbNetworksecuritypolicyId == null) { throw new System.ArgumentNullException("AlbNetworksecuritypolicyId cannot be null"); }
            StringBuilder ReadAlbnetworkSecurityPolicyServiceURL = new StringBuilder("/infra/alb-network-security-policies/{alb-networksecuritypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbnetworkSecurityPolicyServiceURL.Replace("{alb-networksecuritypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworksecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbnetworkSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTALBNetworkSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbnetworkSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbnetworkSecurityPolicy(string AlbNetworksecuritypolicyId, NSXTALBNetworkSecurityPolicyType AlbnetworkSecurityPolicy)
        {
            if (AlbNetworksecuritypolicyId == null) { throw new System.ArgumentNullException("AlbNetworksecuritypolicyId cannot be null"); }
            if (AlbnetworkSecurityPolicy == null) { throw new System.ArgumentNullException("AlbnetworkSecurityPolicy cannot be null"); }
            StringBuilder PatchAlbnetworkSecurityPolicyServiceURL = new StringBuilder("/infra/alb-network-security-policies/{alb-networksecuritypolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbnetworkSecurityPolicyServiceURL.Replace("{alb-networksecuritypolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworksecuritypolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbnetworkSecurityPolicy);
            request.Resource = PatchAlbnetworkSecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbnetworkSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPriorityLabelsApiResponseType> ListAlbpriorityLabels(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbpriorityLabelsServiceURL = new StringBuilder("/infra/alb-priority-labels");
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
            request.Resource = ListAlbpriorityLabelsServiceURL.ToString();
            RestResponse<NSXTALBPriorityLabelsApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPriorityLabelsApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbpriorityLabelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkProfileApiResponseType> ListAlbnetworkProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbnetworkProfileServiceURL = new StringBuilder("/infra/alb-network-profiles");
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
            request.Resource = ListAlbnetworkProfileServiceURL.ToString();
            RestResponse<NSXTALBNetworkProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbnetworkProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBTrafficCloneProfileType> UpdateAlbtrafficCloneProfile(string AlbTrafficcloneprofileId, NSXTALBTrafficCloneProfileType AlbtrafficCloneProfile)
        {
            if (AlbTrafficcloneprofileId == null) { throw new System.ArgumentNullException("AlbTrafficcloneprofileId cannot be null"); }
            if (AlbtrafficCloneProfile == null) { throw new System.ArgumentNullException("AlbtrafficCloneProfile cannot be null"); }
            StringBuilder UpdateAlbtrafficCloneProfileServiceURL = new StringBuilder("/infra/alb-traffic-clone-profiles/{alb-trafficcloneprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbtrafficCloneProfileServiceURL.Replace("{alb-trafficcloneprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbTrafficcloneprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbtrafficCloneProfile);
            request.Resource = UpdateAlbtrafficCloneProfileServiceURL.ToString();
            RestResponse<NSXTALBTrafficCloneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBTrafficCloneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbtrafficCloneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbtrafficCloneProfile(string AlbTrafficcloneprofileId, NSXTALBTrafficCloneProfileType AlbtrafficCloneProfile)
        {
            if (AlbTrafficcloneprofileId == null) { throw new System.ArgumentNullException("AlbTrafficcloneprofileId cannot be null"); }
            if (AlbtrafficCloneProfile == null) { throw new System.ArgumentNullException("AlbtrafficCloneProfile cannot be null"); }
            StringBuilder PatchAlbtrafficCloneProfileServiceURL = new StringBuilder("/infra/alb-traffic-clone-profiles/{alb-trafficcloneprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbtrafficCloneProfileServiceURL.Replace("{alb-trafficcloneprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbTrafficcloneprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbtrafficCloneProfile);
            request.Resource = PatchAlbtrafficCloneProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbtrafficCloneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBTrafficCloneProfileType> ReadAlbtrafficCloneProfile(string AlbTrafficcloneprofileId)
        {
            if (AlbTrafficcloneprofileId == null) { throw new System.ArgumentNullException("AlbTrafficcloneprofileId cannot be null"); }
            StringBuilder ReadAlbtrafficCloneProfileServiceURL = new StringBuilder("/infra/alb-traffic-clone-profiles/{alb-trafficcloneprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbtrafficCloneProfileServiceURL.Replace("{alb-trafficcloneprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbTrafficcloneprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbtrafficCloneProfileServiceURL.ToString();
            RestResponse<NSXTALBTrafficCloneProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBTrafficCloneProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbtrafficCloneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbtrafficCloneProfile(string AlbTrafficcloneprofileId, bool? Force = null)
        {
            if (AlbTrafficcloneprofileId == null) { throw new System.ArgumentNullException("AlbTrafficcloneprofileId cannot be null"); }
            StringBuilder DeleteAlbtrafficCloneProfileServiceURL = new StringBuilder("/infra/alb-traffic-clone-profiles/{alb-trafficcloneprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbtrafficCloneProfileServiceURL.Replace("{alb-trafficcloneprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbTrafficcloneprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbtrafficCloneProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbtrafficCloneProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBL4PolicySetType> UpdateALBL4PolicySet(string AlbL4policysetId, NSXTALBL4PolicySetType ALBL4PolicySet)
        {
            if (AlbL4policysetId == null) { throw new System.ArgumentNullException("AlbL4policysetId cannot be null"); }
            if (ALBL4PolicySet == null) { throw new System.ArgumentNullException("ALBL4PolicySet cannot be null"); }
            StringBuilder UpdateALBL4PolicySetServiceURL = new StringBuilder("/infra/alb-l4-policy-sets/{alb-l4policyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateALBL4PolicySetServiceURL.Replace("{alb-l4policyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbL4policysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ALBL4PolicySet);
            request.Resource = UpdateALBL4PolicySetServiceURL.ToString();
            RestResponse<NSXTALBL4PolicySetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBL4PolicySetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateALBL4PolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBL4PolicySetType> ReadALBL4PolicySet(string AlbL4policysetId)
        {
            if (AlbL4policysetId == null) { throw new System.ArgumentNullException("AlbL4policysetId cannot be null"); }
            StringBuilder ReadALBL4PolicySetServiceURL = new StringBuilder("/infra/alb-l4-policy-sets/{alb-l4policyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadALBL4PolicySetServiceURL.Replace("{alb-l4policyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbL4policysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadALBL4PolicySetServiceURL.ToString();
            RestResponse<NSXTALBL4PolicySetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBL4PolicySetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadALBL4PolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteALBL4PolicySet(string AlbL4policysetId, bool? Force = null)
        {
            if (AlbL4policysetId == null) { throw new System.ArgumentNullException("AlbL4policysetId cannot be null"); }
            StringBuilder DeleteALBL4PolicySetServiceURL = new StringBuilder("/infra/alb-l4-policy-sets/{alb-l4policyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteALBL4PolicySetServiceURL.Replace("{alb-l4policyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbL4policysetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteALBL4PolicySetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteALBL4PolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchALBL4PolicySet(string AlbL4policysetId, NSXTALBL4PolicySetType ALBL4PolicySet)
        {
            if (AlbL4policysetId == null) { throw new System.ArgumentNullException("AlbL4policysetId cannot be null"); }
            if (ALBL4PolicySet == null) { throw new System.ArgumentNullException("ALBL4PolicySet cannot be null"); }
            StringBuilder PatchALBL4PolicySetServiceURL = new StringBuilder("/infra/alb-l4-policy-sets/{alb-l4policyset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchALBL4PolicySetServiceURL.Replace("{alb-l4policyset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbL4policysetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ALBL4PolicySet);
            request.Resource = PatchALBL4PolicySetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchALBL4PolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationProfileApiResponseType> ListAlbapplicationProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbapplicationProfileServiceURL = new StringBuilder("/infra/alb-application-profiles");
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
            request.Resource = ListAlbapplicationProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbapplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafCRSType> UpdateAlbwafCRS(string AlbWafcrsId, NSXTALBWafCRSType AlbwafCRS)
        {
            if (AlbWafcrsId == null) { throw new System.ArgumentNullException("AlbWafcrsId cannot be null"); }
            if (AlbwafCRS == null) { throw new System.ArgumentNullException("AlbwafCRS cannot be null"); }
            StringBuilder UpdateAlbwafCRSServiceURL = new StringBuilder("/infra/alb-waf-crs/{alb-wafcrs-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbwafCRSServiceURL.Replace("{alb-wafcrs-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafcrsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafCRS);
            request.Resource = UpdateAlbwafCRSServiceURL.ToString();
            RestResponse<NSXTALBWafCRSType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafCRSType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbwafCRSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafCRSType> ReadAlbwafCRS(string AlbWafcrsId)
        {
            if (AlbWafcrsId == null) { throw new System.ArgumentNullException("AlbWafcrsId cannot be null"); }
            StringBuilder ReadAlbwafCRSServiceURL = new StringBuilder("/infra/alb-waf-crs/{alb-wafcrs-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbwafCRSServiceURL.Replace("{alb-wafcrs-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafcrsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbwafCRSServiceURL.ToString();
            RestResponse<NSXTALBWafCRSType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafCRSType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbwafCRSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbwafCRS(string AlbWafcrsId, NSXTALBWafCRSType AlbwafCRS)
        {
            if (AlbWafcrsId == null) { throw new System.ArgumentNullException("AlbWafcrsId cannot be null"); }
            if (AlbwafCRS == null) { throw new System.ArgumentNullException("AlbwafCRS cannot be null"); }
            StringBuilder PatchAlbwafCRSServiceURL = new StringBuilder("/infra/alb-waf-crs/{alb-wafcrs-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbwafCRSServiceURL.Replace("{alb-wafcrs-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafcrsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafCRS);
            request.Resource = PatchAlbwafCRSServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbwafCRSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbwafCRS(string AlbWafcrsId, bool? Force = null)
        {
            if (AlbWafcrsId == null) { throw new System.ArgumentNullException("AlbWafcrsId cannot be null"); }
            StringBuilder DeleteAlbwafCRSServiceURL = new StringBuilder("/infra/alb-waf-crs/{alb-wafcrs-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbwafCRSServiceURL.Replace("{alb-wafcrs-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafcrsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbwafCRSServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbwafCRSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHealthMonitorType> UpdateAlbhealthMonitor(string AlbHealthmonitorId, NSXTALBHealthMonitorType AlbhealthMonitor)
        {
            if (AlbHealthmonitorId == null) { throw new System.ArgumentNullException("AlbHealthmonitorId cannot be null"); }
            if (AlbhealthMonitor == null) { throw new System.ArgumentNullException("AlbhealthMonitor cannot be null"); }
            StringBuilder UpdateAlbhealthMonitorServiceURL = new StringBuilder("/infra/alb-health-monitors/{alb-healthmonitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbhealthMonitorServiceURL.Replace("{alb-healthmonitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHealthmonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhealthMonitor);
            request.Resource = UpdateAlbhealthMonitorServiceURL.ToString();
            RestResponse<NSXTALBHealthMonitorType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthMonitorType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbhealthMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHealthMonitorType> ReadAlbhealthMonitor(string AlbHealthmonitorId)
        {
            if (AlbHealthmonitorId == null) { throw new System.ArgumentNullException("AlbHealthmonitorId cannot be null"); }
            StringBuilder ReadAlbhealthMonitorServiceURL = new StringBuilder("/infra/alb-health-monitors/{alb-healthmonitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbhealthMonitorServiceURL.Replace("{alb-healthmonitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHealthmonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbhealthMonitorServiceURL.ToString();
            RestResponse<NSXTALBHealthMonitorType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHealthMonitorType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbhealthMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbhealthMonitor(string AlbHealthmonitorId, bool? Force = null)
        {
            if (AlbHealthmonitorId == null) { throw new System.ArgumentNullException("AlbHealthmonitorId cannot be null"); }
            StringBuilder DeleteAlbhealthMonitorServiceURL = new StringBuilder("/infra/alb-health-monitors/{alb-healthmonitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbhealthMonitorServiceURL.Replace("{alb-healthmonitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHealthmonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbhealthMonitorServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbhealthMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbhealthMonitor(string AlbHealthmonitorId, NSXTALBHealthMonitorType AlbhealthMonitor)
        {
            if (AlbHealthmonitorId == null) { throw new System.ArgumentNullException("AlbHealthmonitorId cannot be null"); }
            if (AlbhealthMonitor == null) { throw new System.ArgumentNullException("AlbhealthMonitor cannot be null"); }
            StringBuilder PatchAlbhealthMonitorServiceURL = new StringBuilder("/infra/alb-health-monitors/{alb-healthmonitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbhealthMonitorServiceURL.Replace("{alb-healthmonitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbHealthmonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbhealthMonitor);
            request.Resource = PatchAlbhealthMonitorServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbhealthMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupApiResponseType> ListAlbpoolGroup(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbpoolGroupServiceURL = new StringBuilder("/infra/alb-pool-groups");
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
            request.Resource = ListAlbpoolGroupServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbpoolGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPriorityLabelsType> UpdateAlbpriorityLabels(string AlbPrioritylabelsId, NSXTALBPriorityLabelsType AlbpriorityLabels)
        {
            if (AlbPrioritylabelsId == null) { throw new System.ArgumentNullException("AlbPrioritylabelsId cannot be null"); }
            if (AlbpriorityLabels == null) { throw new System.ArgumentNullException("AlbpriorityLabels cannot be null"); }
            StringBuilder UpdateAlbpriorityLabelsServiceURL = new StringBuilder("/infra/alb-priority-labels/{alb-prioritylabels-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbpriorityLabelsServiceURL.Replace("{alb-prioritylabels-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPrioritylabelsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpriorityLabels);
            request.Resource = UpdateAlbpriorityLabelsServiceURL.ToString();
            RestResponse<NSXTALBPriorityLabelsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPriorityLabelsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbpriorityLabelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPriorityLabelsType> ReadAlbpriorityLabels(string AlbPrioritylabelsId)
        {
            if (AlbPrioritylabelsId == null) { throw new System.ArgumentNullException("AlbPrioritylabelsId cannot be null"); }
            StringBuilder ReadAlbpriorityLabelsServiceURL = new StringBuilder("/infra/alb-priority-labels/{alb-prioritylabels-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbpriorityLabelsServiceURL.Replace("{alb-prioritylabels-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPrioritylabelsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbpriorityLabelsServiceURL.ToString();
            RestResponse<NSXTALBPriorityLabelsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPriorityLabelsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbpriorityLabelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbpriorityLabels(string AlbPrioritylabelsId, NSXTALBPriorityLabelsType AlbpriorityLabels)
        {
            if (AlbPrioritylabelsId == null) { throw new System.ArgumentNullException("AlbPrioritylabelsId cannot be null"); }
            if (AlbpriorityLabels == null) { throw new System.ArgumentNullException("AlbpriorityLabels cannot be null"); }
            StringBuilder PatchAlbpriorityLabelsServiceURL = new StringBuilder("/infra/alb-priority-labels/{alb-prioritylabels-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbpriorityLabelsServiceURL.Replace("{alb-prioritylabels-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPrioritylabelsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpriorityLabels);
            request.Resource = PatchAlbpriorityLabelsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbpriorityLabelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbpriorityLabels(string AlbPrioritylabelsId, bool? Force = null)
        {
            if (AlbPrioritylabelsId == null) { throw new System.ArgumentNullException("AlbPrioritylabelsId cannot be null"); }
            StringBuilder DeleteAlbpriorityLabelsServiceURL = new StringBuilder("/infra/alb-priority-labels/{alb-prioritylabels-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbpriorityLabelsServiceURL.Replace("{alb-prioritylabels-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPrioritylabelsId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbpriorityLabelsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbpriorityLabelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPKIProfileApiResponseType> ListAlbpkiprofile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbpkiprofileServiceURL = new StringBuilder("/infra/alb-pki-profiles");
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
            request.Resource = ListAlbpkiprofileServiceURL.ToString();
            RestResponse<NSXTALBPKIProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPKIProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbpkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBIpAddrGroupApiResponseType> ListAlbipAddrGroup(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbipAddrGroupServiceURL = new StringBuilder("/infra/alb-ip-addr-groups");
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
            request.Resource = ListAlbipAddrGroupServiceURL.ToString();
            RestResponse<NSXTALBIpAddrGroupApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBIpAddrGroupApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbipAddrGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAuthProfileApiResponseType> ListAlbauthProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbauthProfileServiceURL = new StringBuilder("/infra/alb-auth-profiles");
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
            request.Resource = ListAlbauthProfileServiceURL.ToString();
            RestResponse<NSXTALBAuthProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAuthProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbauthProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVsVipApiResponseType> ListAlbvsVip(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbvsVipServiceURL = new StringBuilder("/infra/alb-vs-vips");
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
            request.Resource = ListAlbvsVipServiceURL.ToString();
            RestResponse<NSXTALBVsVipApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVsVipApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbvsVipServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageProfileType> UpdateAlberrorPageProfile(string AlbErrorpageprofileId, NSXTALBErrorPageProfileType AlberrorPageProfile)
        {
            if (AlbErrorpageprofileId == null) { throw new System.ArgumentNullException("AlbErrorpageprofileId cannot be null"); }
            if (AlberrorPageProfile == null) { throw new System.ArgumentNullException("AlberrorPageProfile cannot be null"); }
            StringBuilder UpdateAlberrorPageProfileServiceURL = new StringBuilder("/infra/alb-error-page-profiles/{alb-errorpageprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlberrorPageProfileServiceURL.Replace("{alb-errorpageprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpageprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlberrorPageProfile);
            request.Resource = UpdateAlberrorPageProfileServiceURL.ToString();
            RestResponse<NSXTALBErrorPageProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlberrorPageProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlberrorPageProfile(string AlbErrorpageprofileId, bool? Force = null)
        {
            if (AlbErrorpageprofileId == null) { throw new System.ArgumentNullException("AlbErrorpageprofileId cannot be null"); }
            StringBuilder DeleteAlberrorPageProfileServiceURL = new StringBuilder("/infra/alb-error-page-profiles/{alb-errorpageprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlberrorPageProfileServiceURL.Replace("{alb-errorpageprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpageprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlberrorPageProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlberrorPageProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageProfileType> ReadAlberrorPageProfile(string AlbErrorpageprofileId)
        {
            if (AlbErrorpageprofileId == null) { throw new System.ArgumentNullException("AlbErrorpageprofileId cannot be null"); }
            StringBuilder ReadAlberrorPageProfileServiceURL = new StringBuilder("/infra/alb-error-page-profiles/{alb-errorpageprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlberrorPageProfileServiceURL.Replace("{alb-errorpageprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpageprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlberrorPageProfileServiceURL.ToString();
            RestResponse<NSXTALBErrorPageProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlberrorPageProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlberrorPageProfile(string AlbErrorpageprofileId, NSXTALBErrorPageProfileType AlberrorPageProfile)
        {
            if (AlbErrorpageprofileId == null) { throw new System.ArgumentNullException("AlbErrorpageprofileId cannot be null"); }
            if (AlberrorPageProfile == null) { throw new System.ArgumentNullException("AlberrorPageProfile cannot be null"); }
            StringBuilder PatchAlberrorPageProfileServiceURL = new StringBuilder("/infra/alb-error-page-profiles/{alb-errorpageprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlberrorPageProfileServiceURL.Replace("{alb-errorpageprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpageprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlberrorPageProfile);
            request.Resource = PatchAlberrorPageProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlberrorPageProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageBodyType> UpdateAlberrorPageBody(string AlbErrorpagebodyId, NSXTALBErrorPageBodyType AlberrorPageBody)
        {
            if (AlbErrorpagebodyId == null) { throw new System.ArgumentNullException("AlbErrorpagebodyId cannot be null"); }
            if (AlberrorPageBody == null) { throw new System.ArgumentNullException("AlberrorPageBody cannot be null"); }
            StringBuilder UpdateAlberrorPageBodyServiceURL = new StringBuilder("/infra/alb-error-page-bodies/{alb-errorpagebody-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlberrorPageBodyServiceURL.Replace("{alb-errorpagebody-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpagebodyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlberrorPageBody);
            request.Resource = UpdateAlberrorPageBodyServiceURL.ToString();
            RestResponse<NSXTALBErrorPageBodyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageBodyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlberrorPageBodyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlberrorPageBody(string AlbErrorpagebodyId, bool? Force = null)
        {
            if (AlbErrorpagebodyId == null) { throw new System.ArgumentNullException("AlbErrorpagebodyId cannot be null"); }
            StringBuilder DeleteAlberrorPageBodyServiceURL = new StringBuilder("/infra/alb-error-page-bodies/{alb-errorpagebody-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlberrorPageBodyServiceURL.Replace("{alb-errorpagebody-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpagebodyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlberrorPageBodyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlberrorPageBodyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageBodyType> ReadAlberrorPageBody(string AlbErrorpagebodyId)
        {
            if (AlbErrorpagebodyId == null) { throw new System.ArgumentNullException("AlbErrorpagebodyId cannot be null"); }
            StringBuilder ReadAlberrorPageBodyServiceURL = new StringBuilder("/infra/alb-error-page-bodies/{alb-errorpagebody-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlberrorPageBodyServiceURL.Replace("{alb-errorpagebody-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpagebodyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlberrorPageBodyServiceURL.ToString();
            RestResponse<NSXTALBErrorPageBodyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageBodyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlberrorPageBodyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlberrorPageBody(string AlbErrorpagebodyId, NSXTALBErrorPageBodyType AlberrorPageBody)
        {
            if (AlbErrorpagebodyId == null) { throw new System.ArgumentNullException("AlbErrorpagebodyId cannot be null"); }
            if (AlberrorPageBody == null) { throw new System.ArgumentNullException("AlberrorPageBody cannot be null"); }
            StringBuilder PatchAlberrorPageBodyServiceURL = new StringBuilder("/infra/alb-error-page-bodies/{alb-errorpagebody-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlberrorPageBodyServiceURL.Replace("{alb-errorpagebody-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbErrorpagebodyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlberrorPageBody);
            request.Resource = PatchAlberrorPageBodyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlberrorPageBodyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAnalyticsProfileApiResponseType> ListAlbanalyticsProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbanalyticsProfileServiceURL = new StringBuilder("/infra/alb-analytics-profiles");
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
            request.Resource = ListAlbanalyticsProfileServiceURL.ToString();
            RestResponse<NSXTALBAnalyticsProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnalyticsProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbanalyticsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPKIProfileType> UpdateAlbpkiprofile(string AlbPkiprofileId, NSXTALBPKIProfileType Albpkiprofile)
        {
            if (AlbPkiprofileId == null) { throw new System.ArgumentNullException("AlbPkiprofileId cannot be null"); }
            if (Albpkiprofile == null) { throw new System.ArgumentNullException("Albpkiprofile cannot be null"); }
            StringBuilder UpdateAlbpkiprofileServiceURL = new StringBuilder("/infra/alb-pki-profiles/{alb-pkiprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbpkiprofileServiceURL.Replace("{alb-pkiprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPkiprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albpkiprofile);
            request.Resource = UpdateAlbpkiprofileServiceURL.ToString();
            RestResponse<NSXTALBPKIProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPKIProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbpkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbpkiprofile(string AlbPkiprofileId, NSXTALBPKIProfileType Albpkiprofile)
        {
            if (AlbPkiprofileId == null) { throw new System.ArgumentNullException("AlbPkiprofileId cannot be null"); }
            if (Albpkiprofile == null) { throw new System.ArgumentNullException("Albpkiprofile cannot be null"); }
            StringBuilder PatchAlbpkiprofileServiceURL = new StringBuilder("/infra/alb-pki-profiles/{alb-pkiprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbpkiprofileServiceURL.Replace("{alb-pkiprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPkiprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albpkiprofile);
            request.Resource = PatchAlbpkiprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbpkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbpkiprofile(string AlbPkiprofileId, bool? Force = null)
        {
            if (AlbPkiprofileId == null) { throw new System.ArgumentNullException("AlbPkiprofileId cannot be null"); }
            StringBuilder DeleteAlbpkiprofileServiceURL = new StringBuilder("/infra/alb-pki-profiles/{alb-pkiprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbpkiprofileServiceURL.Replace("{alb-pkiprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPkiprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbpkiprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbpkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPKIProfileType> ReadAlbpkiprofile(string AlbPkiprofileId)
        {
            if (AlbPkiprofileId == null) { throw new System.ArgumentNullException("AlbPkiprofileId cannot be null"); }
            StringBuilder ReadAlbpkiprofileServiceURL = new StringBuilder("/infra/alb-pki-profiles/{alb-pkiprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbpkiprofileServiceURL.Replace("{alb-pkiprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPkiprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbpkiprofileServiceURL.ToString();
            RestResponse<NSXTALBPKIProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPKIProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbpkiprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafCRSApiResponseType> ListAlbwafCRS(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbwafCRSServiceURL = new StringBuilder("/infra/alb-waf-crs");
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
            request.Resource = ListAlbwafCRSServiceURL.ToString();
            RestResponse<NSXTALBWafCRSApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafCRSApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbwafCRSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAuthProfileType> UpdateAlbauthProfile(string AlbAuthprofileId, NSXTALBAuthProfileType AlbauthProfile)
        {
            if (AlbAuthprofileId == null) { throw new System.ArgumentNullException("AlbAuthprofileId cannot be null"); }
            if (AlbauthProfile == null) { throw new System.ArgumentNullException("AlbauthProfile cannot be null"); }
            StringBuilder UpdateAlbauthProfileServiceURL = new StringBuilder("/infra/alb-auth-profiles/{alb-authprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbauthProfileServiceURL.Replace("{alb-authprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAuthprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbauthProfile);
            request.Resource = UpdateAlbauthProfileServiceURL.ToString();
            RestResponse<NSXTALBAuthProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAuthProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbauthProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbauthProfile(string AlbAuthprofileId, NSXTALBAuthProfileType AlbauthProfile)
        {
            if (AlbAuthprofileId == null) { throw new System.ArgumentNullException("AlbAuthprofileId cannot be null"); }
            if (AlbauthProfile == null) { throw new System.ArgumentNullException("AlbauthProfile cannot be null"); }
            StringBuilder PatchAlbauthProfileServiceURL = new StringBuilder("/infra/alb-auth-profiles/{alb-authprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbauthProfileServiceURL.Replace("{alb-authprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAuthprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbauthProfile);
            request.Resource = PatchAlbauthProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbauthProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAuthProfileType> ReadAlbauthProfile(string AlbAuthprofileId)
        {
            if (AlbAuthprofileId == null) { throw new System.ArgumentNullException("AlbAuthprofileId cannot be null"); }
            StringBuilder ReadAlbauthProfileServiceURL = new StringBuilder("/infra/alb-auth-profiles/{alb-authprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbauthProfileServiceURL.Replace("{alb-authprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAuthprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbauthProfileServiceURL.ToString();
            RestResponse<NSXTALBAuthProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAuthProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbauthProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbauthProfile(string AlbAuthprofileId, bool? Force = null)
        {
            if (AlbAuthprofileId == null) { throw new System.ArgumentNullException("AlbAuthprofileId cannot be null"); }
            StringBuilder DeleteAlbauthProfileServiceURL = new StringBuilder("/infra/alb-auth-profiles/{alb-authprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbauthProfileServiceURL.Replace("{alb-authprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAuthprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbauthProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbauthProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAnalyticsProfileType> UpdateAlbanalyticsProfile(string AlbAnalyticsprofileId, NSXTALBAnalyticsProfileType AlbanalyticsProfile)
        {
            if (AlbAnalyticsprofileId == null) { throw new System.ArgumentNullException("AlbAnalyticsprofileId cannot be null"); }
            if (AlbanalyticsProfile == null) { throw new System.ArgumentNullException("AlbanalyticsProfile cannot be null"); }
            StringBuilder UpdateAlbanalyticsProfileServiceURL = new StringBuilder("/infra/alb-analytics-profiles/{alb-analyticsprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbanalyticsProfileServiceURL.Replace("{alb-analyticsprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAnalyticsprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbanalyticsProfile);
            request.Resource = UpdateAlbanalyticsProfileServiceURL.ToString();
            RestResponse<NSXTALBAnalyticsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnalyticsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbanalyticsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAnalyticsProfileType> ReadAlbanalyticsProfile(string AlbAnalyticsprofileId)
        {
            if (AlbAnalyticsprofileId == null) { throw new System.ArgumentNullException("AlbAnalyticsprofileId cannot be null"); }
            StringBuilder ReadAlbanalyticsProfileServiceURL = new StringBuilder("/infra/alb-analytics-profiles/{alb-analyticsprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbanalyticsProfileServiceURL.Replace("{alb-analyticsprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAnalyticsprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbanalyticsProfileServiceURL.ToString();
            RestResponse<NSXTALBAnalyticsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAnalyticsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbanalyticsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbanalyticsProfile(string AlbAnalyticsprofileId, NSXTALBAnalyticsProfileType AlbanalyticsProfile)
        {
            if (AlbAnalyticsprofileId == null) { throw new System.ArgumentNullException("AlbAnalyticsprofileId cannot be null"); }
            if (AlbanalyticsProfile == null) { throw new System.ArgumentNullException("AlbanalyticsProfile cannot be null"); }
            StringBuilder PatchAlbanalyticsProfileServiceURL = new StringBuilder("/infra/alb-analytics-profiles/{alb-analyticsprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbanalyticsProfileServiceURL.Replace("{alb-analyticsprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAnalyticsprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbanalyticsProfile);
            request.Resource = PatchAlbanalyticsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbanalyticsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbanalyticsProfile(string AlbAnalyticsprofileId, bool? Force = null)
        {
            if (AlbAnalyticsprofileId == null) { throw new System.ArgumentNullException("AlbAnalyticsprofileId cannot be null"); }
            StringBuilder DeleteAlbanalyticsProfileServiceURL = new StringBuilder("/infra/alb-analytics-profiles/{alb-analyticsprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbanalyticsProfileServiceURL.Replace("{alb-analyticsprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbAnalyticsprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbanalyticsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbanalyticsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBStringGroupType> UpdateAlbstringGroup(string AlbStringgroupId, NSXTALBStringGroupType AlbstringGroup)
        {
            if (AlbStringgroupId == null) { throw new System.ArgumentNullException("AlbStringgroupId cannot be null"); }
            if (AlbstringGroup == null) { throw new System.ArgumentNullException("AlbstringGroup cannot be null"); }
            StringBuilder UpdateAlbstringGroupServiceURL = new StringBuilder("/infra/alb-string-groups/{alb-stringgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbstringGroupServiceURL.Replace("{alb-stringgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbStringgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbstringGroup);
            request.Resource = UpdateAlbstringGroupServiceURL.ToString();
            RestResponse<NSXTALBStringGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBStringGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbstringGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBStringGroupType> ReadAlbstringGroup(string AlbStringgroupId)
        {
            if (AlbStringgroupId == null) { throw new System.ArgumentNullException("AlbStringgroupId cannot be null"); }
            StringBuilder ReadAlbstringGroupServiceURL = new StringBuilder("/infra/alb-string-groups/{alb-stringgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbstringGroupServiceURL.Replace("{alb-stringgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbStringgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbstringGroupServiceURL.ToString();
            RestResponse<NSXTALBStringGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBStringGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbstringGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbstringGroup(string AlbStringgroupId, bool? Force = null)
        {
            if (AlbStringgroupId == null) { throw new System.ArgumentNullException("AlbStringgroupId cannot be null"); }
            StringBuilder DeleteAlbstringGroupServiceURL = new StringBuilder("/infra/alb-string-groups/{alb-stringgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbstringGroupServiceURL.Replace("{alb-stringgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbStringgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbstringGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbstringGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbstringGroup(string AlbStringgroupId, NSXTALBStringGroupType AlbstringGroup)
        {
            if (AlbStringgroupId == null) { throw new System.ArgumentNullException("AlbStringgroupId cannot be null"); }
            if (AlbstringGroup == null) { throw new System.ArgumentNullException("AlbstringGroup cannot be null"); }
            StringBuilder PatchAlbstringGroupServiceURL = new StringBuilder("/infra/alb-string-groups/{alb-stringgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbstringGroupServiceURL.Replace("{alb-stringgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbStringgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbstringGroup);
            request.Resource = PatchAlbstringGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbstringGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyApiResponseType> ListAlbwafPolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbwafPolicyServiceURL = new StringBuilder("/infra/alb-waf-policies");
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
            request.Resource = ListAlbwafPolicyServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbwafPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBDnsPolicyApiResponseType> ListAlbdnsPolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbdnsPolicyServiceURL = new StringBuilder("/infra/alb-dns-policies");
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
            request.Resource = ListAlbdnsPolicyServiceURL.ToString();
            RestResponse<NSXTALBDnsPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBDnsPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbdnsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBErrorPageBodyApiResponseType> ListAlberrorPageBody(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlberrorPageBodyServiceURL = new StringBuilder("/infra/alb-error-page-bodies");
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
            request.Resource = ListAlberrorPageBodyServiceURL.ToString();
            RestResponse<NSXTALBErrorPageBodyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBErrorPageBodyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlberrorPageBodyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> IntiateAlbOnBoardingWorkflow(NSXTALBControllerConfigurationType AlbcontrollerConfiguration)
        {
            if (AlbcontrollerConfiguration == null) { throw new System.ArgumentNullException("AlbcontrollerConfiguration cannot be null"); }
            StringBuilder IntiateAlbOnBoardingWorkflowServiceURL = new StringBuilder("/infra/alb-onboarding-workflow");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(AlbcontrollerConfiguration);
            request.Resource = IntiateAlbOnBoardingWorkflowServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + IntiateAlbOnBoardingWorkflowServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyType> UpdateAlbwafPolicy(string AlbWafpolicyId, NSXTALBWafPolicyType AlbwafPolicy)
        {
            if (AlbWafpolicyId == null) { throw new System.ArgumentNullException("AlbWafpolicyId cannot be null"); }
            if (AlbwafPolicy == null) { throw new System.ArgumentNullException("AlbwafPolicy cannot be null"); }
            StringBuilder UpdateAlbwafPolicyServiceURL = new StringBuilder("/infra/alb-waf-policies/{alb-wafpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbwafPolicyServiceURL.Replace("{alb-wafpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafPolicy);
            request.Resource = UpdateAlbwafPolicyServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbwafPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbwafPolicy(string AlbWafpolicyId, bool? Force = null)
        {
            if (AlbWafpolicyId == null) { throw new System.ArgumentNullException("AlbWafpolicyId cannot be null"); }
            StringBuilder DeleteAlbwafPolicyServiceURL = new StringBuilder("/infra/alb-waf-policies/{alb-wafpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbwafPolicyServiceURL.Replace("{alb-wafpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbwafPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbwafPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbwafPolicy(string AlbWafpolicyId, NSXTALBWafPolicyType AlbwafPolicy)
        {
            if (AlbWafpolicyId == null) { throw new System.ArgumentNullException("AlbWafpolicyId cannot be null"); }
            if (AlbwafPolicy == null) { throw new System.ArgumentNullException("AlbwafPolicy cannot be null"); }
            StringBuilder PatchAlbwafPolicyServiceURL = new StringBuilder("/infra/alb-waf-policies/{alb-wafpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbwafPolicyServiceURL.Replace("{alb-wafpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafPolicy);
            request.Resource = PatchAlbwafPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbwafPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafPolicyType> ReadAlbwafPolicy(string AlbWafpolicyId)
        {
            if (AlbWafpolicyId == null) { throw new System.ArgumentNullException("AlbWafpolicyId cannot be null"); }
            StringBuilder ReadAlbwafPolicyServiceURL = new StringBuilder("/infra/alb-waf-policies/{alb-wafpolicy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbwafPolicyServiceURL.Replace("{alb-wafpolicy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafpolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbwafPolicyServiceURL.ToString();
            RestResponse<NSXTALBWafPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbwafPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVSDataScriptSetType> UpdateAlbvsdataScriptSet(string AlbVsdatascriptsetId, NSXTALBVSDataScriptSetType AlbvsdataScriptSet)
        {
            if (AlbVsdatascriptsetId == null) { throw new System.ArgumentNullException("AlbVsdatascriptsetId cannot be null"); }
            if (AlbvsdataScriptSet == null) { throw new System.ArgumentNullException("AlbvsdataScriptSet cannot be null"); }
            StringBuilder UpdateAlbvsdataScriptSetServiceURL = new StringBuilder("/infra/alb-vs-data-script-sets/{alb-vsdatascriptset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbvsdataScriptSetServiceURL.Replace("{alb-vsdatascriptset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsdatascriptsetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvsdataScriptSet);
            request.Resource = UpdateAlbvsdataScriptSetServiceURL.ToString();
            RestResponse<NSXTALBVSDataScriptSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVSDataScriptSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbvsdataScriptSetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbvsdataScriptSet(string AlbVsdatascriptsetId, NSXTALBVSDataScriptSetType AlbvsdataScriptSet)
        {
            if (AlbVsdatascriptsetId == null) { throw new System.ArgumentNullException("AlbVsdatascriptsetId cannot be null"); }
            if (AlbvsdataScriptSet == null) { throw new System.ArgumentNullException("AlbvsdataScriptSet cannot be null"); }
            StringBuilder PatchAlbvsdataScriptSetServiceURL = new StringBuilder("/infra/alb-vs-data-script-sets/{alb-vsdatascriptset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbvsdataScriptSetServiceURL.Replace("{alb-vsdatascriptset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsdatascriptsetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbvsdataScriptSet);
            request.Resource = PatchAlbvsdataScriptSetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbvsdataScriptSetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbvsdataScriptSet(string AlbVsdatascriptsetId, bool? Force = null)
        {
            if (AlbVsdatascriptsetId == null) { throw new System.ArgumentNullException("AlbVsdatascriptsetId cannot be null"); }
            StringBuilder DeleteAlbvsdataScriptSetServiceURL = new StringBuilder("/infra/alb-vs-data-script-sets/{alb-vsdatascriptset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbvsdataScriptSetServiceURL.Replace("{alb-vsdatascriptset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsdatascriptsetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbvsdataScriptSetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbvsdataScriptSetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVSDataScriptSetType> ReadAlbvsdataScriptSet(string AlbVsdatascriptsetId)
        {
            if (AlbVsdatascriptsetId == null) { throw new System.ArgumentNullException("AlbVsdatascriptsetId cannot be null"); }
            StringBuilder ReadAlbvsdataScriptSetServiceURL = new StringBuilder("/infra/alb-vs-data-script-sets/{alb-vsdatascriptset-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbvsdataScriptSetServiceURL.Replace("{alb-vsdatascriptset-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbVsdatascriptsetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbvsdataScriptSetServiceURL.ToString();
            RestResponse<NSXTALBVSDataScriptSetType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVSDataScriptSetType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbvsdataScriptSetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVirtualServiceApiResponseType> ListAlbvirtualService(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbvirtualServiceServiceURL = new StringBuilder("/infra/alb-virtual-services");
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
            request.Resource = ListAlbvirtualServiceServiceURL.ToString();
            RestResponse<NSXTALBVirtualServiceApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVirtualServiceApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbvirtualServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSOPolicyApiResponseType> ListAlbssopolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbssopolicyServiceURL = new StringBuilder("/infra/alb-sso-policies");
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
            request.Resource = ListAlbssopolicyServiceURL.ToString();
            RestResponse<NSXTALBSSOPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSOPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbssopolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkProfileType> UpdateAlbnetworkProfile(string AlbNetworkprofileId, NSXTALBNetworkProfileType AlbnetworkProfile)
        {
            if (AlbNetworkprofileId == null) { throw new System.ArgumentNullException("AlbNetworkprofileId cannot be null"); }
            if (AlbnetworkProfile == null) { throw new System.ArgumentNullException("AlbnetworkProfile cannot be null"); }
            StringBuilder UpdateAlbnetworkProfileServiceURL = new StringBuilder("/infra/alb-network-profiles/{alb-networkprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbnetworkProfileServiceURL.Replace("{alb-networkprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworkprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbnetworkProfile);
            request.Resource = UpdateAlbnetworkProfileServiceURL.ToString();
            RestResponse<NSXTALBNetworkProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbnetworkProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBNetworkProfileType> ReadAlbnetworkProfile(string AlbNetworkprofileId)
        {
            if (AlbNetworkprofileId == null) { throw new System.ArgumentNullException("AlbNetworkprofileId cannot be null"); }
            StringBuilder ReadAlbnetworkProfileServiceURL = new StringBuilder("/infra/alb-network-profiles/{alb-networkprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbnetworkProfileServiceURL.Replace("{alb-networkprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworkprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbnetworkProfileServiceURL.ToString();
            RestResponse<NSXTALBNetworkProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBNetworkProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbnetworkProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbnetworkProfile(string AlbNetworkprofileId, bool? Force = null)
        {
            if (AlbNetworkprofileId == null) { throw new System.ArgumentNullException("AlbNetworkprofileId cannot be null"); }
            StringBuilder DeleteAlbnetworkProfileServiceURL = new StringBuilder("/infra/alb-network-profiles/{alb-networkprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbnetworkProfileServiceURL.Replace("{alb-networkprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworkprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbnetworkProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbnetworkProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbnetworkProfile(string AlbNetworkprofileId, NSXTALBNetworkProfileType AlbnetworkProfile)
        {
            if (AlbNetworkprofileId == null) { throw new System.ArgumentNullException("AlbNetworkprofileId cannot be null"); }
            if (AlbnetworkProfile == null) { throw new System.ArgumentNullException("AlbnetworkProfile cannot be null"); }
            StringBuilder PatchAlbnetworkProfileServiceURL = new StringBuilder("/infra/alb-network-profiles/{alb-networkprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbnetworkProfileServiceURL.Replace("{alb-networkprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbNetworkprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbnetworkProfile);
            request.Resource = PatchAlbnetworkProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbnetworkProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafProfileType> UpdateAlbwafProfile(string AlbWafprofileId, NSXTALBWafProfileType AlbwafProfile)
        {
            if (AlbWafprofileId == null) { throw new System.ArgumentNullException("AlbWafprofileId cannot be null"); }
            if (AlbwafProfile == null) { throw new System.ArgumentNullException("AlbwafProfile cannot be null"); }
            StringBuilder UpdateAlbwafProfileServiceURL = new StringBuilder("/infra/alb-waf-profiles/{alb-wafprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbwafProfileServiceURL.Replace("{alb-wafprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafProfile);
            request.Resource = UpdateAlbwafProfileServiceURL.ToString();
            RestResponse<NSXTALBWafProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbwafProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafProfileType> ReadAlbwafProfile(string AlbWafprofileId)
        {
            if (AlbWafprofileId == null) { throw new System.ArgumentNullException("AlbWafprofileId cannot be null"); }
            StringBuilder ReadAlbwafProfileServiceURL = new StringBuilder("/infra/alb-waf-profiles/{alb-wafprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbwafProfileServiceURL.Replace("{alb-wafprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbwafProfileServiceURL.ToString();
            RestResponse<NSXTALBWafProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbwafProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbwafProfile(string AlbWafprofileId, NSXTALBWafProfileType AlbwafProfile)
        {
            if (AlbWafprofileId == null) { throw new System.ArgumentNullException("AlbWafprofileId cannot be null"); }
            if (AlbwafProfile == null) { throw new System.ArgumentNullException("AlbwafProfile cannot be null"); }
            StringBuilder PatchAlbwafProfileServiceURL = new StringBuilder("/infra/alb-waf-profiles/{alb-wafprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbwafProfileServiceURL.Replace("{alb-wafprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbwafProfile);
            request.Resource = PatchAlbwafProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbwafProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbwafProfile(string AlbWafprofileId, bool? Force = null)
        {
            if (AlbWafprofileId == null) { throw new System.ArgumentNullException("AlbWafprofileId cannot be null"); }
            StringBuilder DeleteAlbwafProfileServiceURL = new StringBuilder("/infra/alb-waf-profiles/{alb-wafprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbwafProfileServiceURL.Replace("{alb-wafprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbWafprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbwafProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbwafProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationProfileType> UpdateAlbapplicationProfile(string AlbApplicationprofileId, NSXTALBApplicationProfileType AlbapplicationProfile)
        {
            if (AlbApplicationprofileId == null) { throw new System.ArgumentNullException("AlbApplicationprofileId cannot be null"); }
            if (AlbapplicationProfile == null) { throw new System.ArgumentNullException("AlbapplicationProfile cannot be null"); }
            StringBuilder UpdateAlbapplicationProfileServiceURL = new StringBuilder("/infra/alb-application-profiles/{alb-applicationprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbapplicationProfileServiceURL.Replace("{alb-applicationprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbapplicationProfile);
            request.Resource = UpdateAlbapplicationProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbapplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationProfileType> ReadAlbapplicationProfile(string AlbApplicationprofileId)
        {
            if (AlbApplicationprofileId == null) { throw new System.ArgumentNullException("AlbApplicationprofileId cannot be null"); }
            StringBuilder ReadAlbapplicationProfileServiceURL = new StringBuilder("/infra/alb-application-profiles/{alb-applicationprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbapplicationProfileServiceURL.Replace("{alb-applicationprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbapplicationProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbapplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbapplicationProfile(string AlbApplicationprofileId, bool? Force = null)
        {
            if (AlbApplicationprofileId == null) { throw new System.ArgumentNullException("AlbApplicationprofileId cannot be null"); }
            StringBuilder DeleteAlbapplicationProfileServiceURL = new StringBuilder("/infra/alb-application-profiles/{alb-applicationprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbapplicationProfileServiceURL.Replace("{alb-applicationprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbapplicationProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbapplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbapplicationProfile(string AlbApplicationprofileId, NSXTALBApplicationProfileType AlbapplicationProfile)
        {
            if (AlbApplicationprofileId == null) { throw new System.ArgumentNullException("AlbApplicationprofileId cannot be null"); }
            if (AlbapplicationProfile == null) { throw new System.ArgumentNullException("AlbapplicationProfile cannot be null"); }
            StringBuilder PatchAlbapplicationProfileServiceURL = new StringBuilder("/infra/alb-application-profiles/{alb-applicationprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbapplicationProfileServiceURL.Replace("{alb-applicationprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbapplicationProfile);
            request.Resource = PatchAlbapplicationProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbapplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBControllerVersionType> ReadAlbcontrollerSupportedVersion()
        {
            StringBuilder ReadAlbcontrollerSupportedVersionServiceURL = new StringBuilder("/infra/alb-controller-version");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadAlbcontrollerSupportedVersionServiceURL.ToString();
            RestResponse<NSXTALBControllerVersionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBControllerVersionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbcontrollerSupportedVersionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBVSDataScriptSetApiResponseType> ListAlbvsdataScriptSet(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbvsdataScriptSetServiceURL = new StringBuilder("/infra/alb-vs-data-script-sets");
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
            request.Resource = ListAlbvsdataScriptSetServiceURL.ToString();
            RestResponse<NSXTALBVSDataScriptSetApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBVSDataScriptSetApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbvsdataScriptSetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLKeyAndCertificateType> UpdateAlbsslkeyAndCertificate(string AlbSslkeyandcertificateId, NSXTALBSSLKeyAndCertificateType AlbsslkeyAndCertificate)
        {
            if (AlbSslkeyandcertificateId == null) { throw new System.ArgumentNullException("AlbSslkeyandcertificateId cannot be null"); }
            if (AlbsslkeyAndCertificate == null) { throw new System.ArgumentNullException("AlbsslkeyAndCertificate cannot be null"); }
            StringBuilder UpdateAlbsslkeyAndCertificateServiceURL = new StringBuilder("/infra/alb-ssl-key-and-certificates/{alb-sslkeyandcertificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbsslkeyAndCertificateServiceURL.Replace("{alb-sslkeyandcertificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslkeyandcertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbsslkeyAndCertificate);
            request.Resource = UpdateAlbsslkeyAndCertificateServiceURL.ToString();
            RestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbsslkeyAndCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbsslkeyAndCertificate(string AlbSslkeyandcertificateId, bool? Force = null)
        {
            if (AlbSslkeyandcertificateId == null) { throw new System.ArgumentNullException("AlbSslkeyandcertificateId cannot be null"); }
            StringBuilder DeleteAlbsslkeyAndCertificateServiceURL = new StringBuilder("/infra/alb-ssl-key-and-certificates/{alb-sslkeyandcertificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbsslkeyAndCertificateServiceURL.Replace("{alb-sslkeyandcertificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslkeyandcertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbsslkeyAndCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbsslkeyAndCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbsslkeyAndCertificate(string AlbSslkeyandcertificateId, NSXTALBSSLKeyAndCertificateType AlbsslkeyAndCertificate)
        {
            if (AlbSslkeyandcertificateId == null) { throw new System.ArgumentNullException("AlbSslkeyandcertificateId cannot be null"); }
            if (AlbsslkeyAndCertificate == null) { throw new System.ArgumentNullException("AlbsslkeyAndCertificate cannot be null"); }
            StringBuilder PatchAlbsslkeyAndCertificateServiceURL = new StringBuilder("/infra/alb-ssl-key-and-certificates/{alb-sslkeyandcertificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbsslkeyAndCertificateServiceURL.Replace("{alb-sslkeyandcertificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslkeyandcertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbsslkeyAndCertificate);
            request.Resource = PatchAlbsslkeyAndCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbsslkeyAndCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLKeyAndCertificateType> ReadAlbsslkeyAndCertificate(string AlbSslkeyandcertificateId)
        {
            if (AlbSslkeyandcertificateId == null) { throw new System.ArgumentNullException("AlbSslkeyandcertificateId cannot be null"); }
            StringBuilder ReadAlbsslkeyAndCertificateServiceURL = new StringBuilder("/infra/alb-ssl-key-and-certificates/{alb-sslkeyandcertificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbsslkeyAndCertificateServiceURL.Replace("{alb-sslkeyandcertificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslkeyandcertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbsslkeyAndCertificateServiceURL.ToString();
            RestResponse<NSXTALBSSLKeyAndCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLKeyAndCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbsslkeyAndCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupType> UpdateAlbpoolGroup(string AlbPoolgroupId, NSXTALBPoolGroupType AlbpoolGroup)
        {
            if (AlbPoolgroupId == null) { throw new System.ArgumentNullException("AlbPoolgroupId cannot be null"); }
            if (AlbpoolGroup == null) { throw new System.ArgumentNullException("AlbpoolGroup cannot be null"); }
            StringBuilder UpdateAlbpoolGroupServiceURL = new StringBuilder("/infra/alb-pool-groups/{alb-poolgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbpoolGroupServiceURL.Replace("{alb-poolgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpoolGroup);
            request.Resource = UpdateAlbpoolGroupServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbpoolGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbpoolGroup(string AlbPoolgroupId, bool? Force = null)
        {
            if (AlbPoolgroupId == null) { throw new System.ArgumentNullException("AlbPoolgroupId cannot be null"); }
            StringBuilder DeleteAlbpoolGroupServiceURL = new StringBuilder("/infra/alb-pool-groups/{alb-poolgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbpoolGroupServiceURL.Replace("{alb-poolgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbpoolGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbpoolGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupType> ReadAlbpoolGroup(string AlbPoolgroupId)
        {
            if (AlbPoolgroupId == null) { throw new System.ArgumentNullException("AlbPoolgroupId cannot be null"); }
            StringBuilder ReadAlbpoolGroupServiceURL = new StringBuilder("/infra/alb-pool-groups/{alb-poolgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbpoolGroupServiceURL.Replace("{alb-poolgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbpoolGroupServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbpoolGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbpoolGroup(string AlbPoolgroupId, NSXTALBPoolGroupType AlbpoolGroup)
        {
            if (AlbPoolgroupId == null) { throw new System.ArgumentNullException("AlbPoolgroupId cannot be null"); }
            if (AlbpoolGroup == null) { throw new System.ArgumentNullException("AlbpoolGroup cannot be null"); }
            StringBuilder PatchAlbpoolGroupServiceURL = new StringBuilder("/infra/alb-pool-groups/{alb-poolgroup-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbpoolGroupServiceURL.Replace("{alb-poolgroup-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbPoolgroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbpoolGroup);
            request.Resource = PatchAlbpoolGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbpoolGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBPoolGroupDeploymentPolicyApiResponseType> ListAlbpoolGroupDeploymentPolicy(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbpoolGroupDeploymentPolicyServiceURL = new StringBuilder("/infra/alb-pool-group-deployment-policies");
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
            request.Resource = ListAlbpoolGroupDeploymentPolicyServiceURL.ToString();
            RestResponse<NSXTALBPoolGroupDeploymentPolicyApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBPoolGroupDeploymentPolicyApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbpoolGroupDeploymentPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLProfileType> UpdateAlbsslprofile(string AlbSslprofileId, NSXTALBSSLProfileType Albsslprofile)
        {
            if (AlbSslprofileId == null) { throw new System.ArgumentNullException("AlbSslprofileId cannot be null"); }
            if (Albsslprofile == null) { throw new System.ArgumentNullException("Albsslprofile cannot be null"); }
            StringBuilder UpdateAlbsslprofileServiceURL = new StringBuilder("/infra/alb-ssl-profiles/{alb-sslprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbsslprofileServiceURL.Replace("{alb-sslprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albsslprofile);
            request.Resource = UpdateAlbsslprofileServiceURL.ToString();
            RestResponse<NSXTALBSSLProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbsslprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBSSLProfileType> ReadAlbsslprofile(string AlbSslprofileId)
        {
            if (AlbSslprofileId == null) { throw new System.ArgumentNullException("AlbSslprofileId cannot be null"); }
            StringBuilder ReadAlbsslprofileServiceURL = new StringBuilder("/infra/alb-ssl-profiles/{alb-sslprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbsslprofileServiceURL.Replace("{alb-sslprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbsslprofileServiceURL.ToString();
            RestResponse<NSXTALBSSLProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBSSLProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbsslprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbsslprofile(string AlbSslprofileId, NSXTALBSSLProfileType Albsslprofile)
        {
            if (AlbSslprofileId == null) { throw new System.ArgumentNullException("AlbSslprofileId cannot be null"); }
            if (Albsslprofile == null) { throw new System.ArgumentNullException("Albsslprofile cannot be null"); }
            StringBuilder PatchAlbsslprofileServiceURL = new StringBuilder("/infra/alb-ssl-profiles/{alb-sslprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbsslprofileServiceURL.Replace("{alb-sslprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Albsslprofile);
            request.Resource = PatchAlbsslprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbsslprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbsslprofile(string AlbSslprofileId, bool? Force = null)
        {
            if (AlbSslprofileId == null) { throw new System.ArgumentNullException("AlbSslprofileId cannot be null"); }
            StringBuilder DeleteAlbsslprofileServiceURL = new StringBuilder("/infra/alb-ssl-profiles/{alb-sslprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbsslprofileServiceURL.Replace("{alb-sslprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbSslprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbsslprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbsslprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationPersistenceProfileType> UpdateAlbapplicationPersistenceProfile(string AlbApplicationpersistenceprofileId, NSXTALBApplicationPersistenceProfileType AlbapplicationPersistenceProfile)
        {
            if (AlbApplicationpersistenceprofileId == null) { throw new System.ArgumentNullException("AlbApplicationpersistenceprofileId cannot be null"); }
            if (AlbapplicationPersistenceProfile == null) { throw new System.ArgumentNullException("AlbapplicationPersistenceProfile cannot be null"); }
            StringBuilder UpdateAlbapplicationPersistenceProfileServiceURL = new StringBuilder("/infra/alb-application-persistence-profiles/{alb-applicationpersistenceprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbapplicationPersistenceProfileServiceURL.Replace("{alb-applicationpersistenceprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationpersistenceprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbapplicationPersistenceProfile);
            request.Resource = UpdateAlbapplicationPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbapplicationPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbapplicationPersistenceProfile(string AlbApplicationpersistenceprofileId, bool? Force = null)
        {
            if (AlbApplicationpersistenceprofileId == null) { throw new System.ArgumentNullException("AlbApplicationpersistenceprofileId cannot be null"); }
            StringBuilder DeleteAlbapplicationPersistenceProfileServiceURL = new StringBuilder("/infra/alb-application-persistence-profiles/{alb-applicationpersistenceprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbapplicationPersistenceProfileServiceURL.Replace("{alb-applicationpersistenceprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationpersistenceprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbapplicationPersistenceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbapplicationPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbapplicationPersistenceProfile(string AlbApplicationpersistenceprofileId, NSXTALBApplicationPersistenceProfileType AlbapplicationPersistenceProfile)
        {
            if (AlbApplicationpersistenceprofileId == null) { throw new System.ArgumentNullException("AlbApplicationpersistenceprofileId cannot be null"); }
            if (AlbapplicationPersistenceProfile == null) { throw new System.ArgumentNullException("AlbapplicationPersistenceProfile cannot be null"); }
            StringBuilder PatchAlbapplicationPersistenceProfileServiceURL = new StringBuilder("/infra/alb-application-persistence-profiles/{alb-applicationpersistenceprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbapplicationPersistenceProfileServiceURL.Replace("{alb-applicationpersistenceprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationpersistenceprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbapplicationPersistenceProfile);
            request.Resource = PatchAlbapplicationPersistenceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbapplicationPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBApplicationPersistenceProfileType> ReadAlbapplicationPersistenceProfile(string AlbApplicationpersistenceprofileId)
        {
            if (AlbApplicationpersistenceprofileId == null) { throw new System.ArgumentNullException("AlbApplicationpersistenceprofileId cannot be null"); }
            StringBuilder ReadAlbapplicationPersistenceProfileServiceURL = new StringBuilder("/infra/alb-application-persistence-profiles/{alb-applicationpersistenceprofile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbapplicationPersistenceProfileServiceURL.Replace("{alb-applicationpersistenceprofile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbApplicationpersistenceprofileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbapplicationPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTALBApplicationPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBApplicationPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbapplicationPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBHTTPPolicySetApiResponseType> ListAlbhttppolicySet(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbhttppolicySetServiceURL = new StringBuilder("/infra/alb-http-policy-sets");
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
            request.Resource = ListAlbhttppolicySetServiceURL.ToString();
            RestResponse<NSXTALBHTTPPolicySetApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBHTTPPolicySetApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbhttppolicySetServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBProtocolParserType> UpdateAlbprotocolParser(string AlbProtocolparserId, NSXTALBProtocolParserType AlbprotocolParser)
        {
            if (AlbProtocolparserId == null) { throw new System.ArgumentNullException("AlbProtocolparserId cannot be null"); }
            if (AlbprotocolParser == null) { throw new System.ArgumentNullException("AlbprotocolParser cannot be null"); }
            StringBuilder UpdateAlbprotocolParserServiceURL = new StringBuilder("/infra/alb-protocol-parsers/{alb-protocolparser-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAlbprotocolParserServiceURL.Replace("{alb-protocolparser-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbProtocolparserId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbprotocolParser);
            request.Resource = UpdateAlbprotocolParserServiceURL.ToString();
            RestResponse<NSXTALBProtocolParserType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBProtocolParserType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAlbprotocolParserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchAlbprotocolParser(string AlbProtocolparserId, NSXTALBProtocolParserType AlbprotocolParser)
        {
            if (AlbProtocolparserId == null) { throw new System.ArgumentNullException("AlbProtocolparserId cannot be null"); }
            if (AlbprotocolParser == null) { throw new System.ArgumentNullException("AlbprotocolParser cannot be null"); }
            StringBuilder PatchAlbprotocolParserServiceURL = new StringBuilder("/infra/alb-protocol-parsers/{alb-protocolparser-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchAlbprotocolParserServiceURL.Replace("{alb-protocolparser-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbProtocolparserId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AlbprotocolParser);
            request.Resource = PatchAlbprotocolParserServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchAlbprotocolParserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBProtocolParserType> ReadAlbprotocolParser(string AlbProtocolparserId)
        {
            if (AlbProtocolparserId == null) { throw new System.ArgumentNullException("AlbProtocolparserId cannot be null"); }
            StringBuilder ReadAlbprotocolParserServiceURL = new StringBuilder("/infra/alb-protocol-parsers/{alb-protocolparser-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAlbprotocolParserServiceURL.Replace("{alb-protocolparser-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbProtocolparserId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAlbprotocolParserServiceURL.ToString();
            RestResponse<NSXTALBProtocolParserType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBProtocolParserType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAlbprotocolParserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAlbprotocolParser(string AlbProtocolparserId, bool? Force = null)
        {
            if (AlbProtocolparserId == null) { throw new System.ArgumentNullException("AlbProtocolparserId cannot be null"); }
            StringBuilder DeleteAlbprotocolParserServiceURL = new StringBuilder("/infra/alb-protocol-parsers/{alb-protocolparser-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAlbprotocolParserServiceURL.Replace("{alb-protocolparser-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(AlbProtocolparserId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteAlbprotocolParserServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAlbprotocolParserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBAutoScaleLaunchConfigApiResponseType> ListAlbautoScaleLaunchConfig(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbautoScaleLaunchConfigServiceURL = new StringBuilder("/infra/alb-auto-scale-launch-configs");
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
            request.Resource = ListAlbautoScaleLaunchConfigServiceURL.ToString();
            RestResponse<NSXTALBAutoScaleLaunchConfigApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBAutoScaleLaunchConfigApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbautoScaleLaunchConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTALBWafProfileApiResponseType> ListAlbwafProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlbwafProfileServiceURL = new StringBuilder("/infra/alb-waf-profiles");
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
            request.Resource = ListAlbwafProfileServiceURL.ToString();
            RestResponse<NSXTALBWafProfileApiResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTALBWafProfileApiResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlbwafProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
