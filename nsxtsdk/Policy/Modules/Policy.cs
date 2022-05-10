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
    public class Policy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Policy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTGroupMemberTypeListResultType> GetMemberTypesForGroup(string DomainId, string GroupId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GetMemberTypesForGroupServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/member-types");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMemberTypesForGroupServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetMemberTypesForGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMemberTypesForGroupServiceURL.ToString();
            RestResponse<NSXTGroupMemberTypeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMemberTypeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMemberTypesForGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigType> UpdateConnectivityGlobalConfig(NSXTGlobalConfigType GlobalConfig)
        {
            if (GlobalConfig == null) { throw new System.ArgumentNullException("GlobalConfig cannot be null"); }
            StringBuilder UpdateConnectivityGlobalConfigServiceURL = new StringBuilder("/infra/connectivity-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(GlobalConfig);
            request.Resource = UpdateConnectivityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateConnectivityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigType> ReadConnectivityGlobalConfig()
        {
            StringBuilder ReadConnectivityGlobalConfigServiceURL = new StringBuilder("/infra/connectivity-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadConnectivityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadConnectivityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchConnectivityGlobalConfig(NSXTGlobalConfigType GlobalConfig)
        {
            if (GlobalConfig == null) { throw new System.ArgumentNullException("GlobalConfig cannot be null"); }
            StringBuilder PatchConnectivityGlobalConfigServiceURL = new StringBuilder("/infra/connectivity-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(GlobalConfig);
            request.Resource = PatchConnectivityGlobalConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchConnectivityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceType> UpdateServiceForTenant(string ServiceId, NSXTServiceType Service)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (Service == null) { throw new System.ArgumentNullException("Service cannot be null"); }
            StringBuilder UpdateServiceForTenantServiceURL = new StringBuilder("/infra/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceForTenantServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Service);
            request.Resource = UpdateServiceForTenantServiceURL.ToString();
            RestResponse<NSXTServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceForTenant(string ServiceId, NSXTServiceType Service)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (Service == null) { throw new System.ArgumentNullException("Service cannot be null"); }
            StringBuilder PatchServiceForTenantServiceURL = new StringBuilder("/infra/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceForTenantServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Service);
            request.Resource = PatchServiceForTenantServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceType> ReadServiceForTenant(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ReadServiceForTenantServiceURL = new StringBuilder("/infra/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceForTenantServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceForTenantServiceURL.ToString();
            RestResponse<NSXTServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceForTenant(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteServiceForTenantServiceURL = new StringBuilder("/infra/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceForTenantServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceForTenantServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceEntryType> GlobalGlobalInfraReadServiceEntry(string ServiceId, string ServiceEntryId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceEntryId == null) { throw new System.ArgumentNullException("ServiceEntryId cannot be null"); }
            StringBuilder GlobalInfraReadServiceEntryServiceURL = new StringBuilder("/global-infra/services/{service-id}/service-entries/{service-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadServiceEntryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadServiceEntryServiceURL.Replace("{service-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadServiceEntryServiceURL.ToString();
            RestResponse<NSXTServiceEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadServiceEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddorRemoveGroupPathMembers(string DomainId, string GroupId, string ExpressionId, NSXTGroupMemberListType GroupMemberList, string Action)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (GroupMemberList == null) { throw new System.ArgumentNullException("GroupMemberList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddorRemoveGroupPathMembersServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/path-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddorRemoveGroupPathMembersServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupPathMembersServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupPathMembersServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupMemberList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddorRemoveGroupPathMembersServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddorRemoveGroupPathMembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupPathExpressionForDomain(string DomainId, string GroupId, string ExpressionId, NSXTPathExpressionType PathExpression)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (PathExpression == null) { throw new System.ArgumentNullException("PathExpression cannot be null"); }
            StringBuilder PatchGroupPathExpressionForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/path-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupPathExpressionForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupPathExpressionForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupPathExpressionForDomainServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PathExpression);
            request.Resource = PatchGroupPathExpressionForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupPathExpressionForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupPathExpression(string DomainId, string GroupId, string ExpressionId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            StringBuilder DeleteGroupPathExpressionServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/path-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupPathExpressionServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupPathExpressionServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupPathExpressionServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupPathExpressionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupPathExpressionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainType> GlobalGlobalInfraReadDomainForInfra(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraReadDomainForInfraServiceURL = new StringBuilder("/global-infra/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDomainForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadDomainForInfraServiceURL.ToString();
            RestResponse<NSXTDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddorRemoveGroupIpaddresses(string DomainId, string GroupId, string ExpressionId, NSXTIPAddressListType IpaddressList, string Action)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (IpaddressList == null) { throw new System.ArgumentNullException("IpaddressList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddorRemoveGroupIpaddressesServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/ip-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddorRemoveGroupIpaddressesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupIpaddressesServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupIpaddressesServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpaddressList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddorRemoveGroupIpaddressesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddorRemoveGroupIpaddressesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupIpaddressExpression(string DomainId, string GroupId, string ExpressionId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            StringBuilder DeleteGroupIpaddressExpressionServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/ip-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupIpaddressExpressionServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupIpaddressExpressionServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupIpaddressExpressionServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupIpaddressExpressionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupIpaddressExpressionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupIpaddressExpressionForDomain(string DomainId, string GroupId, string ExpressionId, NSXTIPAddressExpressionType IpaddressExpression)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (IpaddressExpression == null) { throw new System.ArgumentNullException("IpaddressExpression cannot be null"); }
            StringBuilder PatchGroupIpaddressExpressionForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/ip-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupIpaddressExpressionForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupIpaddressExpressionForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupIpaddressExpressionForDomainServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpaddressExpression);
            request.Resource = PatchGroupIpaddressExpressionForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupIpaddressExpressionForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceListResultType> GlobalGlobalInfraListServicesForTenant(string? Cursor = null, bool? DefaultService = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListServicesForTenantServiceURL = new StringBuilder("/global-infra/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DefaultService != null) { request.AddQueryParameter("default_service", DefaultService.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListServicesForTenantServiceURL.ToString();
            RestResponse<NSXTServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListServicesForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainListResultType> ListDomainForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDomainForInfraServiceURL = new StringBuilder("/infra/domains");
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
            request.Resource = ListDomainForInfraServiceURL.ToString();
            RestResponse<NSXTDomainListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceEntryListResultType> GlobalGlobalInfraListServiceEntries(string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GlobalInfraListServiceEntriesServiceURL = new StringBuilder("/global-infra/services/{service-id}/service-entries");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListServiceEntriesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListServiceEntriesServiceURL.ToString();
            RestResponse<NSXTServiceEntryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceEntryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListServiceEntriesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraSecurityConfigType> GlobalGlobalInfraUpdateSecurityGlobalConfig(NSXTInfraSecurityConfigType InfraSecurityConfig)
        {
            if (InfraSecurityConfig == null) { throw new System.ArgumentNullException("InfraSecurityConfig cannot be null"); }
            StringBuilder GlobalInfraUpdateSecurityGlobalConfigServiceURL = new StringBuilder("/global-infra/security-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(InfraSecurityConfig);
            request.Resource = GlobalInfraUpdateSecurityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTInfraSecurityConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraSecurityConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraUpdateSecurityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraSecurityConfigType> GlobalGlobalInfraReadSecurityGlobalConfig()
        {
            StringBuilder GlobalInfraReadSecurityGlobalConfigServiceURL = new StringBuilder("/global-infra/security-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GlobalInfraReadSecurityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTInfraSecurityConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraSecurityConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSecurityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceType> GlobalGlobalInfraReadServiceForTenant(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GlobalInfraReadServiceForTenantServiceURL = new StringBuilder("/global-infra/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadServiceForTenantServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadServiceForTenantServiceURL.ToString();
            RestResponse<NSXTServiceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadServiceForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> UpdateGroupForDomain(string DomainId, string GroupId, NSXTGroupType Group)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (Group == null) { throw new System.ArgumentNullException("Group cannot be null"); }
            StringBuilder UpdateGroupForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateGroupForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Group);
            request.Resource = UpdateGroupForDomainServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> ReadGroupForDomain(string DomainId, string GroupId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ReadGroupForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadGroupForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadGroupForDomainServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroup(string DomainId, string GroupId, bool? FailIfSubtreeExists = null, bool? Force = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder DeleteGroupServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (FailIfSubtreeExists != null) { request.AddQueryParameter("fail_if_subtree_exists", FailIfSubtreeExists.ToString()); }
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteGroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupForDomain(string DomainId, string GroupId, NSXTGroupType Group)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (Group == null) { throw new System.ArgumentNullException("Group cannot be null"); }
            StringBuilder PatchGroupForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Group);
            request.Resource = PatchGroupForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraType> UpdateInfra(NSXTInfraType Infra)
        {
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            StringBuilder UpdateInfraServiceURL = new StringBuilder("/infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(Infra);
            request.Resource = UpdateInfraServiceURL.ToString();
            RestResponse<NSXTInfraType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfra(NSXTInfraType Infra, bool? EnforceRevisionCheck = null)
        {
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            StringBuilder PatchInfraServiceURL = new StringBuilder("/infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(Infra);
            if (EnforceRevisionCheck != null) { request.AddQueryParameter("enforce_revision_check", EnforceRevisionCheck.ToString()); }
            request.Resource = PatchInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraType> ReadInfra(string? BasePath = null, string? Filter = null, string? TypeFilter = null)
        {
            StringBuilder ReadInfraServiceURL = new StringBuilder("/infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (BasePath != null) { request.AddQueryParameter("base_path", BasePath.ToString()); }
            if (Filter != null) { request.AddQueryParameter("filter", Filter.ToString()); }
            if (TypeFilter != null) { request.AddQueryParameter("type_filter", TypeFilter.ToString()); }
            request.Resource = ReadInfraServiceURL.ToString();
            RestResponse<NSXTInfraType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> GlobalGlobalInfraReadGroupForDomain(string DomainId, string GroupId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraReadGroupForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadGroupForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadGroupForDomainServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceEntryListResultType> ListServiceEntries(string ServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListServiceEntriesServiceURL = new StringBuilder("/infra/services/{service-id}/service-entries");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceEntriesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListServiceEntriesServiceURL.ToString();
            RestResponse<NSXTServiceEntryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceEntryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceEntriesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceListResultType> ListServicesForTenant(string? Cursor = null, bool? DefaultService = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListServicesForTenantServiceURL = new StringBuilder("/infra/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DefaultService != null) { request.AddQueryParameter("default_service", DefaultService.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListServicesForTenantServiceURL.ToString();
            RestResponse<NSXTServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServicesForTenantServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupMemberTypeListResultType> GlobalGlobalInfraGetMemberTypesForGroup(string DomainId, string GroupId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraGetMemberTypesForGroupServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/member-types");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetMemberTypesForGroupServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetMemberTypesForGroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetMemberTypesForGroupServiceURL.ToString();
            RestResponse<NSXTGroupMemberTypeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupMemberTypeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetMemberTypesForGroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddorRemoveGroupExternalIdmembers(string DomainId, string GroupId, string ExpressionId, NSXTGroupMemberListType GroupMemberList, string Action)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (GroupMemberList == null) { throw new System.ArgumentNullException("GroupMemberList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddorRemoveGroupExternalIdmembersServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/external-id-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddorRemoveGroupExternalIdmembersServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupExternalIdmembersServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupExternalIdmembersServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GroupMemberList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddorRemoveGroupExternalIdmembersServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddorRemoveGroupExternalIdmembersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupExternalIdexpressionForDomain(string DomainId, string GroupId, string ExpressionId, NSXTExternalIDExpressionType ExternalIdexpression)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (ExternalIdexpression == null) { throw new System.ArgumentNullException("ExternalIdexpression cannot be null"); }
            StringBuilder PatchGroupExternalIdexpressionForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/external-id-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupExternalIdexpressionForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupExternalIdexpressionForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupExternalIdexpressionForDomainServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ExternalIdexpression);
            request.Resource = PatchGroupExternalIdexpressionForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupExternalIdexpressionForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupExternalIdexpression(string DomainId, string GroupId, string ExpressionId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            StringBuilder DeleteGroupExternalIdexpressionServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/external-id-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupExternalIdexpressionServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupExternalIdexpressionServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupExternalIdexpressionServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupExternalIdexpressionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupExternalIdexpressionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddorRemoveGroupMacaddresses(string DomainId, string GroupId, string ExpressionId, NSXTMACAddressListType MacaddressList, string Action)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (MacaddressList == null) { throw new System.ArgumentNullException("MacaddressList cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder AddorRemoveGroupMacaddressesServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/mac-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddorRemoveGroupMacaddressesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupMacaddressesServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            AddorRemoveGroupMacaddressesServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacaddressList);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddorRemoveGroupMacaddressesServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddorRemoveGroupMacaddressesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGroupMacaddressExpressionForDomain(string DomainId, string GroupId, string ExpressionId, NSXTMACAddressExpressionType MacaddressExpression)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            if (MacaddressExpression == null) { throw new System.ArgumentNullException("MacaddressExpression cannot be null"); }
            StringBuilder PatchGroupMacaddressExpressionForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/mac-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGroupMacaddressExpressionForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupMacaddressExpressionForDomainServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGroupMacaddressExpressionForDomainServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(MacaddressExpression);
            request.Resource = PatchGroupMacaddressExpressionForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGroupMacaddressExpressionForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGroupMacaddressExpression(string DomainId, string GroupId, string ExpressionId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (ExpressionId == null) { throw new System.ArgumentNullException("ExpressionId cannot be null"); }
            StringBuilder DeleteGroupMacaddressExpressionServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/mac-address-expressions/{expression-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGroupMacaddressExpressionServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupMacaddressExpressionServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGroupMacaddressExpressionServiceURL.Replace("{expression-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExpressionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGroupMacaddressExpressionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGroupMacaddressExpressionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainListResultType> GlobalGlobalInfraListDomainForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListDomainForInfraServiceURL = new StringBuilder("/global-infra/domains");
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
            request.Resource = GlobalInfraListDomainForInfraServiceURL.ToString();
            RestResponse<NSXTDomainListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchInfra(NSXTInfraType Infra, bool? EnforceRevisionCheck = null)
        {
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            StringBuilder GlobalInfraPatchInfraServiceURL = new StringBuilder("/global-infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(Infra);
            if (EnforceRevisionCheck != null) { request.AddQueryParameter("enforce_revision_check", EnforceRevisionCheck.ToString()); }
            request.Resource = GlobalInfraPatchInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraType> GlobalGlobalInfraReadInfra(string? BasePath = null, string? Filter = null, string? TypeFilter = null)
        {
            StringBuilder GlobalInfraReadInfraServiceURL = new StringBuilder("/global-infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (BasePath != null) { request.AddQueryParameter("base_path", BasePath.ToString()); }
            if (Filter != null) { request.AddQueryParameter("filter", Filter.ToString()); }
            if (TypeFilter != null) { request.AddQueryParameter("type_filter", TypeFilter.ToString()); }
            request.Resource = GlobalInfraReadInfraServiceURL.ToString();
            RestResponse<NSXTInfraType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupListResultType> ListGroupForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, string? MemberTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListGroupForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MemberTypes != null) { request.AddQueryParameter("member_types", MemberTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGroupForDomainServiceURL.ToString();
            RestResponse<NSXTGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigType> UpdateGlobalConfig(NSXTGlobalConfigType GlobalConfig)
        {
            if (GlobalConfig == null) { throw new System.ArgumentNullException("GlobalConfig cannot be null"); }
            StringBuilder UpdateGlobalConfigServiceURL = new StringBuilder("/infra/global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(GlobalConfig);
            request.Resource = UpdateGlobalConfigServiceURL.ToString();
            RestResponse<NSXTGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalConfigType> ReadGlobalConfig()
        {
            StringBuilder ReadGlobalConfigServiceURL = new StringBuilder("/infra/global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadGlobalConfigServiceURL.ToString();
            RestResponse<NSXTGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGlobalConfig(NSXTGlobalConfigType GlobalConfig)
        {
            if (GlobalConfig == null) { throw new System.ArgumentNullException("GlobalConfig cannot be null"); }
            StringBuilder PatchGlobalConfigServiceURL = new StringBuilder("/infra/global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(GlobalConfig);
            request.Resource = PatchGlobalConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupListResultType> GlobalGlobalInfraListGroupForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, string? MemberTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraListGroupForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListGroupForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MemberTypes != null) { request.AddQueryParameter("member_types", MemberTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGroupForDomainServiceURL.ToString();
            RestResponse<NSXTGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGroupForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOpsGlobalConfigType> PutOpsGlobalConfig(NSXTOpsGlobalConfigType OpsGlobalConfig)
        {
            if (OpsGlobalConfig == null) { throw new System.ArgumentNullException("OpsGlobalConfig cannot be null"); }
            StringBuilder PutOpsGlobalConfigServiceURL = new StringBuilder("/infra/ops-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(OpsGlobalConfig);
            request.Resource = PutOpsGlobalConfigServiceURL.ToString();
            RestResponse<NSXTOpsGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOpsGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutOpsGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOpsGlobalConfigType> ReadOpsGlobalConfig()
        {
            StringBuilder ReadOpsGlobalConfigServiceURL = new StringBuilder("/infra/ops-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadOpsGlobalConfigServiceURL.ToString();
            RestResponse<NSXTOpsGlobalConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOpsGlobalConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadOpsGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchOpsGlobalConfig(NSXTOpsGlobalConfigType OpsGlobalConfig)
        {
            if (OpsGlobalConfig == null) { throw new System.ArgumentNullException("OpsGlobalConfig cannot be null"); }
            StringBuilder PatchOpsGlobalConfigServiceURL = new StringBuilder("/infra/ops-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(OpsGlobalConfig);
            request.Resource = PatchOpsGlobalConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchOpsGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraSecurityConfigType> UpdateSecurityGlobalConfig(NSXTInfraSecurityConfigType InfraSecurityConfig)
        {
            if (InfraSecurityConfig == null) { throw new System.ArgumentNullException("InfraSecurityConfig cannot be null"); }
            StringBuilder UpdateSecurityGlobalConfigServiceURL = new StringBuilder("/infra/security-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(InfraSecurityConfig);
            request.Resource = UpdateSecurityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTInfraSecurityConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraSecurityConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSecurityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraSecurityConfigType> ReadSecurityGlobalConfig()
        {
            StringBuilder ReadSecurityGlobalConfigServiceURL = new StringBuilder("/infra/security-global-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadSecurityGlobalConfigServiceURL.ToString();
            RestResponse<NSXTInfraSecurityConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraSecurityConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSecurityGlobalConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceEntryType> UpdateServiceEntry(string ServiceId, string ServiceEntryId, NSXTServiceEntryType ServiceEntry)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceEntryId == null) { throw new System.ArgumentNullException("ServiceEntryId cannot be null"); }
            if (ServiceEntry == null) { throw new System.ArgumentNullException("ServiceEntry cannot be null"); }
            StringBuilder UpdateServiceEntryServiceURL = new StringBuilder("/infra/services/{service-id}/service-entries/{service-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceEntryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceEntryServiceURL.Replace("{service-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceEntry);
            request.Resource = UpdateServiceEntryServiceURL.ToString();
            RestResponse<NSXTServiceEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceEntry(string ServiceId, string ServiceEntryId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceEntryId == null) { throw new System.ArgumentNullException("ServiceEntryId cannot be null"); }
            StringBuilder DeleteServiceEntryServiceURL = new StringBuilder("/infra/services/{service-id}/service-entries/{service-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceEntryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceEntryServiceURL.Replace("{service-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceEntryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceEntryType> ReadServiceEntry(string ServiceId, string ServiceEntryId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceEntryId == null) { throw new System.ArgumentNullException("ServiceEntryId cannot be null"); }
            StringBuilder ReadServiceEntryServiceURL = new StringBuilder("/infra/services/{service-id}/service-entries/{service-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadServiceEntryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadServiceEntryServiceURL.Replace("{service-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadServiceEntryServiceURL.ToString();
            RestResponse<NSXTServiceEntryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceEntryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadServiceEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchServiceEntry(string ServiceId, string ServiceEntryId, NSXTServiceEntryType ServiceEntry)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceEntryId == null) { throw new System.ArgumentNullException("ServiceEntryId cannot be null"); }
            if (ServiceEntry == null) { throw new System.ArgumentNullException("ServiceEntry cannot be null"); }
            StringBuilder PatchServiceEntryServiceURL = new StringBuilder("/infra/services/{service-id}/service-entries/{service-entry-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchServiceEntryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchServiceEntryServiceURL.Replace("{service-entry-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceEntryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceEntry);
            request.Resource = PatchServiceEntryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchServiceEntryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainType> UpdateDomainForInfra(string DomainId, NSXTDomainType Domain)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (Domain == null) { throw new System.ArgumentNullException("Domain cannot be null"); }
            StringBuilder UpdateDomainForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDomainForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Domain);
            request.Resource = UpdateDomainForInfraServiceURL.ToString();
            RestResponse<NSXTDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDomain(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder DeleteDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainType> ReadDomainForInfra(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ReadDomainForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDomainForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDomainForInfraServiceURL.ToString();
            RestResponse<NSXTDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDomainForInfra(string DomainId, NSXTDomainType Domain)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (Domain == null) { throw new System.ArgumentNullException("Domain cannot be null"); }
            StringBuilder PatchDomainForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDomainForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Domain);
            request.Resource = PatchDomainForInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDomainForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
