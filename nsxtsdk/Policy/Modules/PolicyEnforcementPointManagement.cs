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
    public class PolicyEnforcementPointManagement
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyEnforcementPointManagement(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task FullSyncEnforcementPointForSite(string SiteId, string EnforcementPointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            StringBuilder FullSyncEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}?action=full-sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FullSyncEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            FullSyncEnforcementPointForSiteServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = FullSyncEnforcementPointForSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FullSyncEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterType> GlobalGlobalInfraReadEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GlobalInfraReadEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainDeploymentMapType> GlobalGlobalInfraReadDomainDeploymentMapForInfra(string DomainId, string DomainDeploymentMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DomainDeploymentMapId == null) { throw new System.ArgumentNullException("DomainDeploymentMapId cannot be null"); }
            StringBuilder GlobalInfraReadDomainDeploymentMapForInfraServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/domain-deployment-maps/{domain-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadDomainDeploymentMapForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadDomainDeploymentMapForInfraServiceURL.Replace("{domain-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainDeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadDomainDeploymentMapForInfraServiceURL.ToString();
            RestResponse<NSXTDomainDeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainDeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadDomainDeploymentMapForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointListResultType> GlobalGlobalInfraListEnforcementPointForSite(string SiteId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GlobalInfraListEnforcementPointForSiteServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentZoneType> ReadDeploymentZoneInfra(string DeploymentZoneId)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            StringBuilder ReadDeploymentZoneInfraServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDeploymentZoneInfraServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDeploymentZoneInfraServiceURL.ToString();
            RestResponse<NSXTDeploymentZoneType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentZoneType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDeploymentZoneInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterType> ReadEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder ReadEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapType> GlobalGlobalInfraReadTier0DeploymentMap(string Tier0Id, string LocaleServiceId, string Tier0DeploymentMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (Tier0DeploymentMapId == null) { throw new System.ArgumentNullException("Tier0DeploymentMapId cannot be null"); }
            StringBuilder GlobalInfraReadTier0DeploymentMapServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps/{tier-0-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0DeploymentMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0DeploymentMapServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0DeploymentMapServiceURL.Replace("{tier-0-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0DeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0DeploymentMapServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0DeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointListResultType> ListEnforcementPointForInfra(string DeploymentZoneId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            StringBuilder ListEnforcementPointForInfraServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}/enforcement-points");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEnforcementPointForInfraServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEnforcementPointForInfraServiceURL.ToString();
            RestResponse<NSXTEnforcementPointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEnforcementPointForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteType> GlobalGlobalInfraReadSite(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GlobalInfraReadSiteServiceURL = new StringBuilder("/global-infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSiteServiceURL.ToString();
            RestResponse<NSXTSiteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentZoneListResultType> ListDeploymentZonesForInfra(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDeploymentZonesForInfraServiceURL = new StringBuilder("/infra/deployment-zones");
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
            request.Resource = ListDeploymentZonesForInfraServiceURL.ToString();
            RestResponse<NSXTDeploymentZoneListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentZoneListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDeploymentZonesForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> CreateOrUpdateEnforcementPointForInfra(string DeploymentZoneId, string EnforcementpointId, NSXTEnforcementPointType EnforcementPoint)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EnforcementPoint == null) { throw new System.ArgumentNullException("EnforcementPoint cannot be null"); }
            StringBuilder CreateOrUpdateEnforcementPointForInfraServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEnforcementPointForInfraServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEnforcementPointForInfraServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EnforcementPoint);
            request.Resource = CreateOrUpdateEnforcementPointForInfraServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEnforcementPointForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEnforcementPointForInfra(string DeploymentZoneId, string EnforcementpointId, NSXTEnforcementPointType EnforcementPoint)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EnforcementPoint == null) { throw new System.ArgumentNullException("EnforcementPoint cannot be null"); }
            StringBuilder PatchEnforcementPointForInfraServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEnforcementPointForInfraServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEnforcementPointForInfraServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EnforcementPoint);
            request.Resource = PatchEnforcementPointForInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEnforcementPointForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEnforcementPoint(string DeploymentZoneId, string EnforcementpointId)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder DeleteEnforcementPointServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEnforcementPointServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEnforcementPointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> ReadEnforcementPointForInfra(string DeploymentZoneId, string EnforcementpointId)
        {
            if (DeploymentZoneId == null) { throw new System.ArgumentNullException("DeploymentZoneId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ReadEnforcementPointForInfraServiceURL = new StringBuilder("/infra/deployment-zones/{deployment-zone-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEnforcementPointForInfraServiceURL.Replace("{deployment-zone-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DeploymentZoneId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEnforcementPointForInfraServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEnforcementPointForInfraServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEnforcementPointForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteType> CreateOrUpdateInfraSite(string SiteId, NSXTSiteType Site)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (Site == null) { throw new System.ArgumentNullException("Site cannot be null"); }
            StringBuilder CreateOrUpdateInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Site);
            request.Resource = CreateOrUpdateInfraSiteServiceURL.ToString();
            RestResponse<NSXTSiteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteType> ReadSite(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder ReadSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSiteServiceURL.ToString();
            RestResponse<NSXTSiteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSite(string SiteId, NSXTSiteType Site)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (Site == null) { throw new System.ArgumentNullException("Site cannot be null"); }
            StringBuilder PatchInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Site);
            request.Resource = PatchInfraSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSite(string SiteId, bool? Force = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder DeleteInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteInfraSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainDeploymentMapListResultType> ListDomainDeploymentMapsForInfra(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListDomainDeploymentMapsForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}/domain-deployment-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListDomainDeploymentMapsForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDomainDeploymentMapsForInfraServiceURL.ToString();
            RestResponse<NSXTDomainDeploymentMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainDeploymentMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDomainDeploymentMapsForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapListResultType> ListTier0DeploymentMaps(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder ListTier0DeploymentMapsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0DeploymentMapsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListTier0DeploymentMapsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0DeploymentMapsServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0DeploymentMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteListResultType> ListSites(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListSitesServiceURL = new StringBuilder("/infra/sites");
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
            request.Resource = ListSitesServiceURL.ToString();
            RestResponse<NSXTSiteListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSitesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> GlobalGlobalInfraReadEnforcementPointForSite(string SiteId, string EnforcementpointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder GlobalInfraReadEnforcementPointForSiteServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> CreateOrUpdateEnforcementPointForSite(string SiteId, string EnforcementpointId, NSXTEnforcementPointType EnforcementPoint)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EnforcementPoint == null) { throw new System.ArgumentNullException("EnforcementPoint cannot be null"); }
            StringBuilder CreateOrUpdateEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EnforcementPoint);
            request.Resource = CreateOrUpdateEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEnforcementPointForSite(string SiteId, string EnforcementpointId, NSXTEnforcementPointType EnforcementPoint)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EnforcementPoint == null) { throw new System.ArgumentNullException("EnforcementPoint cannot be null"); }
            StringBuilder PatchEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EnforcementPoint);
            request.Resource = PatchEnforcementPointForSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> ReadEnforcementPointForSite(string SiteId, string EnforcementpointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ReadEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEnforcementPointForSite(string SiteId, string EnforcementpointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder DeleteEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEnforcementPointForSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainDeploymentMapListResultType> GlobalGlobalInfraListDomainDeploymentMapsForInfra(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraListDomainDeploymentMapsForInfraServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/domain-deployment-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListDomainDeploymentMapsForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListDomainDeploymentMapsForInfraServiceURL.ToString();
            RestResponse<NSXTDomainDeploymentMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainDeploymentMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListDomainDeploymentMapsForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeNodeType> GlobalGlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId, string EdgeNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            StringBuilder GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}/edge-nodes/{edge-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapListResultType> GlobalGlobalInfraListTier0DeploymentMaps(string Tier0Id, string LocaleServiceId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            StringBuilder GlobalInfraListTier0DeploymentMapsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier0DeploymentMapsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListTier0DeploymentMapsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0DeploymentMapsServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0DeploymentMapsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeNodeListResultType> GlobalGlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}/edge-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointType> ReloadEnforcementPointForSite(string SiteId, string EnforcementpointId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ReloadEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}?action=reload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReloadEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReloadEnforcementPointForSiteServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReloadEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReloadEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeNodeListResultType> ListEdgeNodesUnderEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            StringBuilder ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}/edge-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEdgeNodesUnderEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainDeploymentMapType> CreateOrUpdateDomainDeploymentMapForInfra(string DomainId, string DomainDeploymentMapId, NSXTDomainDeploymentMapType DomainDeploymentMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DomainDeploymentMapId == null) { throw new System.ArgumentNullException("DomainDeploymentMapId cannot be null"); }
            if (DomainDeploymentMap == null) { throw new System.ArgumentNullException("DomainDeploymentMap cannot be null"); }
            StringBuilder CreateOrUpdateDomainDeploymentMapForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}/domain-deployment-maps/{domain-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateDomainDeploymentMapForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateDomainDeploymentMapForInfraServiceURL.Replace("{domain-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainDeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DomainDeploymentMap);
            request.Resource = CreateOrUpdateDomainDeploymentMapForInfraServiceURL.ToString();
            RestResponse<NSXTDomainDeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainDeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateDomainDeploymentMapForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDomainDeploymentMapForInfra(string DomainId, string DomainDeploymentMapId, NSXTDomainDeploymentMapType DomainDeploymentMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DomainDeploymentMapId == null) { throw new System.ArgumentNullException("DomainDeploymentMapId cannot be null"); }
            if (DomainDeploymentMap == null) { throw new System.ArgumentNullException("DomainDeploymentMap cannot be null"); }
            StringBuilder PatchDomainDeploymentMapForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}/domain-deployment-maps/{domain-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDomainDeploymentMapForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDomainDeploymentMapForInfraServiceURL.Replace("{domain-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainDeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DomainDeploymentMap);
            request.Resource = PatchDomainDeploymentMapForInfraServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDomainDeploymentMapForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDomainDeploymentMap(string DomainId, string DomainDeploymentMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DomainDeploymentMapId == null) { throw new System.ArgumentNullException("DomainDeploymentMapId cannot be null"); }
            StringBuilder DeleteDomainDeploymentMapServiceURL = new StringBuilder("/infra/domains/{domain-id}/domain-deployment-maps/{domain-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDomainDeploymentMapServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDomainDeploymentMapServiceURL.Replace("{domain-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainDeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDomainDeploymentMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDomainDeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDomainDeploymentMapType> ReadDomainDeploymentMapForInfra(string DomainId, string DomainDeploymentMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (DomainDeploymentMapId == null) { throw new System.ArgumentNullException("DomainDeploymentMapId cannot be null"); }
            StringBuilder ReadDomainDeploymentMapForInfraServiceURL = new StringBuilder("/infra/domains/{domain-id}/domain-deployment-maps/{domain-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDomainDeploymentMapForInfraServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadDomainDeploymentMapForInfraServiceURL.Replace("{domain-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainDeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDomainDeploymentMapForInfraServiceURL.ToString();
            RestResponse<NSXTDomainDeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDomainDeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDomainDeploymentMapForInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapType> CreateOrUpdateTier0DeploymentMap(string Tier0Id, string LocaleServiceId, string Tier0DeploymentMapId, NSXTTier0DeploymentMapType Tier0DeploymentMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (Tier0DeploymentMapId == null) { throw new System.ArgumentNullException("Tier0DeploymentMapId cannot be null"); }
            if (Tier0DeploymentMap == null) { throw new System.ArgumentNullException("Tier0DeploymentMap cannot be null"); }
            StringBuilder CreateOrUpdateTier0DeploymentMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps/{tier-0-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTier0DeploymentMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0DeploymentMapServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateTier0DeploymentMapServiceURL.Replace("{tier-0-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0DeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0DeploymentMap);
            request.Resource = CreateOrUpdateTier0DeploymentMapServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTier0DeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapType> ReadTier0DeploymentMap(string Tier0Id, string LocaleServiceId, string Tier0DeploymentMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (Tier0DeploymentMapId == null) { throw new System.ArgumentNullException("Tier0DeploymentMapId cannot be null"); }
            StringBuilder ReadTier0DeploymentMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps/{tier-0-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0DeploymentMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0DeploymentMapServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0DeploymentMapServiceURL.Replace("{tier-0-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0DeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0DeploymentMapServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0DeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTier0DeploymentMapType> PatchTier0DeploymentMap(string Tier0Id, string LocaleServiceId, string Tier0DeploymentMapId, NSXTTier0DeploymentMapType Tier0DeploymentMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (Tier0DeploymentMapId == null) { throw new System.ArgumentNullException("Tier0DeploymentMapId cannot be null"); }
            if (Tier0DeploymentMap == null) { throw new System.ArgumentNullException("Tier0DeploymentMap cannot be null"); }
            StringBuilder PatchTier0DeploymentMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps/{tier-0-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0DeploymentMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0DeploymentMapServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0DeploymentMapServiceURL.Replace("{tier-0-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0DeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Tier0DeploymentMap);
            request.Resource = PatchTier0DeploymentMapServiceURL.ToString();
            RestResponse<NSXTTier0DeploymentMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTier0DeploymentMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0DeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0DeploymentMap(string Tier0Id, string LocaleServiceId, string Tier0DeploymentMapId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (Tier0DeploymentMapId == null) { throw new System.ArgumentNullException("Tier0DeploymentMapId cannot be null"); }
            StringBuilder DeleteTier0DeploymentMapServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/tier-0-deployment-maps/{tier-0-deployment-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0DeploymentMapServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0DeploymentMapServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0DeploymentMapServiceURL.Replace("{tier-0-deployment-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0DeploymentMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0DeploymentMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0DeploymentMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeNodeType> ReadEdgeNodeUnderEdgeClusterForEnforcementPoint(string SiteId, string EnforcementpointId, string EdgeClusterId, string EdgeNodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (EdgeClusterId == null) { throw new System.ArgumentNullException("EdgeClusterId cannot be null"); }
            if (EdgeNodeId == null) { throw new System.ArgumentNullException("EdgeNodeId cannot be null"); }
            StringBuilder ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters/{edge-cluster-id}/edge-nodes/{edge-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.Replace("{edge-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EdgeNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEdgeNodeUnderEdgeClusterForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterListResultType> GlobalGlobalInfraListEdgeClustersForEnforcementPoint(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder GlobalInfraListEdgeClustersForEnforcementPointServiceURL = new StringBuilder("/global-infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListEdgeClustersForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListEdgeClustersForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListEdgeClustersForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListEdgeClustersForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteListResultType> GlobalGlobalInfraListSites(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListSitesServiceURL = new StringBuilder("/global-infra/sites");
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
            request.Resource = GlobalInfraListSitesServiceURL.ToString();
            RestResponse<NSXTSiteListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSitesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyEdgeClusterListResultType> ListEdgeClustersForEnforcementPoint(string SiteId, string EnforcementpointId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListEdgeClustersForEnforcementPointServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/edge-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEdgeClustersForEnforcementPointServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListEdgeClustersForEnforcementPointServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEdgeClustersForEnforcementPointServiceURL.ToString();
            RestResponse<NSXTPolicyEdgeClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyEdgeClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEdgeClustersForEnforcementPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEnforcementPointListResultType> ListEnforcementPointForSite(string SiteId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder ListEnforcementPointForSiteServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEnforcementPointForSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEnforcementPointForSiteServiceURL.ToString();
            RestResponse<NSXTEnforcementPointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEnforcementPointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEnforcementPointForSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
