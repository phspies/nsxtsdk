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
    public class ProtonCapacityDashboard
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ProtonCapacityDashboard(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTCapacityThresholdListType UpdateProtonCapacityThresholds(NSXTCapacityThresholdListType CapacityThresholdList)
        {
            if (CapacityThresholdList == null) { throw new System.ArgumentNullException("CapacityThresholdList cannot be null"); }
            NSXTCapacityThresholdListType returnValue = default(NSXTCapacityThresholdListType);
            StringBuilder UpdateProtonCapacityThresholdsServiceURL = new StringBuilder("/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(CapacityThresholdList, defaultSerializationSettings));
            request.Resource = UpdateProtonCapacityThresholdsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTCapacityThresholdListType>(response.Content, defaultSerializationSettings);
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
        public NSXTCapacityThresholdListType GetProtonCapacityThresholds()
        {
            NSXTCapacityThresholdListType returnValue = default(NSXTCapacityThresholdListType);
            StringBuilder GetProtonCapacityThresholdsServiceURL = new StringBuilder("/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetProtonCapacityThresholdsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTCapacityThresholdListType>(response.Content, defaultSerializationSettings);
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
        public NSXTCapacityUsageResponseType GetProtonCapacityUsage(string? Category = null, string? Cursor = null, bool? Force = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTCapacityUsageResponseType returnValue = default(NSXTCapacityUsageResponseType);
            StringBuilder GetProtonCapacityUsageServiceURL = new StringBuilder("/capacity/usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetProtonCapacityUsageServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTCapacityUsageResponseType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
