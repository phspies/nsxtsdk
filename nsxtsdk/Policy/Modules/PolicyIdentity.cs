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
    public class PolicyIdentity
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIdentity(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIdfwVirtualMachineStatusListResultType> ListVirtualMachineIdfwstatusByTransportNode(string TransportNodeId, string? EnforcementPointPath = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder ListVirtualMachineIdfwstatusByTransportNodeServiceURL = new StringBuilder("/infra/settings/firewall/idfw/transport-nodes/{transport-node-id}/vms/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVirtualMachineIdfwstatusByTransportNodeServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListVirtualMachineIdfwstatusByTransportNodeServiceURL.ToString();
            RestResponse<NSXTIdfwVirtualMachineStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwVirtualMachineStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVirtualMachineIdfwstatusByTransportNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIdfwGroupVmDetailListResultType> GetGroupVmDetails(string GroupPath, string? EnforcementPointPath = null)
        {
            if (GroupPath == null) { throw new System.ArgumentNullException("GroupPath cannot be null"); }
            StringBuilder GetGroupVmDetailsServiceURL = new StringBuilder("/infra/settings/firewall/idfw/group-vm-details");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (GroupPath != null) { request.AddQueryParameter("group_path", GroupPath.ToString()); }
            request.Resource = GetGroupVmDetailsServiceURL.ToString();
            RestResponse<NSXTPolicyIdfwGroupVmDetailListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdfwGroupVmDetailListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGroupVmDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryOrgUnitListResultsType> FetchFirewallIdentityStoreOrgUnitsForIdentityStore(string FirewallIdentityStoreId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            StringBuilder FetchFirewallIdentityStoreOrgUnitsForIdentityStoreServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/org-units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            FetchFirewallIdentityStoreOrgUnitsForIdentityStoreServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = FetchFirewallIdentityStoreOrgUnitsForIdentityStoreServiceURL.ToString();
            RestResponse<NSXTDirectoryOrgUnitListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryOrgUnitListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + FetchFirewallIdentityStoreOrgUnitsForIdentityStoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainSizeType> ScanFirewallIdentityStoreSize(NSXTDirectoryDomainType DirectoryDomain, string? EnforcementPointPath = null)
        {
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder ScanFirewallIdentityStoreSizeServiceURL = new StringBuilder("/infra/firewall-identity-store-size");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryDomain);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ScanFirewallIdentityStoreSizeServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainSizeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainSizeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ScanFirewallIdentityStoreSizeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryGroupListResultsType> SearchFirewallIdentityGroups(string FirewallIdentityStoreId, string FilterValue, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (FilterValue == null) { throw new System.ArgumentNullException("FilterValue cannot be null"); }
            StringBuilder SearchFirewallIdentityGroupsServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            SearchFirewallIdentityGroupsServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (FilterValue != null) { request.AddQueryParameter("filter_value", FilterValue.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = SearchFirewallIdentityGroupsServiceURL.ToString();
            RestResponse<NSXTDirectoryGroupListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryGroupListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + SearchFirewallIdentityGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> CreateOrReplaceFirewallIdentityStoreLdapServer(string FirewallIdentityStoreId, string LdapServerId, NSXTDirectoryLdapServerType DirectoryLdapServer, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (LdapServerId == null) { throw new System.ArgumentNullException("LdapServerId cannot be null"); }
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder CreateOrReplaceFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers/{ldap-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceFirewallIdentityStoreLdapServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceFirewallIdentityStoreLdapServerServiceURL.Replace("{ldap-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryLdapServer);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrReplaceFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> CreateOrPatchFirewallIdentityStoreLdapServer(string FirewallIdentityStoreId, string LdapServerId, NSXTDirectoryLdapServerType DirectoryLdapServer, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (LdapServerId == null) { throw new System.ArgumentNullException("LdapServerId cannot be null"); }
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder CreateOrPatchFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers/{ldap-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchFirewallIdentityStoreLdapServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchFirewallIdentityStoreLdapServerServiceURL.Replace("{ldap-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryLdapServer);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrPatchFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task TestFirewallIdentityStoreLdapServer(string FirewallIdentityStoreId, string LdapServerId, string Action, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (LdapServerId == null) { throw new System.ArgumentNullException("LdapServerId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder TestFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers/{ldap-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            TestFirewallIdentityStoreLdapServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            TestFirewallIdentityStoreLdapServerServiceURL.Replace("{ldap-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = TestFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TestFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> ReadFirewallIdentityStoreLdapServer(string FirewallIdentityStoreId, string LdapServerId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (LdapServerId == null) { throw new System.ArgumentNullException("LdapServerId cannot be null"); }
            StringBuilder ReadFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers/{ldap-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFirewallIdentityStoreLdapServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadFirewallIdentityStoreLdapServerServiceURL.Replace("{ldap-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFirewallIdentityStoreLdapServer(string FirewallIdentityStoreId, string LdapServerId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (LdapServerId == null) { throw new System.ArgumentNullException("LdapServerId cannot be null"); }
            StringBuilder DeleteFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers/{ldap-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFirewallIdentityStoreLdapServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteFirewallIdentityStoreLdapServerServiceURL.Replace("{ldap-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LdapServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = DeleteFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwVmStatsType> GetUserLoginEventsForAVM(string VmId, string? EnforcementPointPath = null)
        {
            if (VmId == null) { throw new System.ArgumentNullException("VmId cannot be null"); }
            StringBuilder GetUserLoginEventsForAVMServiceURL = new StringBuilder("/infra/settings/firewall/idfw/vm-stats/{vm-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUserLoginEventsForAVMServiceURL.Replace("{vm-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VmId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetUserLoginEventsForAVMServiceURL.ToString();
            RestResponse<NSXTIdfwVmStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwVmStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUserLoginEventsForAVMServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwUserStatsType> GetUserLoginEvents(string UserId, string? EnforcementPointPath = null)
        {
            if (UserId == null) { throw new System.ArgumentNullException("UserId cannot be null"); }
            StringBuilder GetUserLoginEventsServiceURL = new StringBuilder("/infra/settings/firewall/idfw/user-stats/{user-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUserLoginEventsServiceURL.Replace("{user-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UserId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetUserLoginEventsServiceURL.ToString();
            RestResponse<NSXTIdfwUserStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwUserStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUserLoginEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryOrgUnitListResultsType> FetchFirewallIdentityStoreOrgUnits(NSXTDirectoryLdapServerType DirectoryLdapServer, string? EnforcementPointPath = null)
        {
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder FetchFirewallIdentityStoreOrgUnitsServiceURL = new StringBuilder("/infra/firewall-identity-stores-org-units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryLdapServer);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = FetchFirewallIdentityStoreOrgUnitsServiceURL.ToString();
            RestResponse<NSXTDirectoryOrgUnitListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryOrgUnitListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FetchFirewallIdentityStoreOrgUnitsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryGroupMemberListResultsType> ListFirewallIdentityStoreGroupMemberGroups(string FirewallIdentityStoreId, string GroupId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListFirewallIdentityStoreGroupMemberGroupsServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/groups/{group-id}/member-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFirewallIdentityStoreGroupMemberGroupsServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            ListFirewallIdentityStoreGroupMemberGroupsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallIdentityStoreGroupMemberGroupsServiceURL.ToString();
            RestResponse<NSXTDirectoryGroupMemberListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryGroupMemberListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallIdentityStoreGroupMemberGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerStatusType> VerifyFirewallIdentityStoreLdapServer(NSXTDirectoryLdapServerType DirectoryLdapServer, string Action, string? EnforcementPointPath = null)
        {
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder VerifyFirewallIdentityStoreLdapServerServiceURL = new StringBuilder("/infra/firewall-identity-store-ldap-server");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryLdapServer);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = VerifyFirewallIdentityStoreLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + VerifyFirewallIdentityStoreLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwComputeCollectionStatusType> GetIdfwstatusForAcomputeCollection(string ComputeCollectionId, string? EnforcementPointPath = null)
        {
            if (ComputeCollectionId == null) { throw new System.ArgumentNullException("ComputeCollectionId cannot be null"); }
            StringBuilder GetIdfwstatusForAcomputeCollectionServiceURL = new StringBuilder("/infra/settings/firewall/idfw/compute-collections/{compute-collection-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdfwstatusForAcomputeCollectionServiceURL.Replace("{compute-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdfwstatusForAcomputeCollectionServiceURL.ToString();
            RestResponse<NSXTIdfwComputeCollectionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwComputeCollectionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdfwstatusForAcomputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwSystemStatsType> GetIdfwsystemStatisticsData(string? EnforcementPointPath = null)
        {
            StringBuilder GetIdfwsystemStatisticsDataServiceURL = new StringBuilder("/infra/settings/firewall/idfw/system-stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdfwsystemStatisticsDataServiceURL.ToString();
            RestResponse<NSXTIdfwSystemStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwSystemStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdfwsystemStatisticsDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainSyncStatsType> GetFirewallIdentityStoreSyncStats(string FirewallIdentityStoreId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            StringBuilder GetFirewallIdentityStoreSyncStatsServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/sync-stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallIdentityStoreSyncStatsServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetFirewallIdentityStoreSyncStatsServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainSyncStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainSyncStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallIdentityStoreSyncStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainListResultsType> ListFirewallIdentityStores(string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListFirewallIdentityStoresServiceURL = new StringBuilder("/infra/firewall-identity-stores");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallIdentityStoresServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallIdentityStoresServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerListResultsType> ListFirewallIdentityStoreLdapServers(string FirewallIdentityStoreId, string? Cursor = null, string? EnforcementPointPath = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            StringBuilder ListFirewallIdentityStoreLdapServersServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/ldap-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFirewallIdentityStoreLdapServersServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallIdentityStoreLdapServersServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFirewallIdentityStoreLdapServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwComputeCollectionListResultType> GetIdfwstatusForAllComputeCollections(string? EnforcementPointPath = null)
        {
            StringBuilder GetIdfwstatusForAllComputeCollectionsServiceURL = new StringBuilder("/infra/settings/firewall/idfw/compute-collections/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdfwstatusForAllComputeCollectionsServiceURL.ToString();
            RestResponse<NSXTIdfwComputeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwComputeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdfwstatusForAllComputeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainType> CreateOrReplaceFirewallIdentityStore(string FirewallIdentityStoreId, NSXTDirectoryDomainType DirectoryDomain, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder CreateOrReplaceFirewallIdentityStoreServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceFirewallIdentityStoreServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryDomain);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrReplaceFirewallIdentityStoreServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceFirewallIdentityStoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFirewallIdentityStore(string FirewallIdentityStoreId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            StringBuilder DeleteFirewallIdentityStoreServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFirewallIdentityStoreServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = DeleteFirewallIdentityStoreServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFirewallIdentityStoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RequestFirewallIdentityStoreSync(string FirewallIdentityStoreId, string Action, long? Delay = null, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder RequestFirewallIdentityStoreSyncServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RequestFirewallIdentityStoreSyncServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (Delay != null) { request.AddQueryParameter("delay", Delay.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = RequestFirewallIdentityStoreSyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RequestFirewallIdentityStoreSyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainType> ReadFirewallIdentityStore(string FirewallIdentityStoreId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            StringBuilder ReadFirewallIdentityStoreServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFirewallIdentityStoreServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadFirewallIdentityStoreServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFirewallIdentityStoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchFirewallIdentityStore(string FirewallIdentityStoreId, NSXTDirectoryDomainType DirectoryDomain, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder CreateOrPatchFirewallIdentityStoreServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchFirewallIdentityStoreServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryDomain);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrPatchFirewallIdentityStoreServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchFirewallIdentityStoreServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryEventLogServerStatusType> VerifyFirewallIdentityStoreEventLogServer(NSXTDirectoryEventLogServerType DirectoryEventLogServer)
        {
            if (DirectoryEventLogServer == null) { throw new System.ArgumentNullException("DirectoryEventLogServer cannot be null"); }
            StringBuilder VerifyFirewallIdentityStoreEventLogServerServiceURL = new StringBuilder("/infra/firewall-identity-store-event-log-servers/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryEventLogServer);
            request.Resource = VerifyFirewallIdentityStoreEventLogServerServiceURL.ToString();
            RestResponse<NSXTDirectoryEventLogServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryEventLogServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + VerifyFirewallIdentityStoreEventLogServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwUserSessionDataAndMappingsType> GetUserSessionData(string? EnforcementPointPath = null)
        {
            StringBuilder GetUserSessionDataServiceURL = new StringBuilder("/infra/settings/firewall/idfw/user-session-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetUserSessionDataServiceURL.ToString();
            RestResponse<NSXTIdfwUserSessionDataAndMappingsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwUserSessionDataAndMappingsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUserSessionDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryEventLogServerType> CreateOrReplaceFirewallIdentityStoreEventLogServer(string FirewallIdentityStoreId, string EventLogServerId, NSXTDirectoryEventLogServerType DirectoryEventLogServer, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (EventLogServerId == null) { throw new System.ArgumentNullException("EventLogServerId cannot be null"); }
            if (DirectoryEventLogServer == null) { throw new System.ArgumentNullException("DirectoryEventLogServer cannot be null"); }
            StringBuilder CreateOrReplaceFirewallIdentityStoreEventLogServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/event-log-servers/{event-log-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceFirewallIdentityStoreEventLogServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceFirewallIdentityStoreEventLogServerServiceURL.Replace("{event-log-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventLogServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryEventLogServer);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrReplaceFirewallIdentityStoreEventLogServerServiceURL.ToString();
            RestResponse<NSXTDirectoryEventLogServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryEventLogServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceFirewallIdentityStoreEventLogServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFirewallIdentityStoreEventLogServer(string FirewallIdentityStoreId, string EventLogServerId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (EventLogServerId == null) { throw new System.ArgumentNullException("EventLogServerId cannot be null"); }
            StringBuilder DeleteFirewallIdentityStoreEventLogServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/event-log-servers/{event-log-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFirewallIdentityStoreEventLogServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteFirewallIdentityStoreEventLogServerServiceURL.Replace("{event-log-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventLogServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = DeleteFirewallIdentityStoreEventLogServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFirewallIdentityStoreEventLogServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchFirewallIdentityStoreEventLogServer(string FirewallIdentityStoreId, string EventLogServerId, NSXTDirectoryEventLogServerType DirectoryEventLogServer, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (EventLogServerId == null) { throw new System.ArgumentNullException("EventLogServerId cannot be null"); }
            if (DirectoryEventLogServer == null) { throw new System.ArgumentNullException("DirectoryEventLogServer cannot be null"); }
            StringBuilder CreateOrPatchFirewallIdentityStoreEventLogServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/event-log-servers/{event-log-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchFirewallIdentityStoreEventLogServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrPatchFirewallIdentityStoreEventLogServerServiceURL.Replace("{event-log-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventLogServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryEventLogServer);
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = CreateOrPatchFirewallIdentityStoreEventLogServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchFirewallIdentityStoreEventLogServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryEventLogServerType> ReadFirewallIdentityStoreEventLogServer(string FirewallIdentityStoreId, string EventLogServerId, string? EnforcementPointPath = null)
        {
            if (FirewallIdentityStoreId == null) { throw new System.ArgumentNullException("FirewallIdentityStoreId cannot be null"); }
            if (EventLogServerId == null) { throw new System.ArgumentNullException("EventLogServerId cannot be null"); }
            StringBuilder ReadFirewallIdentityStoreEventLogServerServiceURL = new StringBuilder("/infra/firewall-identity-stores/{firewall-identity-store-id}/event-log-servers/{event-log-server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFirewallIdentityStoreEventLogServerServiceURL.Replace("{firewall-identity-store-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallIdentityStoreId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadFirewallIdentityStoreEventLogServerServiceURL.Replace("{event-log-server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EventLogServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ReadFirewallIdentityStoreEventLogServerServiceURL.ToString();
            RestResponse<NSXTDirectoryEventLogServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryEventLogServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFirewallIdentityStoreEventLogServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdfwTransportNodeStatusListResultType> ListIdfwstatusForAllTransportNodesInAcomputeCollection(string ComputeCollectionId, string? EnforcementPointPath = null)
        {
            if (ComputeCollectionId == null) { throw new System.ArgumentNullException("ComputeCollectionId cannot be null"); }
            StringBuilder ListIdfwstatusForAllTransportNodesInAcomputeCollectionServiceURL = new StringBuilder("/infra/settings/firewall/idfw/compute-collections/{compute-collection-id}/transport-nodes/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIdfwstatusForAllTransportNodesInAcomputeCollectionServiceURL.Replace("{compute-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ListIdfwstatusForAllTransportNodesInAcomputeCollectionServiceURL.ToString();
            RestResponse<NSXTIdfwTransportNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdfwTransportNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIdfwstatusForAllTransportNodesInAcomputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
