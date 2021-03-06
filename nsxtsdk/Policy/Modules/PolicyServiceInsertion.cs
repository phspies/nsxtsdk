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
    public class PolicyServiceInsertion
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyServiceInsertion(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTRedirectionPolicyType> CreateOrUpdateRedirectionPolicy(string DomainId, string RedirectionPolicyId, NSXTRedirectionPolicyType RedirectionPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RedirectionPolicy == null) { throw new System.ArgumentNullException("RedirectionPolicy cannot be null"); }
            StringBuilder CreateOrUpdateRedirectionPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateRedirectionPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateRedirectionPolicyServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedirectionPolicy);
            request.Resource = CreateOrUpdateRedirectionPolicyServiceURL.ToString();
            RestResponse<NSXTRedirectionPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateRedirectionPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchRedirectionPolicy(string DomainId, string RedirectionPolicyId, NSXTRedirectionPolicyType RedirectionPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RedirectionPolicy == null) { throw new System.ArgumentNullException("RedirectionPolicy cannot be null"); }
            StringBuilder PatchRedirectionPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchRedirectionPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchRedirectionPolicyServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedirectionPolicy);
            request.Resource = PatchRedirectionPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchRedirectionPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRedirectionPolicy(string DomainId, string RedirectionPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            StringBuilder DeleteRedirectionPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRedirectionPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteRedirectionPolicyServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRedirectionPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRedirectionPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionPolicyType> ReadRedirectionPolicy(string DomainId, string RedirectionPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            StringBuilder ReadRedirectionPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRedirectionPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadRedirectionPolicyServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRedirectionPolicyServiceURL.ToString();
            RestResponse<NSXTRedirectionPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRedirectionPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> UpdateServiceDefinition(string EnforcementPointId, string ServiceDefinitionId, NSXTServiceDefinitionType ServiceDefinition)
        {
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ServiceDefinitionId == null) { throw new System.ArgumentNullException("ServiceDefinitionId cannot be null"); }
            if (ServiceDefinition == null) { throw new System.ArgumentNullException("ServiceDefinition cannot be null"); }
            StringBuilder UpdateServiceDefinitionServiceURL = new StringBuilder("/enforcement-points/{enforcement-point-id}/service-definitions/{service-definition-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceDefinitionServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceDefinitionServiceURL.Replace("{service-definition-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDefinitionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceDefinition);
            request.Resource = UpdateServiceDefinitionServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceDefinitionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceDefinition(string EnforcementPointId, string ServiceDefinitionId)
        {
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ServiceDefinitionId == null) { throw new System.ArgumentNullException("ServiceDefinitionId cannot be null"); }
            StringBuilder DeleteServiceDefinitionServiceURL = new StringBuilder("/enforcement-points/{enforcement-point-id}/service-definitions/{service-definition-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceDefinitionServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceDefinitionServiceURL.Replace("{service-definition-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDefinitionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceDefinitionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceDefinitionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> ReadServiceDefinition(string EnforcementPointId, string ServiceDefinitionId)
        {
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ServiceDefinitionId == null) { throw new System.ArgumentNullException("ServiceDefinitionId cannot be null"); }
            StringBuilder ReadServiceDefinitionServiceURL = new StringBuilder("/enforcement-points/{enforcement-point-id}/service-definitions/{service-definition-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceDefinitionServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadServiceDefinitionServiceURL.Replace("{service-definition-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDefinitionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceDefinitionServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceDefinitionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceChainType> CreateServiceChain(string ServiceChainId, NSXTPolicyServiceChainType PolicyServiceChain)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            if (PolicyServiceChain == null) { throw new System.ArgumentNullException("PolicyServiceChain cannot be null"); }
            StringBuilder CreateServiceChainServiceURL = new StringBuilder("/infra/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceChain);
            request.Resource = CreateServiceChainServiceURL.ToString();
            RestResponse<NSXTPolicyServiceChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceChainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyServiceChain(string ServiceChainId)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder DeletePolicyServiceChainServiceURL = new StringBuilder("/infra/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyServiceChainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceChain(string ServiceChainId, NSXTPolicyServiceChainType PolicyServiceChain)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            if (PolicyServiceChain == null) { throw new System.ArgumentNullException("PolicyServiceChain cannot be null"); }
            StringBuilder PatchServiceChainServiceURL = new StringBuilder("/infra/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceChain);
            request.Resource = PatchServiceChainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceChainType> ReadServiceChain(string ServiceChainId)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder ReadServiceChainServiceURL = new StringBuilder("/infra/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceChainServiceURL.ToString();
            RestResponse<NSXTPolicyServiceChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceChainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionPolicyListResultType> ListRedirectionPolicies(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListRedirectionPoliciesServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListRedirectionPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRedirectionPoliciesServiceURL.ToString();
            RestResponse<NSXTRedirectionPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRedirectionPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionServiceListResultType> ReadPartnerServices(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ReadPartnerServicesServiceURL = new StringBuilder("/infra/partner-services");
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
            request.Resource = ReadPartnerServicesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPartnerServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointListResultType> ListPolicyServiceInstanceEndpoints(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ListPolicyServiceInstanceEndpointsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyServiceInstanceEndpointsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyServiceInstanceEndpointsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyServiceInstanceEndpointsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyServiceInstanceEndpointsServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyServiceInstanceEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceProfileListResultType> ListPolicyServiceProfiles(string ServiceReferenceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            StringBuilder ListPolicyServiceProfilesServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyServiceProfilesServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyServiceProfilesServiceURL.ToString();
            RestResponse<NSXTPolicyServiceProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyServiceProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceStatisticsType> GetPolicyServiceInstanceStatistics(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetPolicyServiceInstanceStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyServiceInstanceStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyServiceInstanceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyServiceInstanceStatisticsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetPolicyServiceInstanceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyServiceInstanceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicySIExcludeListType> UpdateSiExcludeList(NSXTPolicySIExcludeListType PolicySiexcludeList)
        {
            if (PolicySiexcludeList == null) { throw new System.ArgumentNullException("PolicySiexcludeList cannot be null"); }
            StringBuilder UpdateSiExcludeListServiceURL = new StringBuilder("/infra/settings/service-insertion/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(PolicySiexcludeList);
            request.Resource = UpdateSiExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicySIExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicySIExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSiExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSiExcludeList(NSXTPolicySIExcludeListType PolicySiexcludeList)
        {
            if (PolicySiexcludeList == null) { throw new System.ArgumentNullException("PolicySiexcludeList cannot be null"); }
            StringBuilder PatchSiExcludeListServiceURL = new StringBuilder("/infra/settings/service-insertion/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicySiexcludeList);
            request.Resource = PatchSiExcludeListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSiExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicySIExcludeListType> GetSiExcludeList()
        {
            StringBuilder GetSiExcludeListServiceURL = new StringBuilder("/infra/settings/service-insertion/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicySIExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicySIExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> CreateOrUpdateVirtualEndpoint(string Tier0Id, string LocaleServiceId, string VirtualEndpointId, NSXTVirtualEndpointType VirtualEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            if (VirtualEndpoint == null) { throw new System.ArgumentNullException("VirtualEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateVirtualEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateVirtualEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateVirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateVirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VirtualEndpoint);
            request.Resource = CreateOrUpdateVirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateVirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> PatchVirtualEndpoint(string Tier0Id, string LocaleServiceId, string VirtualEndpointId, NSXTVirtualEndpointType VirtualEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            if (VirtualEndpoint == null) { throw new System.ArgumentNullException("VirtualEndpoint cannot be null"); }
            StringBuilder PatchVirtualEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchVirtualEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchVirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchVirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VirtualEndpoint);
            request.Resource = PatchVirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchVirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> ReadVirtualEndpoint(string Tier0Id, string LocaleServiceId, string VirtualEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            StringBuilder ReadVirtualEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadVirtualEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadVirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadVirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadVirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadVirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteVirtualEndpoint(string Tier0Id, string LocaleServiceId, string VirtualEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            StringBuilder DeleteVirtualEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteVirtualEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteVirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteVirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteVirtualEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteVirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointType> CreateTier1ServiceInstanceEndpoint(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId, NSXTServiceInstanceEndpointType ServiceInstanceEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            if (ServiceInstanceEndpoint == null) { throw new System.ArgumentNullException("ServiceInstanceEndpoint cannot be null"); }
            StringBuilder CreateTier1ServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateTier1ServiceInstanceEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInstanceEndpoint);
            request.Resource = CreateTier1ServiceInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateTier1ServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1ServiceInstanceEndpoint(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId, NSXTServiceInstanceEndpointType ServiceInstanceEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            if (ServiceInstanceEndpoint == null) { throw new System.ArgumentNullException("ServiceInstanceEndpoint cannot be null"); }
            StringBuilder PatchTier1ServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1ServiceInstanceEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInstanceEndpoint);
            request.Resource = PatchTier1ServiceInstanceEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1ServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1PolicyServiceInstanceEndpoint(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            StringBuilder DeleteTier1PolicyServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1PolicyServiceInstanceEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1PolicyServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1PolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1PolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1PolicyServiceInstanceEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1PolicyServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointType> ReadTier1PolicyServiceInstanceEndpoint(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            StringBuilder ReadTier1PolicyServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1PolicyServiceInstanceEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1PolicyServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1PolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1PolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1PolicyServiceInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1PolicyServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceChainListResultType> ListPolicyServiceChains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyServiceChainsServiceURL = new StringBuilder("/infra/service-chains");
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
            request.Resource = ListPolicyServiceChainsServiceURL.ToString();
            RestResponse<NSXTPolicyServiceChainListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceChainListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyServiceChainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointType> CreateServiceInstanceEndpoint(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId, NSXTServiceInstanceEndpointType ServiceInstanceEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            if (ServiceInstanceEndpoint == null) { throw new System.ArgumentNullException("ServiceInstanceEndpoint cannot be null"); }
            StringBuilder CreateServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateServiceInstanceEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInstanceEndpoint);
            request.Resource = CreateServiceInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointType> ReadPolicyServiceInstanceEndpoint(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            StringBuilder ReadPolicyServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyServiceInstanceEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyServiceInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyServiceInstanceEndpoint(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            StringBuilder DeletePolicyServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyServiceInstanceEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyServiceInstanceEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceInstanceEndpoint(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, string ServiceInstanceEndpointId, NSXTServiceInstanceEndpointType ServiceInstanceEndpoint)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ServiceInstanceEndpointId == null) { throw new System.ArgumentNullException("ServiceInstanceEndpointId cannot be null"); }
            if (ServiceInstanceEndpoint == null) { throw new System.ArgumentNullException("ServiceInstanceEndpoint cannot be null"); }
            StringBuilder PatchServiceInstanceEndpointServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints/{service-instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceInstanceEndpointServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceInstanceEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceInstanceEndpointServiceURL.Replace("{service-instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInstanceEndpoint);
            request.Resource = PatchServiceInstanceEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServicePathListResultType> ReadServicePath(string ServiceChainId, string? EnforcementPointPath = null)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder ReadServicePathServiceURL = new StringBuilder("/infra/service-chains/{service-chain-id}/service-paths");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServicePathServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadServicePathServiceURL.ToString();
            RestResponse<NSXTServicePathListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServicePathListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServicePathServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointListResultType> ListTier1VirtualEndpoints(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier1VirtualEndpointsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1VirtualEndpointsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1VirtualEndpointsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1VirtualEndpointsServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1VirtualEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceProfileType> CreatePolicyServiceProfile(string ServiceReferenceId, string ServiceProfileId, NSXTPolicyServiceProfileType PolicyServiceProfile)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            if (PolicyServiceProfile == null) { throw new System.ArgumentNullException("PolicyServiceProfile cannot be null"); }
            StringBuilder CreatePolicyServiceProfileServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreatePolicyServiceProfileServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreatePolicyServiceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceProfile);
            request.Resource = CreatePolicyServiceProfileServiceURL.ToString();
            RestResponse<NSXTPolicyServiceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreatePolicyServiceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyServiceProfile(string ServiceReferenceId, string ServiceProfileId)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder DeletePolicyServiceProfileServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyServiceProfileServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyServiceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyServiceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyServiceProfile(string ServiceReferenceId, string ServiceProfileId, NSXTPolicyServiceProfileType PolicyServiceProfile)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            if (PolicyServiceProfile == null) { throw new System.ArgumentNullException("PolicyServiceProfile cannot be null"); }
            StringBuilder PatchPolicyServiceProfileServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyServiceProfileServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyServiceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceProfile);
            request.Resource = PatchPolicyServiceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyServiceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceProfileType> ReadPolicyServiceProfile(string ServiceReferenceId, string ServiceProfileId)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder ReadPolicyServiceProfileServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyServiceProfileServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyServiceProfileServiceURL.ToString();
            RestResponse<NSXTPolicyServiceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyServiceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceType> CreateByodPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, NSXTByodPolicyServiceInstanceType ByodPolicyServiceInstance)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ByodPolicyServiceInstance == null) { throw new System.ArgumentNullException("ByodPolicyServiceInstance cannot be null"); }
            StringBuilder CreateByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateByodPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ByodPolicyServiceInstance);
            request.Resource = CreateByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchByodPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, NSXTByodPolicyServiceInstanceType ByodPolicyServiceInstance)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ByodPolicyServiceInstance == null) { throw new System.ArgumentNullException("ByodPolicyServiceInstance cannot be null"); }
            StringBuilder PatchByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchByodPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ByodPolicyServiceInstance);
            request.Resource = PatchByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteByodPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeleteByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteByodPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceType> ReadByodPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ReadByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadByodPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceType> CreateTier1PolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, NSXTPolicyServiceInstanceType PolicyServiceInstance)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (PolicyServiceInstance == null) { throw new System.ArgumentNullException("PolicyServiceInstance cannot be null"); }
            StringBuilder CreateTier1PolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateTier1PolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1PolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1PolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceInstance);
            request.Resource = CreateTier1PolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateTier1PolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1PolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, NSXTPolicyServiceInstanceType PolicyServiceInstance)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (PolicyServiceInstance == null) { throw new System.ArgumentNullException("PolicyServiceInstance cannot be null"); }
            StringBuilder PatchTier1PolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1PolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1PolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1PolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceInstance);
            request.Resource = PatchTier1PolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1PolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceType> ReadTier1PolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ReadTier1PolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1PolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1PolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1PolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1PolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1PolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1PolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeleteTier1PolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1PolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1PolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1PolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1PolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1PolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RenewAuthenticationTokensForPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder RenewAuthenticationTokensForPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}?action=reauth");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RenewAuthenticationTokensForPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            RenewAuthenticationTokensForPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            RenewAuthenticationTokensForPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RenewAuthenticationTokensForPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RenewAuthenticationTokensForPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> ReadPartnerService(string ServiceName)
        {
            if (ServiceName == null) { throw new System.ArgumentNullException("ServiceName cannot be null"); }
            StringBuilder ReadPartnerServiceServiceURL = new StringBuilder("/infra/partner-services/{service-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPartnerServiceServiceURL.Replace("{service-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPartnerServiceServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPartnerServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceListResultType> ReadAllPolicyServiceInstancesForTier0(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadAllPolicyServiceInstancesForTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAllPolicyServiceInstancesForTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAllPolicyServiceInstancesForTier0ServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadAllPolicyServiceInstancesForTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAllPolicyServiceInstancesForTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceReferenceListResultType> ListServiceReferences(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListServiceReferencesServiceURL = new StringBuilder("/infra/service-references");
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
            request.Resource = ListServiceReferencesServiceURL.ToString();
            RestResponse<NSXTServiceReferenceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceReferenceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceReferencesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceType> CreateTier1ByodPolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, NSXTByodPolicyServiceInstanceType ByodPolicyServiceInstance)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ByodPolicyServiceInstance == null) { throw new System.ArgumentNullException("ByodPolicyServiceInstance cannot be null"); }
            StringBuilder CreateTier1ByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateTier1ByodPolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateTier1ByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ByodPolicyServiceInstance);
            request.Resource = CreateTier1ByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateTier1ByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceType> ReadTier1ByodPolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ReadTier1ByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1ByodPolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1ByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1ByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1ByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1ByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1ByodPolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeleteTier1ByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1ByodPolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1ByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1ByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1ByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1ByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1ByodPolicyServiceInstance(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, NSXTByodPolicyServiceInstanceType ByodPolicyServiceInstance)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (ByodPolicyServiceInstance == null) { throw new System.ArgumentNullException("ByodPolicyServiceInstance cannot be null"); }
            StringBuilder PatchTier1ByodPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1ByodPolicyServiceInstanceServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ByodPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1ByodPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ByodPolicyServiceInstance);
            request.Resource = PatchTier1ByodPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1ByodPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceEndpointListResultType> ListTier1PolicyServiceInstanceEndpoints(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ListTier1PolicyServiceInstanceEndpointsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances/{service-instance-id}/service-instance-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1PolicyServiceInstanceEndpointsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1PolicyServiceInstanceEndpointsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1PolicyServiceInstanceEndpointsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1PolicyServiceInstanceEndpointsServiceURL.ToString();
            RestResponse<NSXTServiceInstanceEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1PolicyServiceInstanceEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionRuleType> CreateOrUpdateRedirectionRule(string DomainId, string RedirectionPolicyId, string RuleId, NSXTRedirectionRuleType RedirectionRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (RedirectionRule == null) { throw new System.ArgumentNullException("RedirectionRule cannot be null"); }
            StringBuilder CreateOrUpdateRedirectionRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateRedirectionRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateRedirectionRuleServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateRedirectionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedirectionRule);
            request.Resource = CreateOrUpdateRedirectionRuleServiceURL.ToString();
            RestResponse<NSXTRedirectionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateRedirectionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchRedirectionRule(string DomainId, string RedirectionPolicyId, string RuleId, NSXTRedirectionRuleType RedirectionRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (RedirectionRule == null) { throw new System.ArgumentNullException("RedirectionRule cannot be null"); }
            StringBuilder PatchRedirectionRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchRedirectionRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchRedirectionRuleServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchRedirectionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedirectionRule);
            request.Resource = PatchRedirectionRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchRedirectionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionRuleType> ReadRedirectionRule(string DomainId, string RedirectionPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadRedirectionRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRedirectionRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadRedirectionRuleServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadRedirectionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRedirectionRuleServiceURL.ToString();
            RestResponse<NSXTRedirectionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRedirectionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRedirectionRule(string DomainId, string RedirectionPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteRedirectionRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRedirectionRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteRedirectionRuleServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteRedirectionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRedirectionRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRedirectionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceListResultType> ListByodPolicyServiceInstancesForTier0(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListByodPolicyServiceInstancesForTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/byod-service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListByodPolicyServiceInstancesForTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListByodPolicyServiceInstancesForTier0ServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListByodPolicyServiceInstancesForTier0ServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListByodPolicyServiceInstancesForTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTByodPolicyServiceInstanceListResultType> ListTier1ByodPolicyServiceInstances(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier1ByodPolicyServiceInstancesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/byod-service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier1ByodPolicyServiceInstancesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier1ByodPolicyServiceInstancesServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier1ByodPolicyServiceInstancesServiceURL.ToString();
            RestResponse<NSXTByodPolicyServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTByodPolicyServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier1ByodPolicyServiceInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceProfileGroupsType> GetPolicyServiceProfileGroups(string ServiceReferenceId, string ServiceProfileId, string? EnforcementPointPath = null)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder GetPolicyServiceProfileGroupsServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}/group-associations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyServiceProfileGroupsServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyServiceProfileGroupsServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetPolicyServiceProfileGroupsServiceURL.ToString();
            RestResponse<NSXTServiceProfileGroupsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceProfileGroupsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyServiceProfileGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceType> CreatePolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, NSXTPolicyServiceInstanceType PolicyServiceInstance)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (PolicyServiceInstance == null) { throw new System.ArgumentNullException("PolicyServiceInstance cannot be null"); }
            StringBuilder CreatePolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreatePolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreatePolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreatePolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceInstance);
            request.Resource = CreatePolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreatePolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceType> ReadPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ReadPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyServiceInstanceServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeletePolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyServiceInstance(string Tier0Id, string LocaleServiceId, string ServiceInstanceId, NSXTPolicyServiceInstanceType PolicyServiceInstance)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (PolicyServiceInstance == null) { throw new System.ArgumentNullException("PolicyServiceInstance cannot be null"); }
            StringBuilder PatchPolicyServiceInstanceServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyServiceInstanceServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyServiceInstanceServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyServiceInstance);
            request.Resource = PatchPolicyServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionRuleListResultType> ListRedirectionRules(string DomainId, string RedirectionPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (RedirectionPolicyId == null) { throw new System.ArgumentNullException("RedirectionPolicyId cannot be null"); }
            StringBuilder ListRedirectionRulesServiceURL = new StringBuilder("/infra/domains/{domain-id}/redirection-policies/{redirection-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListRedirectionRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListRedirectionRulesServiceURL.Replace("{redirection-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RedirectionPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRedirectionRulesServiceURL.ToString();
            RestResponse<NSXTRedirectionRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRedirectionRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointListResultType> ListVirtualEndpointsForTier0(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListVirtualEndpointsForTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVirtualEndpointsForTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListVirtualEndpointsForTier0ServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListVirtualEndpointsForTier0ServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualEndpointsForTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> CreateServiceDefinition(string EnforcementPointId, NSXTServiceDefinitionType ServiceDefinition)
        {
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (ServiceDefinition == null) { throw new System.ArgumentNullException("ServiceDefinition cannot be null"); }
            StringBuilder CreateServiceDefinitionServiceURL = new StringBuilder("/enforcement-points/{enforcement-point-id}/service-definitions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceDefinitionServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceDefinition);
            request.Resource = CreateServiceDefinitionServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceDefinitionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionServiceListResultType> ListServiceDefinitions(string EnforcementPointId)
        {
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder ListServiceDefinitionsServiceURL = new StringBuilder("/enforcement-points/{enforcement-point-id}/service-definitions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceDefinitionsServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceDefinitionsServiceURL.ToString();
            RestResponse<NSXTServiceInsertionServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceDefinitionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicySIExcludeListType> GetInternalSiExcludeList()
        {
            StringBuilder GetInternalSiExcludeListServiceURL = new StringBuilder("/infra/settings/service-insertion/security/exclude-list?system_owned=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetInternalSiExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicySIExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicySIExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInternalSiExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceStatisticsType> GetTier1PolicyServiceInstanceStatistics(string Tier1Id, string LocaleServiceId, string ServiceInstanceId, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetTier1PolicyServiceInstanceStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances/{service-instance-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1PolicyServiceInstanceStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyServiceInstanceStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1PolicyServiceInstanceStatisticsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1PolicyServiceInstanceStatisticsServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1PolicyServiceInstanceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> CreateOrUpdateTier1VirtualEndpoint(string Tier1Id, string LocaleServiceId, string VirtualEndpointId, NSXTVirtualEndpointType VirtualEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            if (VirtualEndpoint == null) { throw new System.ArgumentNullException("VirtualEndpoint cannot be null"); }
            StringBuilder CreateOrUpdateTier1VirtualEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier1VirtualEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier1VirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VirtualEndpoint);
            request.Resource = CreateOrUpdateTier1VirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier1VirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> PatchTier1VirtualEndpoint(string Tier1Id, string LocaleServiceId, string VirtualEndpointId, NSXTVirtualEndpointType VirtualEndpoint)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            if (VirtualEndpoint == null) { throw new System.ArgumentNullException("VirtualEndpoint cannot be null"); }
            StringBuilder PatchTier1VirtualEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1VirtualEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1VirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1VirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VirtualEndpoint);
            request.Resource = PatchTier1VirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1VirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualEndpointType> ReadTier1VirtualEndpoint(string Tier1Id, string LocaleServiceId, string VirtualEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            StringBuilder ReadTier1VirtualEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier1VirtualEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1VirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier1VirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier1VirtualEndpointServiceURL.ToString();
            RestResponse<NSXTVirtualEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier1VirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1VirtualEndpoint(string Tier1Id, string LocaleServiceId, string VirtualEndpointId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (VirtualEndpointId == null) { throw new System.ArgumentNullException("VirtualEndpointId cannot be null"); }
            StringBuilder DeleteTier1VirtualEndpointServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/endpoints/virtual-endpoints/{virtual-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1VirtualEndpointServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VirtualEndpointServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1VirtualEndpointServiceURL.Replace("{virtual-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1VirtualEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1VirtualEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceReferenceType> CreateOrUpdateServiceReference(string ServiceReferenceId, NSXTServiceReferenceType ServiceReference)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceReference == null) { throw new System.ArgumentNullException("ServiceReference cannot be null"); }
            StringBuilder CreateOrUpdateServiceReferenceServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateServiceReferenceServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceReference);
            request.Resource = CreateOrUpdateServiceReferenceServiceURL.ToString();
            RestResponse<NSXTServiceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateServiceReferenceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceReference(string ServiceReferenceId, NSXTServiceReferenceType ServiceReference)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceReference == null) { throw new System.ArgumentNullException("ServiceReference cannot be null"); }
            StringBuilder PatchServiceReferenceServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceReferenceServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceReference);
            request.Resource = PatchServiceReferenceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceReferenceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceReferenceType> ReadServiceReference(string ServiceReferenceId)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            StringBuilder ReadServiceReferenceServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceReferenceServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceReferenceServiceURL.ToString();
            RestResponse<NSXTServiceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceReferenceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceReference(string ServiceReferenceId, bool? Cascade = null)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            StringBuilder DeleteServiceReferenceServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceReferenceServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteServiceReferenceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceReferenceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedirectionPolicyListResultType> ListRedirectionPoliciesAcrossAllDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListRedirectionPoliciesAcrossAllDomainsServiceURL = new StringBuilder("/infra/domains/redirection-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRedirectionPoliciesAcrossAllDomainsServiceURL.ToString();
            RestResponse<NSXTRedirectionPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedirectionPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRedirectionPoliciesAcrossAllDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceChainMappingListResultType> ListPolicyServiceChainMappings(string ServiceReferenceId, string ServiceProfileId, string? EnforcementPointPath = null)
        {
            if (ServiceReferenceId == null) { throw new System.ArgumentNullException("ServiceReferenceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder ListPolicyServiceChainMappingsServiceURL = new StringBuilder("/infra/service-references/{service-reference-id}/service-profiles/{service-profile-id}/service-chain-mappings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyServiceChainMappingsServiceURL.Replace("{service-reference-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceReferenceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyServiceChainMappingsServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListPolicyServiceChainMappingsServiceURL.ToString();
            RestResponse<NSXTServiceChainMappingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceChainMappingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyServiceChainMappingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyServiceInstanceListResultType> ReadAllPolicyServiceInstancesForTier1(string Tier1Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ReadAllPolicyServiceInstancesForTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAllPolicyServiceInstancesForTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadAllPolicyServiceInstancesForTier1ServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadAllPolicyServiceInstancesForTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAllPolicyServiceInstancesForTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicySIStatusConfigurationType> UpdateSiStatus(NSXTPolicySIStatusConfigurationType PolicySistatusConfiguration)
        {
            if (PolicySistatusConfiguration == null) { throw new System.ArgumentNullException("PolicySistatusConfiguration cannot be null"); }
            StringBuilder UpdateSiStatusServiceURL = new StringBuilder("/infra/settings/service-insertion/security/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(PolicySistatusConfiguration);
            request.Resource = UpdateSiStatusServiceURL.ToString();
            RestResponse<NSXTPolicySIStatusConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicySIStatusConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSiStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSiStatus(NSXTPolicySIStatusConfigurationType PolicySistatusConfiguration)
        {
            if (PolicySistatusConfiguration == null) { throw new System.ArgumentNullException("PolicySistatusConfiguration cannot be null"); }
            StringBuilder PatchSiStatusServiceURL = new StringBuilder("/infra/settings/service-insertion/security/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicySistatusConfiguration);
            request.Resource = PatchSiStatusServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSiStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicySIStatusConfigurationType> GetSiStatus()
        {
            StringBuilder GetSiStatusServiceURL = new StringBuilder("/infra/settings/service-insertion/security/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiStatusServiceURL.ToString();
            RestResponse<NSXTPolicySIStatusConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicySIStatusConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
