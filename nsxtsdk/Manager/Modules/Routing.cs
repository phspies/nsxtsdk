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
    public class Routing
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Routing(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTStaticRouteType> AddStaticRoute(string LogicalRouterId, NSXTStaticRouteType StaticRoute)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (StaticRoute == null) { throw new System.ArgumentNullException("StaticRoute cannot be null"); }
            StringBuilder AddStaticRouteServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddStaticRouteServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoute);
            request.Resource = AddStaticRouteServiceURL.ToString();
            RestResponse<NSXTStaticRouteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddStaticRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteListResultType> ListStaticRoutes(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListStaticRoutesServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListStaticRoutesServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListStaticRoutesServiceURL.ToString();
            RestResponse<NSXTStaticRouteListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListStaticRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRouteMapType> AddRouteMap(string LogicalRouterId, NSXTRouteMapType RouteMap)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RouteMap == null) { throw new System.ArgumentNullException("RouteMap cannot be null"); }
            StringBuilder AddRouteMapServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddRouteMapServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RouteMap);
            request.Resource = AddRouteMapServiceURL.ToString();
            RestResponse<NSXTRouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRouteMapListResultType> ListRouteMaps(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListRouteMapsServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListRouteMapsServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListRouteMapsServiceURL.ToString();
            RestResponse<NSXTRouteMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRouteMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListRouteMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborType> ReadBgpNeighborWithPassword(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder ReadBgpNeighborWithPasswordServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{id}?action=show-sensitive-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpNeighborWithPasswordServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpNeighborWithPasswordServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpNeighborWithPasswordServiceURL.ToString();
            RestResponse<NSXTBgpNeighborType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpNeighborWithPasswordServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDADProfileType> CreateDadprofile(NSXTDADProfileType Dadprofile)
        {
            if (Dadprofile == null) { throw new System.ArgumentNullException("Dadprofile cannot be null"); }
            StringBuilder CreateDadprofileServiceURL = new StringBuilder("/ipv6/dad-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Dadprofile);
            request.Resource = CreateDadprofileServiceURL.ToString();
            RestResponse<NSXTDADProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDADProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateDadprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDADProfileListResultType> ListDadprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDadprofilesServiceURL = new StringBuilder("/ipv6/dad-profiles");
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
            request.Resource = ListDadprofilesServiceURL.ToString();
            RestResponse<NSXTDADProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDADProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDadprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedistributionConfigType> UpdateRedistributionConfig(string LogicalRouterId, NSXTRedistributionConfigType RedistributionConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RedistributionConfig == null) { throw new System.ArgumentNullException("RedistributionConfig cannot be null"); }
            StringBuilder UpdateRedistributionConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/redistribution");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRedistributionConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedistributionConfig);
            request.Resource = UpdateRedistributionConfigServiceURL.ToString();
            RestResponse<NSXTRedistributionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedistributionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRedistributionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedistributionConfigType> ReadRedistributionConfig(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadRedistributionConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/redistribution");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRedistributionConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRedistributionConfigServiceURL.ToString();
            RestResponse<NSXTRedistributionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedistributionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRedistributionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBGPCommunityListType> UpdateBgpcommunityList(string LogicalRouterId, string CommunityListId, NSXTBGPCommunityListType BgpcommunityList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            if (BgpcommunityList == null) { throw new System.ArgumentNullException("BgpcommunityList cannot be null"); }
            StringBuilder UpdateBgpcommunityListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBgpcommunityListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateBgpcommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpcommunityList);
            request.Resource = UpdateBgpcommunityListServiceURL.ToString();
            RestResponse<NSXTBGPCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBGPCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBgpcommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBGPCommunityListType> ReadBgpcommunityList(string LogicalRouterId, string CommunityListId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            StringBuilder ReadBgpcommunityListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpcommunityListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpcommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpcommunityListServiceURL.ToString();
            RestResponse<NSXTBGPCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBGPCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpcommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBgpcommunityList(string LogicalRouterId, string CommunityListId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            StringBuilder DeleteBgpcommunityListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/community-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBgpcommunityListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteBgpcommunityListServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteBgpcommunityListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBgpcommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteType> UpdateStaticRoute(string LogicalRouterId, string Id, NSXTStaticRouteType StaticRoute)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            if (StaticRoute == null) { throw new System.ArgumentNullException("StaticRoute cannot be null"); }
            StringBuilder UpdateStaticRouteServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateStaticRouteServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateStaticRouteServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticRoute);
            request.Resource = UpdateStaticRouteServiceURL.ToString();
            RestResponse<NSXTStaticRouteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateStaticRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticRouteType> ReadStaticRoute(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder ReadStaticRouteServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadStaticRouteServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadStaticRouteServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadStaticRouteServiceURL.ToString();
            RestResponse<NSXTStaticRouteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticRouteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadStaticRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteStaticRoute(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder DeleteStaticRouteServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteStaticRouteServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteStaticRouteServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteStaticRouteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteStaticRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBGPCommunityListType> CreateBgpcommunityList(string LogicalRouterId, NSXTBGPCommunityListType BgpcommunityList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BgpcommunityList == null) { throw new System.ArgumentNullException("BgpcommunityList cannot be null"); }
            StringBuilder CreateBgpcommunityListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/community-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateBgpcommunityListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpcommunityList);
            request.Resource = CreateBgpcommunityListServiceURL.ToString();
            RestResponse<NSXTBGPCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBGPCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateBgpcommunityListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBGPCommunityListListResultType> ListBgpcommunityLists(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListBgpcommunityListsServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/community-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListBgpcommunityListsServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListBgpcommunityListsServiceURL.ToString();
            RestResponse<NSXTBGPCommunityListListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBGPCommunityListListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBgpcommunityListsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticHopBfdPeerType> UpdateStaticHopBfdPeer(string LogicalRouterId, string BfdPeerId, NSXTStaticHopBfdPeerType StaticHopBfdPeer)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            if (StaticHopBfdPeer == null) { throw new System.ArgumentNullException("StaticHopBfdPeer cannot be null"); }
            StringBuilder UpdateStaticHopBfdPeerServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateStaticHopBfdPeerServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateStaticHopBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticHopBfdPeer);
            request.Resource = UpdateStaticHopBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticHopBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticHopBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateStaticHopBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticHopBfdPeerType> ReadStaticHopBfdPeer(string LogicalRouterId, string BfdPeerId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            StringBuilder ReadStaticHopBfdPeerServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadStaticHopBfdPeerServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadStaticHopBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadStaticHopBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticHopBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticHopBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadStaticHopBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteStaticHopBfdPeer(string LogicalRouterId, string BfdPeerId, bool? Force = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BfdPeerId == null) { throw new System.ArgumentNullException("BfdPeerId cannot be null"); }
            StringBuilder DeleteStaticHopBfdPeerServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/bfd-peers/{bfd-peer-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteStaticHopBfdPeerServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteStaticHopBfdPeerServiceURL.Replace("{bfd-peer-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BfdPeerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteStaticHopBfdPeerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteStaticHopBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedistributionRuleListType> UpdateRedistributionRuleList(string LogicalRouterId, NSXTRedistributionRuleListType RedistributionRuleList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RedistributionRuleList == null) { throw new System.ArgumentNullException("RedistributionRuleList cannot be null"); }
            StringBuilder UpdateRedistributionRuleListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/redistribution/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRedistributionRuleListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RedistributionRuleList);
            request.Resource = UpdateRedistributionRuleListServiceURL.ToString();
            RestResponse<NSXTRedistributionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedistributionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRedistributionRuleListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRedistributionRuleListType> ReadRedistributionRuleList(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadRedistributionRuleListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/redistribution/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRedistributionRuleListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRedistributionRuleListServiceURL.ToString();
            RestResponse<NSXTRedistributionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRedistributionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRedistributionRuleListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPPrefixListType> AddIpprefixList(string LogicalRouterId, NSXTIPPrefixListType IpprefixList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (IpprefixList == null) { throw new System.ArgumentNullException("IpprefixList cannot be null"); }
            StringBuilder AddIpprefixListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/ip-prefix-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddIpprefixListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpprefixList);
            request.Resource = AddIpprefixListServiceURL.ToString();
            RestResponse<NSXTIPPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddIpprefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPPrefixListListResultType> ListIpprefixLists(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListIpprefixListsServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/ip-prefix-lists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListIpprefixListsServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpprefixListsServiceURL.ToString();
            RestResponse<NSXTIPPrefixListListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPPrefixListListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListIpprefixListsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborType> AddBgpNeighbor(string LogicalRouterId, NSXTBgpNeighborType BgpNeighbor)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BgpNeighbor == null) { throw new System.ArgumentNullException("BgpNeighbor cannot be null"); }
            StringBuilder AddBgpNeighborServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddBgpNeighborServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighbor);
            request.Resource = AddBgpNeighborServiceURL.ToString();
            RestResponse<NSXTBgpNeighborType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddBgpNeighborServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborListResultType> ListBgpNeighbors(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListBgpNeighborsServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListBgpNeighborsServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListBgpNeighborsServiceURL.ToString();
            RestResponse<NSXTBgpNeighborListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListBgpNeighborsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDADProfileType> UpdateDadprofile(string DadProfileId, NSXTDADProfileType Dadprofile)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            if (Dadprofile == null) { throw new System.ArgumentNullException("Dadprofile cannot be null"); }
            StringBuilder UpdateDadprofileServiceURL = new StringBuilder("/ipv6/dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDadprofileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Dadprofile);
            request.Resource = UpdateDadprofileServiceURL.ToString();
            RestResponse<NSXTDADProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDADProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDadprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDADProfileType> ReadDadprofile(string DadProfileId)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder ReadDadprofileServiceURL = new StringBuilder("/ipv6/dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDadprofileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDadprofileServiceURL.ToString();
            RestResponse<NSXTDADProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDADProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDadprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDadprofile(string DadProfileId)
        {
            if (DadProfileId == null) { throw new System.ArgumentNullException("DadProfileId cannot be null"); }
            StringBuilder DeleteDadprofileServiceURL = new StringBuilder("/ipv6/dad-profiles/{dad-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDadprofileServiceURL.Replace("{dad-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DadProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDadprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDadprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticHopBfdPeerType> CreateStaticHopBfdPeer(string LogicalRouterId, NSXTStaticHopBfdPeerType StaticHopBfdPeer)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (StaticHopBfdPeer == null) { throw new System.ArgumentNullException("StaticHopBfdPeer cannot be null"); }
            StringBuilder CreateStaticHopBfdPeerServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/bfd-peers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateStaticHopBfdPeerServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticHopBfdPeer);
            request.Resource = CreateStaticHopBfdPeerServiceURL.ToString();
            RestResponse<NSXTStaticHopBfdPeerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticHopBfdPeerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateStaticHopBfdPeerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticHopBfdPeerListResultType> ListStaticHopBfdPeers(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListStaticHopBfdPeersServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/static-routes/bfd-peers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListStaticHopBfdPeersServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListStaticHopBfdPeersServiceURL.ToString();
            RestResponse<NSXTStaticHopBfdPeerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticHopBfdPeerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListStaticHopBfdPeersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAdvertiseRuleListType> UpdateAdvertiseRuleList(string LogicalRouterId, NSXTAdvertiseRuleListType AdvertiseRuleList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (AdvertiseRuleList == null) { throw new System.ArgumentNullException("AdvertiseRuleList cannot be null"); }
            StringBuilder UpdateAdvertiseRuleListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/advertisement/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAdvertiseRuleListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AdvertiseRuleList);
            request.Resource = UpdateAdvertiseRuleListServiceURL.ToString();
            RestResponse<NSXTAdvertiseRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAdvertiseRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAdvertiseRuleListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAdvertiseRuleListType> ReadAdvertiseRuleList(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadAdvertiseRuleListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/advertisement/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAdvertiseRuleListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAdvertiseRuleListServiceURL.ToString();
            RestResponse<NSXTAdvertiseRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAdvertiseRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAdvertiseRuleListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBGPCommunityListType> UpdateBgpcommunityListOld(string LogicalRouterId, string CommunityListId, NSXTBGPCommunityListType BgpcommunityList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (CommunityListId == null) { throw new System.ArgumentNullException("CommunityListId cannot be null"); }
            if (BgpcommunityList == null) { throw new System.ArgumentNullException("BgpcommunityList cannot be null"); }
            StringBuilder UpdateBgpcommunityListOldServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/communty-lists/{community-list-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBgpcommunityListOldServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateBgpcommunityListOldServiceURL.Replace("{community-list-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CommunityListId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpcommunityList);
            request.Resource = UpdateBgpcommunityListOldServiceURL.ToString();
            RestResponse<NSXTBGPCommunityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBGPCommunityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBgpcommunityListOldServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPPrefixListType> UpdateIpprefixList(string LogicalRouterId, string Id, NSXTIPPrefixListType IpprefixList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            if (IpprefixList == null) { throw new System.ArgumentNullException("IpprefixList cannot be null"); }
            StringBuilder UpdateIpprefixListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/ip-prefix-lists/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateIpprefixListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateIpprefixListServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(IpprefixList);
            request.Resource = UpdateIpprefixListServiceURL.ToString();
            RestResponse<NSXTIPPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateIpprefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPPrefixListType> ReadIpprefixList(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder ReadIpprefixListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/ip-prefix-lists/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadIpprefixListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIpprefixListServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpprefixListServiceURL.ToString();
            RestResponse<NSXTIPPrefixListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPPrefixListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadIpprefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpprefixList(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder DeleteIpprefixListServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/ip-prefix-lists/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteIpprefixListServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIpprefixListServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpprefixListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteIpprefixListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRouteMapType> UpdateRouteMap(string LogicalRouterId, string Id, NSXTRouteMapType RouteMap)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            if (RouteMap == null) { throw new System.ArgumentNullException("RouteMap cannot be null"); }
            StringBuilder UpdateRouteMapServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-maps/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRouteMapServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateRouteMapServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RouteMap);
            request.Resource = UpdateRouteMapServiceURL.ToString();
            RestResponse<NSXTRouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRouteMapType> ReadRouteMap(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder ReadRouteMapServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-maps/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRouteMapServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadRouteMapServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRouteMapServiceURL.ToString();
            RestResponse<NSXTRouteMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRouteMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRouteMap(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder DeleteRouteMapServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/route-maps/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRouteMapServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteRouteMapServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRouteMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRouteMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNDRAProfileType> CreateNdraprofile(NSXTNDRAProfileType Ndraprofile)
        {
            if (Ndraprofile == null) { throw new System.ArgumentNullException("Ndraprofile cannot be null"); }
            StringBuilder CreateNdraprofileServiceURL = new StringBuilder("/ipv6/nd-ra-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Ndraprofile);
            request.Resource = CreateNdraprofileServiceURL.ToString();
            RestResponse<NSXTNDRAProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNDRAProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNdraprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNDRAProfileListResultType> ListNdraprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListNdraprofilesServiceURL = new StringBuilder("/ipv6/nd-ra-profiles");
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
            request.Resource = ListNdraprofilesServiceURL.ToString();
            RestResponse<NSXTNDRAProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNDRAProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNdraprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingConfigType> UpdateRoutingConfig(string LogicalRouterId, NSXTRoutingConfigType RoutingConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RoutingConfig == null) { throw new System.ArgumentNullException("RoutingConfig cannot be null"); }
            StringBuilder UpdateRoutingConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRoutingConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RoutingConfig);
            request.Resource = UpdateRoutingConfigServiceURL.ToString();
            RestResponse<NSXTRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRoutingConfigType> ReadRoutingConfig(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadRoutingConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRoutingConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRoutingConfigServiceURL.ToString();
            RestResponse<NSXTRoutingConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRoutingConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRoutingConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAdvertisementConfigType> UpdateAdvertisementConfig(string LogicalRouterId, NSXTAdvertisementConfigType AdvertisementConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (AdvertisementConfig == null) { throw new System.ArgumentNullException("AdvertisementConfig cannot be null"); }
            StringBuilder UpdateAdvertisementConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/advertisement");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateAdvertisementConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(AdvertisementConfig);
            request.Resource = UpdateAdvertisementConfigServiceURL.ToString();
            RestResponse<NSXTAdvertisementConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAdvertisementConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAdvertisementConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAdvertisementConfigType> ReadAdvertisementConfig(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadAdvertisementConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/advertisement");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadAdvertisementConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadAdvertisementConfigServiceURL.ToString();
            RestResponse<NSXTAdvertisementConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAdvertisementConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAdvertisementConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborType> UpdateBgpNeighbor(string LogicalRouterId, string Id, NSXTBgpNeighborType BgpNeighbor)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            if (BgpNeighbor == null) { throw new System.ArgumentNullException("BgpNeighbor cannot be null"); }
            StringBuilder UpdateBgpNeighborServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBgpNeighborServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateBgpNeighborServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpNeighbor);
            request.Resource = UpdateBgpNeighborServiceURL.ToString();
            RestResponse<NSXTBgpNeighborType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBgpNeighborServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborType> UnSetPasswordOnBgpNeighbor(string LogicalRouterId, string Id, string? Action = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder UnSetPasswordOnBgpNeighborServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UnSetPasswordOnBgpNeighborServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UnSetPasswordOnBgpNeighborServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = UnSetPasswordOnBgpNeighborServiceURL.ToString();
            RestResponse<NSXTBgpNeighborType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UnSetPasswordOnBgpNeighborServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpNeighborType> ReadBgpNeighbor(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder ReadBgpNeighborServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpNeighborServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadBgpNeighborServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpNeighborServiceURL.ToString();
            RestResponse<NSXTBgpNeighborType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpNeighborType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpNeighborServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteBgpNeighbor(string LogicalRouterId, string Id)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder DeleteBgpNeighborServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp/neighbors/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteBgpNeighborServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteBgpNeighborServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteBgpNeighborServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteBgpNeighborServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdConfigType> UpdateRoutingBfdConfig(string LogicalRouterId, NSXTBfdConfigType BfdConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BfdConfig == null) { throw new System.ArgumentNullException("BfdConfig cannot be null"); }
            StringBuilder UpdateRoutingBfdConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bfd-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRoutingBfdConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BfdConfig);
            request.Resource = UpdateRoutingBfdConfigServiceURL.ToString();
            RestResponse<NSXTBfdConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRoutingBfdConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBfdConfigType> ReadRoutingBfdConfig(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadRoutingBfdConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bfd-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadRoutingBfdConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadRoutingBfdConfigServiceURL.ToString();
            RestResponse<NSXTBfdConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBfdConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadRoutingBfdConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpConfigType> UpdateBgpConfig(string LogicalRouterId, NSXTBgpConfigType BgpConfig)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (BgpConfig == null) { throw new System.ArgumentNullException("BgpConfig cannot be null"); }
            StringBuilder UpdateBgpConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateBgpConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BgpConfig);
            request.Resource = UpdateBgpConfigServiceURL.ToString();
            RestResponse<NSXTBgpConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateBgpConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBgpConfigType> ReadBgpConfig(string LogicalRouterId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ReadBgpConfigServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/routing/bgp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadBgpConfigServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadBgpConfigServiceURL.ToString();
            RestResponse<NSXTBgpConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBgpConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadBgpConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNDRAProfileType> UpdateNdraprofile(string NdRaProfileId, NSXTNDRAProfileType Ndraprofile)
        {
            if (NdRaProfileId == null) { throw new System.ArgumentNullException("NdRaProfileId cannot be null"); }
            if (Ndraprofile == null) { throw new System.ArgumentNullException("Ndraprofile cannot be null"); }
            StringBuilder UpdateNdraprofileServiceURL = new StringBuilder("/ipv6/nd-ra-profiles/{nd-ra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNdraprofileServiceURL.Replace("{nd-ra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdRaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Ndraprofile);
            request.Resource = UpdateNdraprofileServiceURL.ToString();
            RestResponse<NSXTNDRAProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNDRAProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNdraprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNdraprofile(string NdRaProfileId)
        {
            if (NdRaProfileId == null) { throw new System.ArgumentNullException("NdRaProfileId cannot be null"); }
            StringBuilder DeleteNdraprofileServiceURL = new StringBuilder("/ipv6/nd-ra-profiles/{nd-ra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNdraprofileServiceURL.Replace("{nd-ra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdRaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNdraprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNdraprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNDRAProfileType> ReadNdraprofile(string NdRaProfileId)
        {
            if (NdRaProfileId == null) { throw new System.ArgumentNullException("NdRaProfileId cannot be null"); }
            StringBuilder ReadNdraprofileServiceURL = new StringBuilder("/ipv6/nd-ra-profiles/{nd-ra-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNdraprofileServiceURL.Replace("{nd-ra-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NdRaProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNdraprofileServiceURL.ToString();
            RestResponse<NSXTNDRAProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNDRAProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNdraprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
