// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public TransportNodeCollection(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionStateType GetTransportNodeCollectionState(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            NSXTTransportNodeCollectionStateType returnValue = default(NSXTTransportNodeCollectionStateType);
            StringBuilder GetTransportNodeCollectionStateServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetTransportNodeCollectionStateServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeCollectionStateServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetTransportNodeCollectionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTransportNodeCollectionStateType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTransportNodeCollectionStateType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionType UpdateTransportNodeCollection(string TransportNodeCollectionId, NSXTTransportNodeCollectionType TransportNodeCollection)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (TransportNodeCollection == null) { throw new System.ArgumentNullException("TransportNodeCollection cannot be null"); }
            NSXTTransportNodeCollectionType returnValue = default(NSXTTransportNodeCollectionType);
            StringBuilder UpdateTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(TransportNodeCollection, defaultSerializationSettings));
            request.Resource = UpdateTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTransportNodeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTransportNodeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionType GetTransportNodeCollection(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            NSXTTransportNodeCollectionType returnValue = default(NSXTTransportNodeCollectionType);
            StringBuilder GetTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTransportNodeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTransportNodeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteTransportNodeCollection(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            
            StringBuilder DeleteTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionType CreateTransportNodeCollection(NSXTTransportNodeCollectionType TransportNodeCollection, bool? ApplyProfile = null)
        {
            if (TransportNodeCollection == null) { throw new System.ArgumentNullException("TransportNodeCollection cannot be null"); }
            NSXTTransportNodeCollectionType returnValue = default(NSXTTransportNodeCollectionType);
            StringBuilder CreateTransportNodeCollectionServiceURL = new StringBuilder("/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(TransportNodeCollection, defaultSerializationSettings));
            if (ApplyProfile != null) { request.AddQueryParameter("apply_profile", ApplyProfile.ToString()); }
            request.Resource = CreateTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTransportNodeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTransportNodeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionListResultType ListTransportNodeCollections(string? ClusterMoid = null, string? ComputeCollectionId = null, string? VcInstanceUuid = null)
        {
            NSXTTransportNodeCollectionListResultType returnValue = default(NSXTTransportNodeCollectionListResultType);
            StringBuilder ListTransportNodeCollectionsServiceURL = new StringBuilder("/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (ClusterMoid != null) { request.AddQueryParameter("cluster_moid", ClusterMoid.ToString()); }
            if (ComputeCollectionId != null) { request.AddQueryParameter("compute_collection_id", ComputeCollectionId.ToString()); }
            if (VcInstanceUuid != null) { request.AddQueryParameter("vc_instance_uuid", VcInstanceUuid.ToString()); }
            request.Resource = ListTransportNodeCollectionsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListTransportNodeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTTransportNodeCollectionListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTTransportNodeCollectionListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void RetryTransportNodeCollectionRealization(string TransportNodeCollectionId)
        {
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            
            StringBuilder RetryTransportNodeCollectionRealizationServiceURL = new StringBuilder("/transport-node-collections/{transport-node-collection-id}?action=retry_profile_realization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            RetryTransportNodeCollectionRealizationServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RetryTransportNodeCollectionRealizationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + RetryTransportNodeCollectionRealizationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
