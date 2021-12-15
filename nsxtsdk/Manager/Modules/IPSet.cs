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
    public class IPSet
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public IPSet(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIPAddressElementListResultType GetIpaddresses(string IpSetId)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            NSXTIPAddressElementListResultType returnValue = default(NSXTIPAddressElementListResultType);
            StringBuilder GetIpaddressesServiceURL = new StringBuilder("/ip-sets/{ip-set-id}/members");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpaddressesServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpaddressesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPAddressElementListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTIPSetType CreateIpset(NSXTIPSetType Ipset)
        {
            if (Ipset == null) { throw new System.ArgumentNullException("Ipset cannot be null"); }
            NSXTIPSetType returnValue = default(NSXTIPSetType);
            StringBuilder CreateIpsetServiceURL = new StringBuilder("/ip-sets");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(Ipset, defaultSerializationSettings));
            request.Resource = CreateIpsetServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPSetType>(response.Content, defaultSerializationSettings);
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
        public NSXTIPSetListResultType ListIpsets(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPSetListResultType returnValue = default(NSXTIPSetListResultType);
            StringBuilder ListIpsetsServiceURL = new StringBuilder("/ip-sets");
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
            request.Resource = ListIpsetsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPSetListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTIPSetType UpdateIpset(string IpSetId, NSXTIPSetType Ipset)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            if (Ipset == null) { throw new System.ArgumentNullException("Ipset cannot be null"); }
            NSXTIPSetType returnValue = default(NSXTIPSetType);
            StringBuilder UpdateIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Ipset, defaultSerializationSettings));
            request.Resource = UpdateIpsetServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPSetType>(response.Content, defaultSerializationSettings);
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
        public NSXTIPAddressElementType AddRemoveIpaddress(string IpSetId, NSXTIPAddressElementType IpaddressElement, string Action)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            if (IpaddressElement == null) { throw new System.ArgumentNullException("IpaddressElement cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            NSXTIPAddressElementType returnValue = default(NSXTIPAddressElementType);
            StringBuilder AddRemoveIpaddressServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            AddRemoveIpaddressServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpaddressElement, defaultSerializationSettings));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = AddRemoveIpaddressServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPAddressElementType>(response.Content, defaultSerializationSettings);
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
        public void DeleteIpset(string IpSetId, bool? Force = null)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            
            StringBuilder DeleteIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteIpsetServiceURL.ToString();
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
        public NSXTIPSetType ReadIpset(string IpSetId)
        {
            if (IpSetId == null) { throw new System.ArgumentNullException("IpSetId cannot be null"); }
            NSXTIPSetType returnValue = default(NSXTIPSetType);
            StringBuilder ReadIpsetServiceURL = new StringBuilder("/ip-sets/{ip-set-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadIpsetServiceURL.Replace("{ip-set-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpSetId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpsetServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIPSetType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
