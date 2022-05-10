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
    public class PolicyRealizedState
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyRealizedState(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTRealizedSecurityGroupListResultType> ListSecurityGroupRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListSecurityGroupRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/groups/securitygroups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSecurityGroupRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSecurityGroupRealizedStatesServiceURL.ToString();
            RestResponse<NSXTRealizedSecurityGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedSecurityGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSecurityGroupRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizedFirewallSectionType> ReadFirewallSectionRealizedState(string EnforcementPointName, string FirewallSectionId)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (FirewallSectionId == null) { throw new System.ArgumentNullException("FirewallSectionId cannot be null"); }
            StringBuilder ReadFirewallSectionRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/firewalls/firewall-sections/{firewall-section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFirewallSectionRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadFirewallSectionRealizedStateServiceURL.Replace("{firewall-section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFirewallSectionRealizedStateServiceURL.ToString();
            RestResponse<NSXTRealizedFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFirewallSectionRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> ListNsgroupRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListNsgroupRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/groups/nsgroups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListNsgroupRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsgroupRealizedStatesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsgroupRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConsolidatedRealizedStatusType> GlobalGlobalInfraReadIntentStatus(string IntentPath, bool? IncludeEnforcedStatus = null, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder GlobalInfraReadIntentStatusServiceURL = new StringBuilder("/global-infra/realized-state/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IncludeEnforcedStatus != null) { request.AddQueryParameter("include_enforced_status", IncludeEnforcedStatus.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = GlobalInfraReadIntentStatusServiceURL.ToString();
            RestResponse<NSXTConsolidatedRealizedStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConsolidatedRealizedStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadIntentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyAlarmResourceListResultType> ListAlarms(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAlarmsServiceURL = new StringBuilder("/infra/realized-state/alarms");
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
            request.Resource = ListAlarmsServiceURL.ToString();
            RestResponse<NSXTPolicyAlarmResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyAlarmResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAlarmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceType> ReadIpsetRealizedState(string EnforcementPointName, string IpSetName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (IpSetName == null) { throw new System.ArgumentNullException("IpSetName cannot be null"); }
            StringBuilder ReadIpsetRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/ip-sets/ip-sets-nsxt/{ip-set-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpsetRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIpsetRealizedStateServiceURL.Replace("{ip-set-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpsetRealizedStateServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpsetRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceType> ReadNsgroupRealizedState(string EnforcementPointName, string NsgroupName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (NsgroupName == null) { throw new System.ArgumentNullException("NsgroupName cannot be null"); }
            StringBuilder ReadNsgroupRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/groups/nsgroups/{nsgroup-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsgroupRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadNsgroupRealizedStateServiceURL.Replace("{nsgroup-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsgroupName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsgroupRealizedStateServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsgroupRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> ListSystemVms(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? Query = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSystemVmsServiceURL = new StringBuilder("/infra/realized-state/system-virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Query != null) { request.AddQueryParameter("query", Query.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSystemVmsServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSystemVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceType> ReadNsserviceRealizedState(string EnforcementPointName, string NsserviceName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (NsserviceName == null) { throw new System.ArgumentNullException("NsserviceName cannot be null"); }
            StringBuilder ReadNsserviceRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/services/nsservices/{nsservice-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsserviceRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadNsserviceRealizedStateServiceURL.Replace("{nsservice-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsserviceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsserviceRealizedStateServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsserviceRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConsolidatedRealizedStatusType> ReadIntentStatus(string IntentPath, bool? IncludeEnforcedStatus = null, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder ReadIntentStatusServiceURL = new StringBuilder("/infra/realized-state/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IncludeEnforcedStatus != null) { request.AddQueryParameter("include_enforced_status", IncludeEnforcedStatus.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = ReadIntentStatusServiceURL.ToString();
            RestResponse<NSXTConsolidatedRealizedStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConsolidatedRealizedStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIntentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> ListAllUnAssociatedVirtualMachines(string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAllUnAssociatedVirtualMachinesServiceURL = new StringBuilder("/infra/realized-state/unassociated-virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAllUnAssociatedVirtualMachinesServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllUnAssociatedVirtualMachinesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizedFirewallSectionListResultType> ListFirewallSectionRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListFirewallSectionRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/firewalls/firewall-sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFirewallSectionRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallSectionRealizedStatesServiceURL.ToString();
            RestResponse<NSXTRealizedFirewallSectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedFirewallSectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallSectionRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizedSecurityGroupType> ReadSecurityGroupRealizedState(string EnforcementPointName, string SecuritygroupName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (SecuritygroupName == null) { throw new System.ArgumentNullException("SecuritygroupName cannot be null"); }
            StringBuilder ReadSecurityGroupRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/groups/securitygroups/{securitygroup-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSecurityGroupRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSecurityGroupRealizedStateServiceURL.Replace("{securitygroup-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecuritygroupName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSecurityGroupRealizedStateServiceURL.ToString();
            RestResponse<NSXTRealizedSecurityGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedSecurityGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSecurityGroupRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizedEnforcementPointListResultType> ListEnforcementPointRealizedStates(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListEnforcementPointRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points");
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
            request.Resource = ListEnforcementPointRealizedStatesServiceURL.ToString();
            RestResponse<NSXTRealizedEnforcementPointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedEnforcementPointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEnforcementPointRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceType> ReadRealizedEntity(string RealizedPath)
        {
            if (RealizedPath == null) { throw new System.ArgumentNullException("RealizedPath cannot be null"); }
            StringBuilder ReadRealizedEntityServiceURL = new StringBuilder("/infra/realized-state/realized-entity");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (RealizedPath != null) { request.AddQueryParameter("realized_path", RealizedPath.ToString()); }
            request.Resource = ReadRealizedEntityServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRealizedEntityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineDetailsType> ReadVirtualMachineDetails(string EnforcementPointName, string VirtualMachineId)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (VirtualMachineId == null) { throw new System.ArgumentNullException("VirtualMachineId cannot be null"); }
            StringBuilder ReadVirtualMachineDetailsServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/virtual-machines/{virtual-machine-id}/details");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadVirtualMachineDetailsServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadVirtualMachineDetailsServiceURL.Replace("{virtual-machine-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VirtualMachineId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadVirtualMachineDetailsServiceURL.ToString();
            RestResponse<NSXTVirtualMachineDetailsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineDetailsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadVirtualMachineDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> ListIpsetRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListIpsetRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/ip-sets/ip-sets-nsxt");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIpsetRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpsetRealizedStatesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpsetRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizedEnforcementPointType> ReadEnforcementPointRealizedState(string EnforcementPointName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ReadEnforcementPointRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEnforcementPointRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEnforcementPointRealizedStateServiceURL.ToString();
            RestResponse<NSXTRealizedEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizedEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEnforcementPointRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraRefreshRealizedState(string IntentPath, string? EnforcementPointPath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder GlobalInfraRefreshRealizedStateServiceURL = new StringBuilder("/global-infra/realized-state/realized-entity?action=refresh");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            request.Resource = GlobalInfraRefreshRealizedStateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraRefreshRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSearchResponseType> ListVirtualMachinesOnEnforcementPoint(string EnforcementPointName, string? Cursor = null, string? Dsl = null, string? IncludedFields = null, long? PageSize = null, string? Query = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListVirtualMachinesOnEnforcementPointServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVirtualMachinesOnEnforcementPointServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Dsl != null) { request.AddQueryParameter("dsl", Dsl.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Query != null) { request.AddQueryParameter("query", Query.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListVirtualMachinesOnEnforcementPointServiceURL.ToString();
            RestResponse<NSXTSearchResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSearchResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualMachinesOnEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> ListSystemExcludedVms(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? Query = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSystemExcludedVmsServiceURL = new StringBuilder("/infra/realized-state/system-excluded-virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Query != null) { request.AddQueryParameter("query", Query.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSystemExcludedVmsServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSystemExcludedVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task TagVirtualMachine(string EnforcementPointName, NSXTVirtualMachineTagsUpdateType VirtualMachineTagsUpdate)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (VirtualMachineTagsUpdate == null) { throw new System.ArgumentNullException("VirtualMachineTagsUpdate cannot be null"); }
            StringBuilder TagVirtualMachineServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/virtual-machines?action=update_tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            TagVirtualMachineServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VirtualMachineTagsUpdate);
            request.Resource = TagVirtualMachineServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TagVirtualMachineServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> ListMacsetRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListMacsetRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/mac-sets/mac-sets-nsxt");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListMacsetRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListMacsetRealizedStatesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListMacsetRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> GlobalGlobalInfraListRealizedEntities(string IntentPath, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder GlobalInfraListRealizedEntitiesServiceURL = new StringBuilder("/global-infra/realized-state/realized-entities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = GlobalInfraListRealizedEntitiesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListRealizedEntitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualNetworkInterfaceListResultType> ListVifsOnEnforcementPoint(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, string? LportAttachmentId = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListVifsOnEnforcementPointServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/vifs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVifsOnEnforcementPointServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (LportAttachmentId != null) { request.AddQueryParameter("lport_attachment_id", LportAttachmentId.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListVifsOnEnforcementPointServiceURL.ToString();
            RestResponse<NSXTVirtualNetworkInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualNetworkInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVifsOnEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> ListAllVirtualMachines(string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListAllVirtualMachinesServiceURL = new StringBuilder("/infra/realized-state/virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListAllVirtualMachinesServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllVirtualMachinesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> ListNsserviceRealizedStates(string EnforcementPointName, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            StringBuilder ListNsserviceRealizedStatesServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/services/nsservices");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListNsserviceRealizedStatesServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsserviceRealizedStatesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsserviceRealizedStatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RefreshRealizedState(string IntentPath, string? EnforcementPointPath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder RefreshRealizedStateServiceURL = new StringBuilder("/infra/realized-state/realized-entity?action=refresh");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            request.Resource = RefreshRealizedStateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RefreshRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceListResultType> ListRealizedEntities(string IntentPath, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder ListRealizedEntitiesServiceURL = new StringBuilder("/infra/realized-state/realized-entities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = ListRealizedEntitiesServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRealizedEntitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGenericPolicyRealizedResourceType> ReadMacsetRealizedState(string EnforcementPointName, string MacSetName)
        {
            if (EnforcementPointName == null) { throw new System.ArgumentNullException("EnforcementPointName cannot be null"); }
            if (MacSetName == null) { throw new System.ArgumentNullException("MacSetName cannot be null"); }
            StringBuilder ReadMacsetRealizedStateServiceURL = new StringBuilder("/infra/realized-state/enforcement-points/{enforcement-point-name}/mac-sets/mac-sets-nsxt/{mac-set-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadMacsetRealizedStateServiceURL.Replace("{enforcement-point-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointName, System.Globalization.CultureInfo.InvariantCulture)));
            ReadMacsetRealizedStateServiceURL.Replace("{mac-set-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(MacSetName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadMacsetRealizedStateServiceURL.ToString();
            RestResponse<NSXTGenericPolicyRealizedResourceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGenericPolicyRealizedResourceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadMacsetRealizedStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
