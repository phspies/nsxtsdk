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
    public class DirectoryService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DirectoryService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDirectoryDomainSizeType> ScanDirectoryDomainSize(NSXTDirectoryDomainType DirectoryDomain)
        {
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder ScanDirectoryDomainSizeServiceURL = new StringBuilder("/directory/domain-size");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryDomain);
            request.Resource = ScanDirectoryDomainSizeServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainSizeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainSizeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ScanDirectoryDomainSizeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerStatusType> VerifyDirectoryLdapServer(NSXTDirectoryLdapServerType DirectoryLdapServer, string Action)
        {
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder VerifyDirectoryLdapServerServiceURL = new StringBuilder("/directory/ldap-server");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryLdapServer);
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = VerifyDirectoryLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + VerifyDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryOrgUnitListResultsType> FetchDirectoryOrgUnits(NSXTDirectoryLdapServerType DirectoryLdapServer)
        {
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder FetchDirectoryOrgUnitsServiceURL = new StringBuilder("/directory/org-units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryLdapServer);
            request.Resource = FetchDirectoryOrgUnitsServiceURL.ToString();
            RestResponse<NSXTDirectoryOrgUnitListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryOrgUnitListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FetchDirectoryOrgUnitsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryOrgUnitListResultsType> FetchDirectoryOrgUnitsForDirectoryDomain(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder FetchDirectoryOrgUnitsForDirectoryDomainServiceURL = new StringBuilder("/directory/domains/{domain-id}/org-units");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FetchDirectoryOrgUnitsForDirectoryDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = FetchDirectoryOrgUnitsForDirectoryDomainServiceURL.ToString();
            RestResponse<NSXTDirectoryOrgUnitListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryOrgUnitListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FetchDirectoryOrgUnitsForDirectoryDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainSyncStatsType> GetDirectoryDomainSyncStats(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GetDirectoryDomainSyncStatsServiceURL = new StringBuilder("/directory/domains/{domain-id}/sync-stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDirectoryDomainSyncStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDirectoryDomainSyncStatsServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainSyncStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainSyncStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDirectoryDomainSyncStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryGroupListResultsType> SearchDirectoryGroups(string DomainId, string FilterValue, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (FilterValue == null) { throw new System.ArgumentNullException("FilterValue cannot be null"); }
            StringBuilder SearchDirectoryGroupsServiceURL = new StringBuilder("/directory/domains/{domain-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            SearchDirectoryGroupsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FilterValue != null) { request.AddQueryParameter("filter_value", FilterValue.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = SearchDirectoryGroupsServiceURL.ToString();
            RestResponse<NSXTDirectoryGroupListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryGroupListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + SearchDirectoryGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> CreateDirectoryLdapServer(string DomainId, NSXTDirectoryLdapServerType DirectoryLdapServer)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder CreateDirectoryLdapServerServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateDirectoryLdapServerServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryLdapServer);
            request.Resource = CreateDirectoryLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerListResultsType> ListDirectoryLdapServers(string DomainId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListDirectoryLdapServersServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDirectoryLdapServersServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDirectoryLdapServersServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDirectoryLdapServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainType> UpdateDirectoryDomain(string DomainId, NSXTDirectoryDomainType DirectoryDomain)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder UpdateDirectoryDomainServiceURL = new StringBuilder("/directory/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDirectoryDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryDomain);
            request.Resource = UpdateDirectoryDomainServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDirectoryDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RequestDirectoryDomainSync(string DomainId, string Action, long? Delay = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder RequestDirectoryDomainSyncServiceURL = new StringBuilder("/directory/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RequestDirectoryDomainSyncServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (Delay != null) { request.AddQueryParameter("delay", Delay.ToString()); }
            request.Resource = RequestDirectoryDomainSyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RequestDirectoryDomainSyncServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDirectoryDomain(string DomainId, bool? Force = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder DeleteDirectoryDomainServiceURL = new StringBuilder("/directory/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDirectoryDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteDirectoryDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDirectoryDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainType> GetDirectoryDomain(string DomainId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GetDirectoryDomainServiceURL = new StringBuilder("/directory/domains/{domain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDirectoryDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDirectoryDomainServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDirectoryDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainType> CreateDirectoryDomain(NSXTDirectoryDomainType DirectoryDomain)
        {
            if (DirectoryDomain == null) { throw new System.ArgumentNullException("DirectoryDomain cannot be null"); }
            StringBuilder CreateDirectoryDomainServiceURL = new StringBuilder("/directory/domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(DirectoryDomain);
            request.Resource = CreateDirectoryDomainServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDirectoryDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryDomainListResultsType> ListDirectoryDomains(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDirectoryDomainsServiceURL = new StringBuilder("/directory/domains");
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
            request.Resource = ListDirectoryDomainsServiceURL.ToString();
            RestResponse<NSXTDirectoryDomainListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryDomainListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDirectoryDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> UpdateDirectoryLdapServer(string DomainId, string ServerId, NSXTDirectoryLdapServerType DirectoryLdapServer)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (DirectoryLdapServer == null) { throw new System.ArgumentNullException("DirectoryLdapServer cannot be null"); }
            StringBuilder UpdateDirectoryLdapServerServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDirectoryLdapServerServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDirectoryLdapServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DirectoryLdapServer);
            request.Resource = UpdateDirectoryLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task TestDirectoryLdapServer(string DomainId, string ServerId, string Action)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder TestDirectoryLdapServerServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            TestDirectoryLdapServerServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            TestDirectoryLdapServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = TestDirectoryLdapServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TestDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryLdapServerType> GetDirectoryLdapServer(string DomainId, string ServerId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDirectoryLdapServerServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDirectoryLdapServerServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDirectoryLdapServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDirectoryLdapServerServiceURL.ToString();
            RestResponse<NSXTDirectoryLdapServerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryLdapServerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDirectoryLdapServer(string DomainId, string ServerId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder DeleteDirectoryLdapServerServiceURL = new StringBuilder("/directory/domains/{domain-id}/ldap-servers/{server-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDirectoryLdapServerServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDirectoryLdapServerServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDirectoryLdapServerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDirectoryLdapServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDirectoryGroupMemberListResultsType> ListDirectoryGroupMemberGroups(string DomainId, string GroupId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ListDirectoryGroupMemberGroupsServiceURL = new StringBuilder("/directory/domains/{domain-id}/groups/{group-id}/member-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDirectoryGroupMemberGroupsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListDirectoryGroupMemberGroupsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDirectoryGroupMemberGroupsServiceURL.ToString();
            RestResponse<NSXTDirectoryGroupMemberListResultsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDirectoryGroupMemberListResultsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDirectoryGroupMemberGroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
