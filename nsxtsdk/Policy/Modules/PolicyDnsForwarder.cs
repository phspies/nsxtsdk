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
    public class PolicyDnsForwarder
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyDnsForwarder(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyDnsForwarderType> UpdatePolicyDnsForwarderOnTier1(string Tier1Id, NSXTPolicyDnsForwarderType PolicyDnsForwarder)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (PolicyDnsForwarder == null) { throw new System.ArgumentNullException("PolicyDnsForwarder cannot be null"); }
            StringBuilder UpdatePolicyDnsForwarderOnTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyDnsForwarderOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarder);
            request.Resource = UpdatePolicyDnsForwarderOnTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyDnsForwarderOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyDnsForwarderOnTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder DeletePolicyDnsForwarderOnTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyDnsForwarderOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyDnsForwarderOnTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyDnsForwarderOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PerformEpactionForDnsForwarderAtTier1(string Tier1Id, string Action, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder PerformEpactionForDnsForwarderAtTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PerformEpactionForDnsForwarderAtTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = PerformEpactionForDnsForwarderAtTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformEpactionForDnsForwarderAtTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderType> ReadPolicyDnsForwarderOnTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ReadPolicyDnsForwarderOnTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyDnsForwarderOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyDnsForwarderOnTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyDnsForwarderOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyDnsForwarderOnTier1(string Tier1Id, NSXTPolicyDnsForwarderType PolicyDnsForwarder)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (PolicyDnsForwarder == null) { throw new System.ArgumentNullException("PolicyDnsForwarder cannot be null"); }
            StringBuilder PatchPolicyDnsForwarderOnTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyDnsForwarderOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarder);
            request.Resource = PatchPolicyDnsForwarderOnTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyDnsForwarderOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderType> UpdatePolicyDnsForwarderOnTier0(string Tier0Id, NSXTPolicyDnsForwarderType PolicyDnsForwarder)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PolicyDnsForwarder == null) { throw new System.ArgumentNullException("PolicyDnsForwarder cannot be null"); }
            StringBuilder UpdatePolicyDnsForwarderOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyDnsForwarderOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarder);
            request.Resource = UpdatePolicyDnsForwarderOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyDnsForwarderOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyDnsForwarderOnTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder DeletePolicyDnsForwarderOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyDnsForwarderOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyDnsForwarderOnTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyDnsForwarderOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PerformEpactionForDnsForwarderAtTier0(string Tier0Id, string Action, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder PerformEpactionForDnsForwarderAtTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PerformEpactionForDnsForwarderAtTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = PerformEpactionForDnsForwarderAtTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformEpactionForDnsForwarderAtTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderType> ReadPolicyDnsForwarderOnTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ReadPolicyDnsForwarderOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyDnsForwarderOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyDnsForwarderOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyDnsForwarderOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyDnsForwarderOnTier0(string Tier0Id, NSXTPolicyDnsForwarderType PolicyDnsForwarder)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (PolicyDnsForwarder == null) { throw new System.ArgumentNullException("PolicyDnsForwarder cannot be null"); }
            StringBuilder PatchPolicyDnsForwarderOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyDnsForwarderOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarder);
            request.Resource = PatchPolicyDnsForwarderOnTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyDnsForwarderOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderZoneListResultType> ListPolicyDnsForwarderZone(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyDnsForwarderZoneServiceURL = new StringBuilder("/infra/dns-forwarder-zones");
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
            request.Resource = ListPolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPerformEpactionForDnsForwarderAtTier0(string Tier0Id, string Action, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraPerformEpactionForDnsForwarderAtTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GlobalInfraPerformEpactionForDnsForwarderAtTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraPerformEpactionForDnsForwarderAtTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraPerformEpactionForDnsForwarderAtTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderType> GlobalGlobalInfraReadPolicyDnsForwarderOnTier0(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraReadPolicyDnsForwarderOnTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPolicyDnsForwarderOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPolicyDnsForwarderOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPolicyDnsForwarderOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregatePolicyDnsAnswerType> LookupAddressViaTier1Dnsforwarder(string Tier1Id, string? Address = null, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder LookupAddressViaTier1DnsforwarderServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder/nslookup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            LookupAddressViaTier1DnsforwarderServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = LookupAddressViaTier1DnsforwarderServiceURL.ToString();
            RestResponse<NSXTAggregatePolicyDnsAnswerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregatePolicyDnsAnswerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + LookupAddressViaTier1DnsforwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregatePolicyDnsAnswerType> GlobalGlobalInfraLookupAddressViaTier0Dnsforwarder(string Tier0Id, string? Address = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraLookupAddressViaTier0DnsforwarderServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/dns-forwarder/nslookup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraLookupAddressViaTier0DnsforwarderServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraLookupAddressViaTier0DnsforwarderServiceURL.ToString();
            RestResponse<NSXTAggregatePolicyDnsAnswerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregatePolicyDnsAnswerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraLookupAddressViaTier0DnsforwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregatePolicyDnsAnswerType> LookupAddressViaTier0Dnsforwarder(string Tier0Id, string? Address = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder LookupAddressViaTier0DnsforwarderServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder/nslookup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            LookupAddressViaTier0DnsforwarderServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = LookupAddressViaTier0DnsforwarderServiceURL.ToString();
            RestResponse<NSXTAggregatePolicyDnsAnswerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregatePolicyDnsAnswerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + LookupAddressViaTier0DnsforwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderZoneType> UpdatePolicyDnsForwarderZone(string DnsForwarderZoneId, NSXTPolicyDnsForwarderZoneType PolicyDnsForwarderZone)
        {
            if (DnsForwarderZoneId == null) { throw new System.ArgumentNullException("DnsForwarderZoneId cannot be null"); }
            if (PolicyDnsForwarderZone == null) { throw new System.ArgumentNullException("PolicyDnsForwarderZone cannot be null"); }
            StringBuilder UpdatePolicyDnsForwarderZoneServiceURL = new StringBuilder("/infra/dns-forwarder-zones/{dns-forwarder-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyDnsForwarderZoneServiceURL.Replace("{dns-forwarder-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsForwarderZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarderZone);
            request.Resource = UpdatePolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderZoneType> ReadPolicyDnsForwarderZone(string DnsForwarderZoneId)
        {
            if (DnsForwarderZoneId == null) { throw new System.ArgumentNullException("DnsForwarderZoneId cannot be null"); }
            StringBuilder ReadPolicyDnsForwarderZoneServiceURL = new StringBuilder("/infra/dns-forwarder-zones/{dns-forwarder-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyDnsForwarderZoneServiceURL.Replace("{dns-forwarder-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsForwarderZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyDnsForwarderZone(string DnsForwarderZoneId)
        {
            if (DnsForwarderZoneId == null) { throw new System.ArgumentNullException("DnsForwarderZoneId cannot be null"); }
            StringBuilder DeletePolicyDnsForwarderZoneServiceURL = new StringBuilder("/infra/dns-forwarder-zones/{dns-forwarder-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyDnsForwarderZoneServiceURL.Replace("{dns-forwarder-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsForwarderZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyDnsForwarderZone(string DnsForwarderZoneId, NSXTPolicyDnsForwarderZoneType PolicyDnsForwarderZone)
        {
            if (DnsForwarderZoneId == null) { throw new System.ArgumentNullException("DnsForwarderZoneId cannot be null"); }
            if (PolicyDnsForwarderZone == null) { throw new System.ArgumentNullException("PolicyDnsForwarderZone cannot be null"); }
            StringBuilder PatchPolicyDnsForwarderZoneServiceURL = new StringBuilder("/infra/dns-forwarder-zones/{dns-forwarder-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyDnsForwarderZoneServiceURL.Replace("{dns-forwarder-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsForwarderZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDnsForwarderZone);
            request.Resource = PatchPolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderZoneListResultType> GlobalGlobalInfraListPolicyDnsForwarderZone(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListPolicyDnsForwarderZoneServiceURL = new StringBuilder("/global-infra/dns-forwarder-zones");
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
            request.Resource = GlobalInfraListPolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregatePolicyDnsAnswerType> GlobalGlobalInfraLookupAddressViaTier1Dnsforwarder(string Tier1Id, string? Address = null, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraLookupAddressViaTier1DnsforwarderServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/dns-forwarder/nslookup");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraLookupAddressViaTier1DnsforwarderServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraLookupAddressViaTier1DnsforwarderServiceURL.ToString();
            RestResponse<NSXTAggregatePolicyDnsAnswerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregatePolicyDnsAnswerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraLookupAddressViaTier1DnsforwarderServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPerformEpactionForDnsForwarderAtTier1(string Tier1Id, string Action, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraPerformEpactionForDnsForwarderAtTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GlobalInfraPerformEpactionForDnsForwarderAtTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraPerformEpactionForDnsForwarderAtTier1ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraPerformEpactionForDnsForwarderAtTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderType> GlobalGlobalInfraReadPolicyDnsForwarderOnTier1(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraReadPolicyDnsForwarderOnTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/dns-forwarder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPolicyDnsForwarderOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPolicyDnsForwarderOnTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPolicyDnsForwarderOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDnsForwarderZoneType> GlobalGlobalInfraReadPolicyDnsForwarderZone(string DnsForwarderZoneId)
        {
            if (DnsForwarderZoneId == null) { throw new System.ArgumentNullException("DnsForwarderZoneId cannot be null"); }
            StringBuilder GlobalInfraReadPolicyDnsForwarderZoneServiceURL = new StringBuilder("/global-infra/dns-forwarder-zones/{dns-forwarder-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadPolicyDnsForwarderZoneServiceURL.Replace("{dns-forwarder-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsForwarderZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadPolicyDnsForwarderZoneServiceURL.ToString();
            RestResponse<NSXTPolicyDnsForwarderZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDnsForwarderZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadPolicyDnsForwarderZoneServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
