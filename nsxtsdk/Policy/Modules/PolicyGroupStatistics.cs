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
    public class PolicyGroupStatistics
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyGroupStatistics(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRealizedVirtualMachineListResultType GetGroupVmstatistics(string DomainId, string GroupId, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTRealizedVirtualMachineListResultType returnValue = default(NSXTRealizedVirtualMachineListResultType);
            StringBuilder GetGroupVmstatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/statistics/virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetGroupVmstatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupVmstatisticsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetGroupVmstatisticsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetGroupVmstatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTRealizedVirtualMachineListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTRealizedVirtualMachineListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTRealizedVirtualMachineListResultType GlobalGetGroupVmstatistics(string DomainId, string GroupId, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTRealizedVirtualMachineListResultType returnValue = default(NSXTRealizedVirtualMachineListResultType);
            StringBuilder GetGroupVmstatisticsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/statistics/virtual-machines");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetGroupVmstatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGroupVmstatisticsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetGroupVmstatisticsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetGroupVmstatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTRealizedVirtualMachineListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTRealizedVirtualMachineListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
