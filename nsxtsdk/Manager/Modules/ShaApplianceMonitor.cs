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
    public class ShaApplianceMonitor
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ShaApplianceMonitor(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTApplianceLatencyListResultType ShowAllApplianceLatencyData(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTApplianceLatencyListResultType returnValue = default(NSXTApplianceLatencyListResultType);
            StringBuilder ShowAllApplianceLatencyDataServiceURL = new StringBuilder("/systemhealth/appliances/latency/status");
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
            request.Resource = ShowAllApplianceLatencyDataServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceLatencyListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTApplianceLatencyDataType ShowApplianceLatencyData(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            NSXTApplianceLatencyDataType returnValue = default(NSXTApplianceLatencyDataType);
            StringBuilder ShowApplianceLatencyDataServiceURL = new StringBuilder("/systemhealth/appliances/{appliance-id}/latency/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ShowApplianceLatencyDataServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowApplianceLatencyDataServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceLatencyDataType>(response.Content, defaultSerializationSettings);
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
        public NSXTApplianceProcessListResultType ShowAllapplianceProcessData(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTApplianceProcessListResultType returnValue = default(NSXTApplianceProcessListResultType);
            StringBuilder ShowAllapplianceProcessDataServiceURL = new StringBuilder("/systemhealth/appliances/process/status");
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
            request.Resource = ShowAllapplianceProcessDataServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceProcessListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTApplianceProcessDataType ShowApplianceProcessData(string ApplianceId)
        {
            if (ApplianceId == null) { throw new System.ArgumentNullException("ApplianceId cannot be null"); }
            NSXTApplianceProcessDataType returnValue = default(NSXTApplianceProcessDataType);
            StringBuilder ShowApplianceProcessDataServiceURL = new StringBuilder("/systemhealth/appliances/{appliance-id}/process/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ShowApplianceProcessDataServiceURL.Replace("{appliance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ApplianceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowApplianceProcessDataServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTApplianceProcessDataType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
