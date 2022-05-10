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
    public class NSGroup
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NSGroup(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveCloudNativeServiceInstances(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveCloudNativeServiceInstancesServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-cloud-native-service-instance-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveCloudNativeServiceInstancesServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveCloudNativeServiceInstancesServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveCloudNativeServiceInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveTransportNodeMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveTransportNodeMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-transport-node-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveTransportNodeMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveTransportNodeMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveTransportNodeMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveLogicalSwitchMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveLogicalSwitchMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-logical-switch-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveLogicalSwitchMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveLogicalSwitchMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveLogicalSwitchMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectivePhysicalServerMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectivePhysicalServerMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-physical-server-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectivePhysicalServerMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectivePhysicalServerMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectivePhysicalServerMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSGroupType> UpdateNsgroup(string NsGroupId, NSXTNSGroupType Nsgroup)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            if (Nsgroup == null) { throw new System.ArgumentNullException("Nsgroup cannot be null"); }
            StringBuilder UpdateNsgroupServiceURL = new StringBuilder("/ns-groups/{ns-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNsgroupServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Nsgroup);
            request.Resource = UpdateNsgroupServiceURL.ToString();
            RestResponse<NSXTNSGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNsgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSGroupType> AddOrRemoveNsgroupExpression(string NsGroupId, NSXTNSGroupExpressionListType NsgroupExpressionList, string Action)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            if (NsgroupExpressionList == null) { throw new System.ArgumentNullException("NsgroupExpressionList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddOrRemoveNsgroupExpressionServiceURL = new StringBuilder("/ns-groups/{ns-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddOrRemoveNsgroupExpressionServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NsgroupExpressionList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddOrRemoveNsgroupExpressionServiceURL.ToString();
            RestResponse<NSXTNSGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddOrRemoveNsgroupExpressionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSGroupType> ReadNsgroup(string NsGroupId, bool? PopulateReferences = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder ReadNsgroupServiceURL = new StringBuilder("/ns-groups/{ns-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNsgroupServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (PopulateReferences != null) { request.AddQueryParameter("populate_references", PopulateReferences.ToString()); }
            request.Resource = ReadNsgroupServiceURL.ToString();
            RestResponse<NSXTNSGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNsgroup(string NsGroupId, bool? Force = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder DeleteNsgroupServiceURL = new StringBuilder("/ns-groups/{ns-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNsgroupServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteNsgroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNsgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualMachineListResultType> GetEffectiveVirtualMachineMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveVirtualMachineMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-virtual-machine-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveVirtualMachineMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveVirtualMachineMembersServiceURL.ToString();
            RestResponse<NSXTVirtualMachineListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualMachineListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveVirtualMachineMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVirtualNetworkInterfaceListResultType> GetEffectiveVifmembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveVifmembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-vif-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveVifmembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveVifmembersServiceURL.ToString();
            RestResponse<NSXTVirtualNetworkInterfaceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVirtualNetworkInterfaceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveVifmembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveIpsetMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveIpsetMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-ipset-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveIpsetMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveIpsetMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveIpsetMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberTypeListResultType> GetMemberTypes(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetMemberTypesServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/member-types");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMemberTypesServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetMemberTypesServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberTypeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberTypeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMemberTypesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveIPAddressMemberListResultType> GetEffectiveIpaddressMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveIpaddressMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-ip-address-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveIpaddressMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveIpaddressMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveIPAddressMemberListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveIPAddressMemberListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveIpaddressMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveLogicalPortMembers(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveLogicalPortMembersServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-logical-port-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveLogicalPortMembersServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveLogicalPortMembersServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveLogicalPortMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEffectiveMemberResourceListResultType> GetEffectiveActiveDirectoryGroups(string NsGroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NsGroupId == null) { throw new System.ArgumentNullException("NsGroupId cannot be null"); }
            StringBuilder GetEffectiveActiveDirectoryGroupsServiceURL = new StringBuilder("/ns-groups/{ns-group-id}/effective-directory-group-members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetEffectiveActiveDirectoryGroupsServiceURL.Replace("{ns-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetEffectiveActiveDirectoryGroupsServiceURL.ToString();
            RestResponse<NSXTEffectiveMemberResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEffectiveMemberResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetEffectiveActiveDirectoryGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSGroupType> CreateNsgroup(NSXTNSGroupType Nsgroup)
        {
            if (Nsgroup == null) { throw new System.ArgumentNullException("Nsgroup cannot be null"); }
            StringBuilder CreateNsgroupServiceURL = new StringBuilder("/ns-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Nsgroup);
            request.Resource = CreateNsgroupServiceURL.ToString();
            RestResponse<NSXTNSGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsgroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNSGroupListResultType> ListNsgroups(string? Cursor = null, string? IncludedFields = null, string? MemberTypes = null, long? PageSize = null, bool? PopulateReferences = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNsgroupsServiceURL = new StringBuilder("/ns-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MemberTypes != null) { request.AddQueryParameter("member_types", MemberTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PopulateReferences != null) { request.AddQueryParameter("populate_references", PopulateReferences.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsgroupsServiceURL.ToString();
            RestResponse<NSXTNSGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNSGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNsgroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
