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
    public class TransportNodeCollection
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportNodeCollection(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTransportNodeCollectionStateType> GetTransportNodeCollectionState(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder GetTransportNodeCollectionStateServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeCollectionStateServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeCollectionStateServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeCollectionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeCollectionType> UpdateTransportNodeCollection(string TransportNodeCollectionId, NSXTTransportNodeCollectionType TransportNodeCollection)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (TransportNodeCollection == null) { throw new System.ArgumentNullException("TransportNodeCollection cannot be null"); }
            StringBuilder UpdateTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TransportNodeCollection);
            request.Resource = UpdateTransportNodeCollectionServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeCollectionType> GetTransportNodeCollection(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder GetTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeCollectionServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTransportNodeCollection(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder DeleteTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportNodeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeCollectionType> CreateTransportNodeCollection(NSXTTransportNodeCollectionType TransportNodeCollection, bool? ApplyProfile = null)
        {
            if (TransportNodeCollection == null) { throw new System.ArgumentNullException("TransportNodeCollection cannot be null"); }
            StringBuilder CreateTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TransportNodeCollection);
            if (ApplyProfile != null) { request.AddQueryParameter("apply_profile", ApplyProfile.ToString()); }
            request.Resource = CreateTransportNodeCollectionServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTransportNodeCollectionListResultType> ListTransportNodeCollections(string? ClusterMoid = null, string? ComputeCollectionId = null, string? VcInstanceUuid = null)
        {
            StringBuilder ListTransportNodeCollectionsServiceURL = new StringBuilder("/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ClusterMoid != null) { request.AddQueryParameter("cluster_moid", ClusterMoid.ToString()); }
            if (ComputeCollectionId != null) { request.AddQueryParameter("compute_collection_id", ComputeCollectionId.ToString()); }
            if (VcInstanceUuid != null) { request.AddQueryParameter("vc_instance_uuid", VcInstanceUuid.ToString()); }
            request.Resource = ListTransportNodeCollectionsServiceURL.ToString();
            RestResponse<NSXTTransportNodeCollectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTransportNodeCollectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task RetryTransportNodeCollectionRealization(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            StringBuilder RetryTransportNodeCollectionRealizationServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}?action=retry_profile_realization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RetryTransportNodeCollectionRealizationServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RetryTransportNodeCollectionRealizationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RetryTransportNodeCollectionRealizationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
