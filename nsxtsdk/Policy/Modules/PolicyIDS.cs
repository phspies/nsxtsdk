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
    public class PolicyIDS
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIDS(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTGlobalIdsSignatureType> CreateOrUpdateGlobalIdsSignature(string SignatureId, NSXTGlobalIdsSignatureType GlobalIdsSignature)
        {
            if (SignatureId == null) { throw new System.ArgumentNullException("SignatureId cannot be null"); }
            if (GlobalIdsSignature == null) { throw new System.ArgumentNullException("GlobalIdsSignature cannot be null"); }
            StringBuilder CreateOrUpdateGlobalIdsSignatureServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/global-signatures/{signature-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateGlobalIdsSignatureServiceURL.Replace("{signature-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SignatureId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GlobalIdsSignature);
            request.Resource = CreateOrUpdateGlobalIdsSignatureServiceURL.ToString();
            RestResponse<NSXTGlobalIdsSignatureType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalIdsSignatureType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateGlobalIdsSignatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGlobalIdsSignature(string SignatureId, NSXTGlobalIdsSignatureType GlobalIdsSignature)
        {
            if (SignatureId == null) { throw new System.ArgumentNullException("SignatureId cannot be null"); }
            if (GlobalIdsSignature == null) { throw new System.ArgumentNullException("GlobalIdsSignature cannot be null"); }
            StringBuilder PatchGlobalIdsSignatureServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/global-signatures/{signature-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGlobalIdsSignatureServiceURL.Replace("{signature-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SignatureId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GlobalIdsSignature);
            request.Resource = PatchGlobalIdsSignatureServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGlobalIdsSignatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalIdsSignatureType> GetGlobalIdsSignature(string SignatureId)
        {
            if (SignatureId == null) { throw new System.ArgumentNullException("SignatureId cannot be null"); }
            StringBuilder GetGlobalIdsSignatureServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/global-signatures/{signature-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGlobalIdsSignatureServiceURL.Replace("{signature-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SignatureId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetGlobalIdsSignatureServiceURL.ToString();
            RestResponse<NSXTGlobalIdsSignatureType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalIdsSignatureType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGlobalIdsSignatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGlobalIdsSignature(string SignatureId)
        {
            if (SignatureId == null) { throw new System.ArgumentNullException("SignatureId cannot be null"); }
            StringBuilder DeleteGlobalIdsSignatureServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/global-signatures/{signature-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGlobalIdsSignatureServiceURL.Replace("{signature-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SignatureId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGlobalIdsSignatureServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGlobalIdsSignatureServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsStandaloneHostConfigType> CreateOrUpdateIdsStandaloneHostConfig(NSXTIdsStandaloneHostConfigType IdsStandaloneHostConfig)
        {
            if (IdsStandaloneHostConfig == null) { throw new System.ArgumentNullException("IdsStandaloneHostConfig cannot be null"); }
            StringBuilder CreateOrUpdateIdsStandaloneHostConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/ids-standalone-host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(IdsStandaloneHostConfig);
            request.Resource = CreateOrUpdateIdsStandaloneHostConfigServiceURL.ToString();
            RestResponse<NSXTIdsStandaloneHostConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsStandaloneHostConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIdsStandaloneHostConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsStandaloneHostConfig(NSXTIdsStandaloneHostConfigType IdsStandaloneHostConfig)
        {
            if (IdsStandaloneHostConfig == null) { throw new System.ArgumentNullException("IdsStandaloneHostConfig cannot be null"); }
            StringBuilder PatchIdsStandaloneHostConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/ids-standalone-host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(IdsStandaloneHostConfig);
            request.Resource = PatchIdsStandaloneHostConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsStandaloneHostConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsStandaloneHostConfigType> GetIdsStandaloneHostConfig()
        {
            StringBuilder GetIdsStandaloneHostConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/ids-standalone-host-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetIdsStandaloneHostConfigServiceURL.ToString();
            RestResponse<NSXTIdsStandaloneHostConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsStandaloneHostConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsStandaloneHostConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsProfileListResultType> ListIdsProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIdsProfilesServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles");
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
            request.Resource = ListIdsProfilesServiceURL.ToString();
            RestResponse<NSXTIdsProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdsProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdateIdsSignatures()
        {
            StringBuilder UpdateIdsSignaturesServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/signatures?action=update_signatures");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = UpdateIdsSignaturesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateIdsSignaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSignatureStatusType> GetIdsSignatureStatus()
        {
            StringBuilder GetIdsSignatureStatusServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/signatures/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetIdsSignatureStatusServiceURL.ToString();
            RestResponse<NSXTIdsSignatureStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSignatureStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsSignatureStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyListResultType> ListIdsSecurityPolicies(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListIdsSecurityPoliciesServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIdsSecurityPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIdsSecurityPoliciesServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdsSecurityPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleListResultType> ListIdsRules(string DomainId, string PolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder ListIdsRulesServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIdsRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListIdsRulesServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIdsRulesServiceURL.ToString();
            RestResponse<NSXTIdsRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdsRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsClusterConfigType> CreateOrUpdateIdsClusterConfig(string ClusterConfigId, NSXTIdsClusterConfigType IdsClusterConfig)
        {
            if (ClusterConfigId == null) { throw new System.ArgumentNullException("ClusterConfigId cannot be null"); }
            if (IdsClusterConfig == null) { throw new System.ArgumentNullException("IdsClusterConfig cannot be null"); }
            StringBuilder CreateOrUpdateIdsClusterConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/cluster-configs/{cluster-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIdsClusterConfigServiceURL.Replace("{cluster-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsClusterConfig);
            request.Resource = CreateOrUpdateIdsClusterConfigServiceURL.ToString();
            RestResponse<NSXTIdsClusterConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsClusterConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIdsClusterConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsClusterConfig(string ClusterConfigId, NSXTIdsClusterConfigType IdsClusterConfig)
        {
            if (ClusterConfigId == null) { throw new System.ArgumentNullException("ClusterConfigId cannot be null"); }
            if (IdsClusterConfig == null) { throw new System.ArgumentNullException("IdsClusterConfig cannot be null"); }
            StringBuilder PatchIdsClusterConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/cluster-configs/{cluster-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIdsClusterConfigServiceURL.Replace("{cluster-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsClusterConfig);
            request.Resource = PatchIdsClusterConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsClusterConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsClusterConfigType> GetIdsClusterConfig(string ClusterConfigId)
        {
            if (ClusterConfigId == null) { throw new System.ArgumentNullException("ClusterConfigId cannot be null"); }
            StringBuilder GetIdsClusterConfigServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/cluster-configs/{cluster-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsClusterConfigServiceURL.Replace("{cluster-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsClusterConfigServiceURL.ToString();
            RestResponse<NSXTIdsClusterConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsClusterConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsClusterConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyType> ReviseIdsSecurityPolicy(string DomainId, string PolicyId, NSXTIdsSecurityPolicyType IdsSecurityPolicy, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsSecurityPolicy == null) { throw new System.ArgumentNullException("IdsSecurityPolicy cannot be null"); }
            StringBuilder ReviseIdsSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseIdsSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsSecurityPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsSecurityPolicy);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseIdsSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseIdsSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsProfileSignaturesType> GetIdsProfileSignatures(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GetIdsProfileSignaturesServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles/{profile-id}/effective-signatures");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsProfileSignaturesServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsProfileSignaturesServiceURL.ToString();
            RestResponse<NSXTIdsProfileSignaturesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsProfileSignaturesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsProfileSignaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSignatureListResultType> ListIdsSignatures(string VersionId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (VersionId == null) { throw new System.ArgumentNullException("VersionId cannot be null"); }
            StringBuilder ListIdsSignaturesServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/signature-versions/{version-id}/signatures");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIdsSignaturesServiceURL.Replace("{version-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VersionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIdsSignaturesServiceURL.ToString();
            RestResponse<NSXTIdsSignatureListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSignatureListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdsSignaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsClusterConfigListResultType> ListIdsClusterConfigs(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListIdsClusterConfigsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/cluster-configs");
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
            request.Resource = ListIdsClusterConfigsServiceURL.ToString();
            RestResponse<NSXTIdsClusterConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsClusterConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdsClusterConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task MakeVersionAsActive(NSXTIdsSignatureVersionType IdsSignatureVersion)
        {
            if (IdsSignatureVersion == null) { throw new System.ArgumentNullException("IdsSignatureVersion cannot be null"); }
            StringBuilder MakeVersionAsActiveServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/signature-versions?action=make_active_version");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(IdsSignatureVersion);
            request.Resource = MakeVersionAsActiveServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + MakeVersionAsActiveServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyType> CreateOrUpdateIdsSecurityPolicy(string DomainId, string PolicyId, NSXTIdsSecurityPolicyType IdsSecurityPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsSecurityPolicy == null) { throw new System.ArgumentNullException("IdsSecurityPolicy cannot be null"); }
            StringBuilder CreateOrUpdateIdsSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIdsSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateIdsSecurityPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsSecurityPolicy);
            request.Resource = CreateOrUpdateIdsSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIdsSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIdsSecurityPolicy(string DomainId, string PolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder DeleteIdsSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIdsSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsSecurityPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIdsSecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIdsSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsSecurityPolicy(string DomainId, string PolicyId, NSXTIdsSecurityPolicyType IdsSecurityPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsSecurityPolicy == null) { throw new System.ArgumentNullException("IdsSecurityPolicy cannot be null"); }
            StringBuilder PatchIdsSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIdsSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsSecurityPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsSecurityPolicy);
            request.Resource = PatchIdsSecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyType> GetIdsSecurityPolicy(string DomainId, string PolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder GetIdsSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsSecurityPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> ReviseIdsRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            StringBuilder ReviseIdsRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseIdsRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsRule);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseIdsRuleServiceURL.ToString();
            RestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseIdsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSettingsType> UpdateIdsSettings(NSXTIdsSettingsType IdsSettings)
        {
            if (IdsSettings == null) { throw new System.ArgumentNullException("IdsSettings cannot be null"); }
            StringBuilder UpdateIdsSettingsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(IdsSettings);
            request.Resource = UpdateIdsSettingsServiceURL.ToString();
            RestResponse<NSXTIdsSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIdsSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSettingsType> GetIdsSettings()
        {
            StringBuilder GetIdsSettingsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetIdsSettingsServiceURL.ToString();
            RestResponse<NSXTIdsSettingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSettingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsSettings(NSXTIdsSettingsType IdsSettings)
        {
            if (IdsSettings == null) { throw new System.ArgumentNullException("IdsSettings cannot be null"); }
            StringBuilder PatchIdsSettingsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(IdsSettings);
            request.Resource = PatchIdsSettingsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsSettingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> CreateOrUpdateIdsRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            StringBuilder CreateOrUpdateIdsRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIdsRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateIdsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateIdsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsRule);
            request.Resource = CreateOrUpdateIdsRuleServiceURL.ToString();
            RestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIdsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            StringBuilder PatchIdsRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIdsRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsRule);
            request.Resource = PatchIdsRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> GetIdsRule(string DomainId, string PolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetIdsRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsRuleServiceURL.ToString();
            RestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIdsRule(string DomainId, string PolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteIdsRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIdsRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIdsRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIdsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalIdsSignatureListResultType> ListGlobalIdsSignatures(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListGlobalIdsSignaturesServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/global-signatures");
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
            request.Resource = ListGlobalIdsSignaturesServiceURL.ToString();
            RestResponse<NSXTGlobalIdsSignatureListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalIdsSignatureListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGlobalIdsSignaturesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsProfileType> CreateOrUpdateIdsProfile(string ProfileId, NSXTIdsProfileType IdsProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (IdsProfile == null) { throw new System.ArgumentNullException("IdsProfile cannot be null"); }
            StringBuilder CreateOrUpdateIdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateIdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsProfile);
            request.Resource = CreateOrUpdateIdsProfileServiceURL.ToString();
            RestResponse<NSXTIdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateIdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsProfile(string ProfileId, NSXTIdsProfileType IdsProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (IdsProfile == null) { throw new System.ArgumentNullException("IdsProfile cannot be null"); }
            StringBuilder PatchIdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchIdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IdsProfile);
            request.Resource = PatchIdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchIdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsProfileType> GetIdsProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder GetIdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsProfileServiceURL.ToString();
            RestResponse<NSXTIdsProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIdsProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteIdsProfileServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIdsProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIdsProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIdsProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSignatureVersionListResultType> GetIdsSignatureVersions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetIdsSignatureVersionsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/signature-versions");
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
            request.Resource = GetIdsSignatureVersionsServiceURL.ToString();
            RestResponse<NSXTIdsSignatureVersionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSignatureVersionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsSignatureVersionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
