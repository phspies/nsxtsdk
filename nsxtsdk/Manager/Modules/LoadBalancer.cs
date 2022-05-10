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
    public class LoadBalancer
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LoadBalancer(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLbAppProfileType> UpdateLoadBalancerApplicationProfile(string ApplicationProfileId, NSXTLbAppProfileType LbAppProfile)
        {
            if (ApplicationProfileId == null) { throw new System.ArgumentNullException("ApplicationProfileId cannot be null"); }
            if (LbAppProfile == null) { throw new System.ArgumentNullException("LbAppProfile cannot be null"); }
            StringBuilder UpdateLoadBalancerApplicationProfileServiceURL = new StringBuilder("/loadbalancer/application-profiles/{application-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerApplicationProfileServiceURL.Replace("{application-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplicationProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbAppProfile);
            request.Resource = UpdateLoadBalancerApplicationProfileServiceURL.ToString();
            RestResponse<NSXTLbAppProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbAppProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerApplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerApplicationProfile(string ApplicationProfileId)
        {
            if (ApplicationProfileId == null) { throw new System.ArgumentNullException("ApplicationProfileId cannot be null"); }
            StringBuilder DeleteLoadBalancerApplicationProfileServiceURL = new StringBuilder("/loadbalancer/application-profiles/{application-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerApplicationProfileServiceURL.Replace("{application-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplicationProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerApplicationProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerApplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbAppProfileType> ReadLoadBalancerApplicationProfile(string ApplicationProfileId)
        {
            if (ApplicationProfileId == null) { throw new System.ArgumentNullException("ApplicationProfileId cannot be null"); }
            StringBuilder ReadLoadBalancerApplicationProfileServiceURL = new StringBuilder("/loadbalancer/application-profiles/{application-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerApplicationProfileServiceURL.Replace("{application-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplicationProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerApplicationProfileServiceURL.ToString();
            RestResponse<NSXTLbAppProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbAppProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerApplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServerSslProfileType> CreateLoadBalancerServerSslProfile(NSXTLbServerSslProfileType LbServerSslProfile)
        {
            if (LbServerSslProfile == null) { throw new System.ArgumentNullException("LbServerSslProfile cannot be null"); }
            StringBuilder CreateLoadBalancerServerSslProfileServiceURL = new StringBuilder("/loadbalancer/server-ssl-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbServerSslProfile);
            request.Resource = CreateLoadBalancerServerSslProfileServiceURL.ToString();
            RestResponse<NSXTLbServerSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServerSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerServerSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServerSslProfileListResultType> ListLoadBalancerServerSslProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerServerSslProfilesServiceURL = new StringBuilder("/loadbalancer/server-ssl-profiles");
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
            request.Resource = ListLoadBalancerServerSslProfilesServiceURL.ToString();
            RestResponse<NSXTLbServerSslProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServerSslProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerServerSslProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceType> UpdateLoadBalancerService(string ServiceId, NSXTLbServiceType LbService)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (LbService == null) { throw new System.ArgumentNullException("LbService cannot be null"); }
            StringBuilder UpdateLoadBalancerServiceServiceURL = new StringBuilder("/loadbalancer/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbService);
            request.Resource = UpdateLoadBalancerServiceServiceURL.ToString();
            RestResponse<NSXTLbServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerService(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteLoadBalancerServiceServiceURL = new StringBuilder("/loadbalancer/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceType> ReadLoadBalancerService(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ReadLoadBalancerServiceServiceURL = new StringBuilder("/loadbalancer/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerServiceServiceURL.ToString();
            RestResponse<NSXTLbServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbRuleType> UpdateLoadBalancerRule(string RuleId, NSXTLbRuleType LbRule)
        {
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (LbRule == null) { throw new System.ArgumentNullException("LbRule cannot be null"); }
            StringBuilder UpdateLoadBalancerRuleServiceURL = new StringBuilder("/loadbalancer/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbRule);
            request.Resource = UpdateLoadBalancerRuleServiceURL.ToString();
            RestResponse<NSXTLbRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbRuleType> ReadLoadBalancerRule(string RuleId)
        {
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadLoadBalancerRuleServiceURL = new StringBuilder("/loadbalancer/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerRuleServiceURL.ToString();
            RestResponse<NSXTLbRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerRule(string RuleId)
        {
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteLoadBalancerRuleServiceURL = new StringBuilder("/loadbalancer/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolType> UpdateLoadBalancerPool(string PoolId, NSXTLbPoolType LbPool)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (LbPool == null) { throw new System.ArgumentNullException("LbPool cannot be null"); }
            StringBuilder UpdateLoadBalancerPoolServiceURL = new StringBuilder("/loadbalancer/pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbPool);
            request.Resource = UpdateLoadBalancerPoolServiceURL.ToString();
            RestResponse<NSXTLbPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolType> PerformPoolMemberAction(string PoolId, NSXTPoolMemberSettingListType PoolMemberSettingList, string Action)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            if (PoolMemberSettingList == null) { throw new System.ArgumentNullException("PoolMemberSettingList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder PerformPoolMemberActionServiceURL = new StringBuilder("/loadbalancer/pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PerformPoolMemberActionServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PoolMemberSettingList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = PerformPoolMemberActionServiceURL.ToString();
            RestResponse<NSXTLbPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformPoolMemberActionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerPool(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder DeleteLoadBalancerPoolServiceURL = new StringBuilder("/loadbalancer/pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerPoolServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolType> ReadLoadBalancerPool(string PoolId)
        {
            if (PoolId == null) { throw new System.ArgumentNullException("PoolId cannot be null"); }
            StringBuilder ReadLoadBalancerPoolServiceURL = new StringBuilder("/loadbalancer/pools/{pool-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerPoolServiceURL.Replace("{pool-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PoolId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerPoolServiceURL.ToString();
            RestResponse<NSXTLbPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbRuleType> CreateLoadBalancerRule(NSXTLbRuleType LbRule)
        {
            if (LbRule == null) { throw new System.ArgumentNullException("LbRule cannot be null"); }
            StringBuilder CreateLoadBalancerRuleServiceURL = new StringBuilder("/loadbalancer/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbRule);
            request.Resource = CreateLoadBalancerRuleServiceURL.ToString();
            RestResponse<NSXTLbRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbRuleListResultType> ListLoadBalancerRules(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerRulesServiceURL = new StringBuilder("/loadbalancer/rules");
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
            request.Resource = ListLoadBalancerRulesServiceURL.ToString();
            RestResponse<NSXTLbRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerWithRuleType> UpdateLoadBalancerVirtualServerWithRules(string VirtualServerId, NSXTLbVirtualServerWithRuleType LbVirtualServerWithRule)
        {
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            if (LbVirtualServerWithRule == null) { throw new System.ArgumentNullException("LbVirtualServerWithRule cannot be null"); }
            StringBuilder UpdateLoadBalancerVirtualServerWithRulesServiceURL = new StringBuilder("/loadbalancer/virtual-servers/{virtual-server-id}?action=update_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerVirtualServerWithRulesServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbVirtualServerWithRule);
            request.Resource = UpdateLoadBalancerVirtualServerWithRulesServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerWithRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerWithRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerVirtualServerWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPersistenceProfileType> CreateLoadBalancerPersistenceProfile(NSXTLbPersistenceProfileType LbPersistenceProfile)
        {
            if (LbPersistenceProfile == null) { throw new System.ArgumentNullException("LbPersistenceProfile cannot be null"); }
            StringBuilder CreateLoadBalancerPersistenceProfileServiceURL = new StringBuilder("/loadbalancer/persistence-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbPersistenceProfile);
            request.Resource = CreateLoadBalancerPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTLbPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPersistenceProfileListResultType> ListLoadBalancerPersistenceProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListLoadBalancerPersistenceProfilesServiceURL = new StringBuilder("/loadbalancer/persistence-profiles");
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
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListLoadBalancerPersistenceProfilesServiceURL.ToString();
            RestResponse<NSXTLbPersistenceProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPersistenceProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerPersistenceProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServerSslProfileType> UpdateLoadBalancerServerSslProfile(string ServerSslProfileId, NSXTLbServerSslProfileType LbServerSslProfile)
        {
            if (ServerSslProfileId == null) { throw new System.ArgumentNullException("ServerSslProfileId cannot be null"); }
            if (LbServerSslProfile == null) { throw new System.ArgumentNullException("LbServerSslProfile cannot be null"); }
            StringBuilder UpdateLoadBalancerServerSslProfileServiceURL = new StringBuilder("/loadbalancer/server-ssl-profiles/{server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerServerSslProfileServiceURL.Replace("{server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbServerSslProfile);
            request.Resource = UpdateLoadBalancerServerSslProfileServiceURL.ToString();
            RestResponse<NSXTLbServerSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServerSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerServerSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerServerSslProfile(string ServerSslProfileId)
        {
            if (ServerSslProfileId == null) { throw new System.ArgumentNullException("ServerSslProfileId cannot be null"); }
            StringBuilder DeleteLoadBalancerServerSslProfileServiceURL = new StringBuilder("/loadbalancer/server-ssl-profiles/{server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerServerSslProfileServiceURL.Replace("{server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerServerSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerServerSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServerSslProfileType> ReadLoadBalancerServerSslProfile(string ServerSslProfileId)
        {
            if (ServerSslProfileId == null) { throw new System.ArgumentNullException("ServerSslProfileId cannot be null"); }
            StringBuilder ReadLoadBalancerServerSslProfileServiceURL = new StringBuilder("/loadbalancer/server-ssl-profiles/{server-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerServerSslProfileServiceURL.Replace("{server-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerServerSslProfileServiceURL.ToString();
            RestResponse<NSXTLbServerSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServerSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerServerSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbNodeUsageSummaryType> ReadLoadBalancerNodeUsageSummary(bool? IncludeUsages = null)
        {
            StringBuilder ReadLoadBalancerNodeUsageSummaryServiceURL = new StringBuilder("/loadbalancer/node-usage-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IncludeUsages != null) { request.AddQueryParameter("include_usages", IncludeUsages.ToString()); }
            request.Resource = ReadLoadBalancerNodeUsageSummaryServiceURL.ToString();
            RestResponse<NSXTLbNodeUsageSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbNodeUsageSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerNodeUsageSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbNodeUsageType> ReadLoadBalancerNodeUsage(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ReadLoadBalancerNodeUsageServiceURL = new StringBuilder("/loadbalancer/usage-per-node/{node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerNodeUsageServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerNodeUsageServiceURL.ToString();
            RestResponse<NSXTLbNodeUsageType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbNodeUsageType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerNodeUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbSslCipherAndProtocolListResultType> ListLoadBalancerSslCiphersAndProtocols(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerSslCiphersAndProtocolsServiceURL = new StringBuilder("/loadbalancer/ssl/ciphers-and-protocols");
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
            request.Resource = ListLoadBalancerSslCiphersAndProtocolsServiceURL.ToString();
            RestResponse<NSXTLbSslCipherAndProtocolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbSslCipherAndProtocolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerSslCiphersAndProtocolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceDebugInfoType> ReadLoadBalancerServiceDebugInfo(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ReadLoadBalancerServiceDebugInfoServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/debug-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerServiceDebugInfoServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerServiceDebugInfoServiceURL.ToString();
            RestResponse<NSXTLbServiceDebugInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceDebugInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerServiceDebugInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbAppProfileType> CreateLoadBalancerApplicationProfile(NSXTLbAppProfileType LbAppProfile)
        {
            if (LbAppProfile == null) { throw new System.ArgumentNullException("LbAppProfile cannot be null"); }
            StringBuilder CreateLoadBalancerApplicationProfileServiceURL = new StringBuilder("/loadbalancer/application-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbAppProfile);
            request.Resource = CreateLoadBalancerApplicationProfileServiceURL.ToString();
            RestResponse<NSXTLbAppProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbAppProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerApplicationProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbAppProfileListResultType> ListLoadBalancerApplicationProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListLoadBalancerApplicationProfilesServiceURL = new StringBuilder("/loadbalancer/application-profiles");
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
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListLoadBalancerApplicationProfilesServiceURL.ToString();
            RestResponse<NSXTLbAppProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbAppProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerApplicationProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbMonitorType> UpdateLoadBalancerMonitor(string MonitorId, NSXTLbMonitorType LbMonitor)
        {
            if (MonitorId == null) { throw new System.ArgumentNullException("MonitorId cannot be null"); }
            if (LbMonitor == null) { throw new System.ArgumentNullException("LbMonitor cannot be null"); }
            StringBuilder UpdateLoadBalancerMonitorServiceURL = new StringBuilder("/loadbalancer/monitors/{monitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerMonitorServiceURL.Replace("{monitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbMonitor);
            request.Resource = UpdateLoadBalancerMonitorServiceURL.ToString();
            RestResponse<NSXTLbMonitorType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbMonitorType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbMonitorType> ReadLoadBalancerMonitor(string MonitorId)
        {
            if (MonitorId == null) { throw new System.ArgumentNullException("MonitorId cannot be null"); }
            StringBuilder ReadLoadBalancerMonitorServiceURL = new StringBuilder("/loadbalancer/monitors/{monitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerMonitorServiceURL.Replace("{monitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerMonitorServiceURL.ToString();
            RestResponse<NSXTLbMonitorType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbMonitorType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerMonitor(string MonitorId)
        {
            if (MonitorId == null) { throw new System.ArgumentNullException("MonitorId cannot be null"); }
            StringBuilder DeleteLoadBalancerMonitorServiceURL = new StringBuilder("/loadbalancer/monitors/{monitor-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerMonitorServiceURL.Replace("{monitor-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(MonitorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerMonitorServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbClientSslProfileType> UpdateLoadBalancerClientSslProfile(string ClientSslProfileId, NSXTLbClientSslProfileType LbClientSslProfile)
        {
            if (ClientSslProfileId == null) { throw new System.ArgumentNullException("ClientSslProfileId cannot be null"); }
            if (LbClientSslProfile == null) { throw new System.ArgumentNullException("LbClientSslProfile cannot be null"); }
            StringBuilder UpdateLoadBalancerClientSslProfileServiceURL = new StringBuilder("/loadbalancer/client-ssl-profiles/{client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerClientSslProfileServiceURL.Replace("{client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbClientSslProfile);
            request.Resource = UpdateLoadBalancerClientSslProfileServiceURL.ToString();
            RestResponse<NSXTLbClientSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbClientSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerClientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbClientSslProfileType> ReadLoadBalancerClientSslProfile(string ClientSslProfileId)
        {
            if (ClientSslProfileId == null) { throw new System.ArgumentNullException("ClientSslProfileId cannot be null"); }
            StringBuilder ReadLoadBalancerClientSslProfileServiceURL = new StringBuilder("/loadbalancer/client-ssl-profiles/{client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerClientSslProfileServiceURL.Replace("{client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerClientSslProfileServiceURL.ToString();
            RestResponse<NSXTLbClientSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbClientSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerClientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerClientSslProfile(string ClientSslProfileId)
        {
            if (ClientSslProfileId == null) { throw new System.ArgumentNullException("ClientSslProfileId cannot be null"); }
            StringBuilder DeleteLoadBalancerClientSslProfileServiceURL = new StringBuilder("/loadbalancer/client-ssl-profiles/{client-ssl-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerClientSslProfileServiceURL.Replace("{client-ssl-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClientSslProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerClientSslProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerClientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceUsageType> ReadLoadBalancerServiceUsage(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ReadLoadBalancerServiceUsageServiceURL = new StringBuilder("/loadbalancer/services/{service-id}/usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerServiceUsageServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerServiceUsageServiceURL.ToString();
            RestResponse<NSXTLbServiceUsageType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceUsageType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerServiceUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolType> CreateLoadBalancerPool(NSXTLbPoolType LbPool)
        {
            if (LbPool == null) { throw new System.ArgumentNullException("LbPool cannot be null"); }
            StringBuilder CreateLoadBalancerPoolServiceURL = new StringBuilder("/loadbalancer/pools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbPool);
            request.Resource = CreateLoadBalancerPoolServiceURL.ToString();
            RestResponse<NSXTLbPoolType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerPoolServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPoolListResultType> ListLoadBalancerPools(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerPoolsServiceURL = new StringBuilder("/loadbalancer/pools");
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
            request.Resource = ListLoadBalancerPoolsServiceURL.ToString();
            RestResponse<NSXTLbPoolListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPoolListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerPoolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbMonitorType> CreateLoadBalancerMonitor(NSXTLbMonitorType LbMonitor)
        {
            if (LbMonitor == null) { throw new System.ArgumentNullException("LbMonitor cannot be null"); }
            StringBuilder CreateLoadBalancerMonitorServiceURL = new StringBuilder("/loadbalancer/monitors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbMonitor);
            request.Resource = CreateLoadBalancerMonitorServiceURL.ToString();
            RestResponse<NSXTLbMonitorType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbMonitorType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerMonitorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbMonitorListResultType> ListLoadBalancerMonitors(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListLoadBalancerMonitorsServiceURL = new StringBuilder("/loadbalancer/monitors");
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
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListLoadBalancerMonitorsServiceURL.ToString();
            RestResponse<NSXTLbMonitorListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbMonitorListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerMonitorsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceType> CreateLoadBalancerService(NSXTLbServiceType LbService)
        {
            if (LbService == null) { throw new System.ArgumentNullException("LbService cannot be null"); }
            StringBuilder CreateLoadBalancerServiceServiceURL = new StringBuilder("/loadbalancer/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbService);
            request.Resource = CreateLoadBalancerServiceServiceURL.ToString();
            RestResponse<NSXTLbServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbServiceListResultType> ListLoadBalancerServices(string? Cursor = null, string? IncludedFields = null, string? LogicalRouterId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerServicesServiceURL = new StringBuilder("/loadbalancer/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LogicalRouterId != null) { request.AddQueryParameter("logical_router_id", LogicalRouterId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListLoadBalancerServicesServiceURL.ToString();
            RestResponse<NSXTLbServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerType> UpdateLoadBalancerVirtualServer(string VirtualServerId, NSXTLbVirtualServerType LbVirtualServer)
        {
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            if (LbVirtualServer == null) { throw new System.ArgumentNullException("LbVirtualServer cannot be null"); }
            StringBuilder UpdateLoadBalancerVirtualServerServiceURL = new StringBuilder("/loadbalancer/virtual-servers/{virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerVirtualServerServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbVirtualServer);
            request.Resource = UpdateLoadBalancerVirtualServerServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerVirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerVirtualServer(string VirtualServerId, bool? DeleteAssociatedRules = null)
        {
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            StringBuilder DeleteLoadBalancerVirtualServerServiceURL = new StringBuilder("/loadbalancer/virtual-servers/{virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerVirtualServerServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (DeleteAssociatedRules != null) { request.AddQueryParameter("delete_associated_rules", DeleteAssociatedRules.ToString()); }
            request.Resource = DeleteLoadBalancerVirtualServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerVirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerType> ReadLoadBalancerVirtualServer(string VirtualServerId)
        {
            if (VirtualServerId == null) { throw new System.ArgumentNullException("VirtualServerId cannot be null"); }
            StringBuilder ReadLoadBalancerVirtualServerServiceURL = new StringBuilder("/loadbalancer/virtual-servers/{virtual-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerVirtualServerServiceURL.Replace("{virtual-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerVirtualServerServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerVirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPersistenceProfileType> UpdateLoadBalancerPersistenceProfile(string PersistenceProfileId, NSXTLbPersistenceProfileType LbPersistenceProfile)
        {
            if (PersistenceProfileId == null) { throw new System.ArgumentNullException("PersistenceProfileId cannot be null"); }
            if (LbPersistenceProfile == null) { throw new System.ArgumentNullException("LbPersistenceProfile cannot be null"); }
            StringBuilder UpdateLoadBalancerPersistenceProfileServiceURL = new StringBuilder("/loadbalancer/persistence-profiles/{persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateLoadBalancerPersistenceProfileServiceURL.Replace("{persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(LbPersistenceProfile);
            request.Resource = UpdateLoadBalancerPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTLbPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLoadBalancerPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbPersistenceProfileType> ReadLoadBalancerPersistenceProfile(string PersistenceProfileId)
        {
            if (PersistenceProfileId == null) { throw new System.ArgumentNullException("PersistenceProfileId cannot be null"); }
            StringBuilder ReadLoadBalancerPersistenceProfileServiceURL = new StringBuilder("/loadbalancer/persistence-profiles/{persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadLoadBalancerPersistenceProfileServiceURL.Replace("{persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadLoadBalancerPersistenceProfileServiceURL.ToString();
            RestResponse<NSXTLbPersistenceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbPersistenceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadLoadBalancerPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLoadBalancerPersistenceProfile(string PersistenceProfileId)
        {
            if (PersistenceProfileId == null) { throw new System.ArgumentNullException("PersistenceProfileId cannot be null"); }
            StringBuilder DeleteLoadBalancerPersistenceProfileServiceURL = new StringBuilder("/loadbalancer/persistence-profiles/{persistence-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLoadBalancerPersistenceProfileServiceURL.Replace("{persistence-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PersistenceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLoadBalancerPersistenceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLoadBalancerPersistenceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbClientSslProfileType> CreateLoadBalancerClientSslProfile(NSXTLbClientSslProfileType LbClientSslProfile)
        {
            if (LbClientSslProfile == null) { throw new System.ArgumentNullException("LbClientSslProfile cannot be null"); }
            StringBuilder CreateLoadBalancerClientSslProfileServiceURL = new StringBuilder("/loadbalancer/client-ssl-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbClientSslProfile);
            request.Resource = CreateLoadBalancerClientSslProfileServiceURL.ToString();
            RestResponse<NSXTLbClientSslProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbClientSslProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerClientSslProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbClientSslProfileListResultType> ListLoadBalancerClientSslProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerClientSslProfilesServiceURL = new StringBuilder("/loadbalancer/client-ssl-profiles");
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
            request.Resource = ListLoadBalancerClientSslProfilesServiceURL.ToString();
            RestResponse<NSXTLbClientSslProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbClientSslProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerClientSslProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerType> CreateLoadBalancerVirtualServer(NSXTLbVirtualServerType LbVirtualServer)
        {
            if (LbVirtualServer == null) { throw new System.ArgumentNullException("LbVirtualServer cannot be null"); }
            StringBuilder CreateLoadBalancerVirtualServerServiceURL = new StringBuilder("/loadbalancer/virtual-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbVirtualServer);
            request.Resource = CreateLoadBalancerVirtualServerServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerVirtualServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerListResultType> ListLoadBalancerVirtualServers(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListLoadBalancerVirtualServersServiceURL = new StringBuilder("/loadbalancer/virtual-servers");
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
            request.Resource = ListLoadBalancerVirtualServersServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListLoadBalancerVirtualServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLbVirtualServerWithRuleType> CreateLoadBalancerVirtualServerWithRules(NSXTLbVirtualServerWithRuleType LbVirtualServerWithRule)
        {
            if (LbVirtualServerWithRule == null) { throw new System.ArgumentNullException("LbVirtualServerWithRule cannot be null"); }
            StringBuilder CreateLoadBalancerVirtualServerWithRulesServiceURL = new StringBuilder("/loadbalancer/virtual-servers?action=create_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(LbVirtualServerWithRule);
            request.Resource = CreateLoadBalancerVirtualServerWithRulesServiceURL.ToString();
            RestResponse<NSXTLbVirtualServerWithRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLbVirtualServerWithRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLoadBalancerVirtualServerWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
