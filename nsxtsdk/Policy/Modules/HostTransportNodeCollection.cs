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
    public class HostTransportNodeCollection
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HostTransportNodeCollection(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task RemoveNsxonTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder RemoveNsxonTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=remove_nsx");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RemoveNsxonTransportNodeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RemoveNsxonTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RetryHostTransportNodeCollectionRealization(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder RetryHostTransportNodeCollectionRealizationServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=retry_profile_realization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RetryHostTransportNodeCollectionRealizationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RetryHostTransportNodeCollectionRealizationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeCollectionListResultType> ListHostTransportNodeCollections(string SiteId, string EnforcementpointId, string? ClusterMoid = null, string? ComputeCollectionId = null, string? VcInstanceUuid = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            StringBuilder ListHostTransportNodeCollectionsServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListHostTransportNodeCollectionsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListHostTransportNodeCollectionsServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterMoid != null) { request.AddQueryParameter("cluster_moid", ClusterMoid.ToString()); }
            if (ComputeCollectionId != null) { request.AddQueryParameter("compute_collection_id", ComputeCollectionId.ToString()); }
            if (VcInstanceUuid != null) { request.AddQueryParameter("vc_instance_uuid", VcInstanceUuid.ToString()); }
            request.Resource = ListHostTransportNodeCollectionsServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListHostTransportNodeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeCollectionType> CreateOrUpdateHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionsId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection, bool? ApplyProfile = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionsId == null) { throw new System.ArgumentNullException("TransportNodeCollectionsId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            StringBuilder CreateOrUpdateHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collections-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{transport-node-collections-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(HostTransportNodeCollection);
            if (ApplyProfile != null) { request.AddQueryParameter("apply_profile", ApplyProfile.ToString()); }
            request.Resource = CreateOrUpdateHostTransportNodeCollectionServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ConfigureTransportNodeCollectionForSecurity(string SiteId, string EnforcementpointId, string TransportNodeCollectionId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            StringBuilder ConfigureTransportNodeCollectionForSecurityServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=install_for_microseg");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(HostTransportNodeCollection);
            request.Resource = ConfigureTransportNodeCollectionForSecurityServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ConfigureTransportNodeCollectionForSecurityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeCollectionStateType> GetHostTransportNodeCollectionState(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder GetHostTransportNodeCollectionStateServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostTransportNodeCollectionStateServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionStateServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionStateServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeCollectionStateServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostTransportNodeCollectionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostTransportNodeCollectionType> GetHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder GetHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeCollectionServiceURL.ToString();
            RestResponse<NSXTHostTransportNodeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostTransportNodeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder DeleteHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteHostTransportNodeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            StringBuilder PatchHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(HostTransportNodeCollection);
            request.Resource = PatchHostTransportNodeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
