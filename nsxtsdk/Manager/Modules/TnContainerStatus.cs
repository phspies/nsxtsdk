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
    public class TnContainerStatus
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public TnContainerStatus(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTContainerClusterSummaryType ReadContainerClusterStatus(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            NSXTContainerClusterSummaryType returnValue = default(NSXTContainerClusterSummaryType);
            StringBuilder ReadContainerClusterStatusServiceURL = new StringBuilder("/systemhealth/container-cluster/{cluster-id}/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadContainerClusterStatusServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadContainerClusterStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTContainerClusterSummaryType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteContainerClusterSummary(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            
            StringBuilder DeleteContainerClusterSummaryServiceURL = new StringBuilder("/systemhealth/container-cluster/{cluster-id}/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteContainerClusterSummaryServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteContainerClusterSummaryServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTnHyperbusStatusType ReadTnHyperbusStatus(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTTnHyperbusStatusType returnValue = default(NSXTTnHyperbusStatusType);
            StringBuilder ReadTnHyperbusStatusServiceURL = new StringBuilder("/systemhealth/transport-nodes/{node-id}/container/hyperbus/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadTnHyperbusStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTnHyperbusStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTTnHyperbusStatusType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTTnNodeAgentStatusListResultType ReadTnContainerAgentStatus(string NodeId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTTnNodeAgentStatusListResultType returnValue = default(NSXTTnNodeAgentStatusListResultType);
            StringBuilder ReadTnContainerAgentStatusServiceURL = new StringBuilder("/systemhealth/transport-nodes/{node-id}/container/agent/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadTnContainerAgentStatusServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadTnContainerAgentStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTTnNodeAgentStatusListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTContainerClusterStatusType CreateContainerClusterStatus(NSXTContainerClusterStatusType ContainerClusterStatus)
        {
            if (ContainerClusterStatus == null) { throw new System.ArgumentNullException("ContainerClusterStatus cannot be null"); }
            NSXTContainerClusterStatusType returnValue = default(NSXTContainerClusterStatusType);
            StringBuilder CreateContainerClusterStatusServiceURL = new StringBuilder("/systemhealth/container-cluster/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(ContainerClusterStatus, defaultSerializationSettings));
            request.Resource = CreateContainerClusterStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTContainerClusterStatusType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTContainerClusterStatusListType ReadContainerClusterStatusList(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTContainerClusterStatusListType returnValue = default(NSXTContainerClusterStatusListType);
            StringBuilder ReadContainerClusterStatusListServiceURL = new StringBuilder("/systemhealth/container-cluster/ncp/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ReadContainerClusterStatusListServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTContainerClusterStatusListType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
