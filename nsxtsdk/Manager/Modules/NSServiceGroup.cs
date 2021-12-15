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
    public class NSServiceGroup
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NSServiceGroup(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNSServiceGroupType CreateNsserviceGroup(NSXTNSServiceGroupType NsserviceGroup)
        {
            if (NsserviceGroup == null) { throw new System.ArgumentNullException("NsserviceGroup cannot be null"); }
            NSXTNSServiceGroupType returnValue = default(NSXTNSServiceGroupType);
            StringBuilder CreateNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NsserviceGroup, defaultSerializationSettings));
            request.Resource = CreateNsserviceGroupServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNSServiceGroupType>(response.Content, defaultSerializationSettings);
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
        public NSXTNSServiceGroupListResultType ListNsserviceGroups(string? Cursor = null, bool? DefaultService = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTNSServiceGroupListResultType returnValue = default(NSXTNSServiceGroupListResultType);
            StringBuilder ListNsserviceGroupsServiceURL = new StringBuilder("/ns-service-groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DefaultService != null) { request.AddQueryParameter("default_service", DefaultService.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNsserviceGroupsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNSServiceGroupListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTNSServiceGroupType UpdateNsserviceGroup(string NsServiceGroupId, NSXTNSServiceGroupType NsserviceGroup)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            if (NsserviceGroup == null) { throw new System.ArgumentNullException("NsserviceGroup cannot be null"); }
            NSXTNSServiceGroupType returnValue = default(NSXTNSServiceGroupType);
            StringBuilder UpdateNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(NsserviceGroup, defaultSerializationSettings));
            request.Resource = UpdateNsserviceGroupServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNSServiceGroupType>(response.Content, defaultSerializationSettings);
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
        public void DeleteNsserviceGroup(string NsServiceGroupId, bool? Force = null)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            
            StringBuilder DeleteNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteNsserviceGroupServiceURL.ToString();
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
        public NSXTNSServiceGroupType ReadNsserviceGroup(string NsServiceGroupId)
        {
            if (NsServiceGroupId == null) { throw new System.ArgumentNullException("NsServiceGroupId cannot be null"); }
            NSXTNSServiceGroupType returnValue = default(NSXTNSServiceGroupType);
            StringBuilder ReadNsserviceGroupServiceURL = new StringBuilder("/ns-service-groups/{ns-service-group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadNsserviceGroupServiceURL.Replace("{ns-service-group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NsServiceGroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNsserviceGroupServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNSServiceGroupType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}