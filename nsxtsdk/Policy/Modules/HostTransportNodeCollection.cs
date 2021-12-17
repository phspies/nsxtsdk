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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class HostTransportNodeCollection
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public HostTransportNodeCollection(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void RemoveNsxonTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            
            StringBuilder RemoveNsxonTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=remove_nsx");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveNsxonTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RemoveNsxonTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + RemoveNsxonTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void RetryHostTransportNodeCollectionRealization(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            
            StringBuilder RetryHostTransportNodeCollectionRealizationServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=retry_profile_realization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            RetryHostTransportNodeCollectionRealizationServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RetryHostTransportNodeCollectionRealizationServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + RetryHostTransportNodeCollectionRealizationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTHostTransportNodeCollectionListResultType ListHostTransportNodeCollections(string SiteId, string EnforcementpointId, string? ClusterMoid = null, string? ComputeCollectionId = null, string? VcInstanceUuid = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            NSXTHostTransportNodeCollectionListResultType returnValue = default(NSXTHostTransportNodeCollectionListResultType);
            StringBuilder ListHostTransportNodeCollectionsServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListHostTransportNodeCollectionsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListHostTransportNodeCollectionsServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ClusterMoid != null) { request.AddQueryParameter("cluster_moid", ClusterMoid.ToString()); }
            if (ComputeCollectionId != null) { request.AddQueryParameter("compute_collection_id", ComputeCollectionId.ToString()); }
            if (VcInstanceUuid != null) { request.AddQueryParameter("vc_instance_uuid", VcInstanceUuid.ToString()); }
            request.Resource = ListHostTransportNodeCollectionsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListHostTransportNodeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTHostTransportNodeCollectionListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTHostTransportNodeCollectionListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTHostTransportNodeCollectionType CreateOrUpdateHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionsId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection, bool? ApplyProfile = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionsId == null) { throw new System.ArgumentNullException("TransportNodeCollectionsId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            NSXTHostTransportNodeCollectionType returnValue = default(NSXTHostTransportNodeCollectionType);
            StringBuilder CreateOrUpdateHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collections-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateHostTransportNodeCollectionServiceURL.Replace("{transport-node-collections-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionsId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(HostTransportNodeCollection, defaultSerializationSettings));
            if (ApplyProfile != null) { request.AddQueryParameter("apply_profile", ApplyProfile.ToString()); }
            request.Resource = CreateOrUpdateHostTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdateHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTHostTransportNodeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTHostTransportNodeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void ConfigureTransportNodeCollectionForSecurity(string SiteId, string EnforcementpointId, string TransportNodeCollectionId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            
            StringBuilder ConfigureTransportNodeCollectionForSecurityServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}?action=install_for_microseg");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            ConfigureTransportNodeCollectionForSecurityServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(HostTransportNodeCollection, defaultSerializationSettings));
            request.Resource = ConfigureTransportNodeCollectionForSecurityServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ConfigureTransportNodeCollectionForSecurityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTransportNodeCollectionStateType GetHostTransportNodeCollectionState(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            NSXTTransportNodeCollectionStateType returnValue = default(NSXTTransportNodeCollectionStateType);
            StringBuilder GetHostTransportNodeCollectionStateServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetHostTransportNodeCollectionStateServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionStateServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionStateServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeCollectionStateServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetHostTransportNodeCollectionStateServiceURL.ToString() + " did not complete successfull";
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
        public NSXTHostTransportNodeCollectionType GetHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            NSXTHostTransportNodeCollectionType returnValue = default(NSXTHostTransportNodeCollectionType);
            StringBuilder GetHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            GetHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTHostTransportNodeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTHostTransportNodeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            
            StringBuilder DeleteHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteHostTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchHostTransportNodeCollection(string SiteId, string EnforcementpointId, string TransportNodeCollectionId, NSXTHostTransportNodeCollectionType HostTransportNodeCollection)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementpointId == null) { throw new System.ArgumentNullException("EnforcementpointId cannot be null"); }
            if (TransportNodeCollectionId == null) { throw new System.ArgumentNullException("TransportNodeCollectionId cannot be null"); }
            if (HostTransportNodeCollection == null) { throw new System.ArgumentNullException("HostTransportNodeCollection cannot be null"); }
            
            StringBuilder PatchHostTransportNodeCollectionServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcementpoint-id}/transport-node-collections/{transport-node-collection-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchHostTransportNodeCollectionServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeCollectionServiceURL.Replace("{enforcementpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementpointId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchHostTransportNodeCollectionServiceURL.Replace("{transport-node-collection-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeCollectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(HostTransportNodeCollection, defaultSerializationSettings));
            request.Resource = PatchHostTransportNodeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchHostTransportNodeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
