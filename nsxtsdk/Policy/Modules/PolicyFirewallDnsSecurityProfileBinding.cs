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
    public class PolicyFirewallDnsSecurityProfileBinding
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyFirewallDnsSecurityProfileBinding(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapType GlobalUpdateDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            NSXTDnsSecurityProfileBindingMapType returnValue = default(NSXTDnsSecurityProfileBindingMapType);
            StringBuilder UpdateDnsSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(DnsSecurityProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdateDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapType GlobalGetDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            NSXTDnsSecurityProfileBindingMapType returnValue = default(NSXTDnsSecurityProfileBindingMapType);
            StringBuilder GetDnsSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalDeleteDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            
            StringBuilder DeleteDnsSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalPatchDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            
            StringBuilder PatchDnsSecurityProfileBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(DnsSecurityProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapListResultType GlobalListDnsSecurityProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTDnsSecurityProfileBindingMapListResultType returnValue = default(NSXTDnsSecurityProfileBindingMapListResultType);
            StringBuilder ListDnsSecurityProfileBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListDnsSecurityProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListDnsSecurityProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDnsSecurityProfileBindingsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListDnsSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapListResultType ListDnsSecurityProfileBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTDnsSecurityProfileBindingMapListResultType returnValue = default(NSXTDnsSecurityProfileBindingMapListResultType);
            StringBuilder ListDnsSecurityProfileBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListDnsSecurityProfileBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListDnsSecurityProfileBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDnsSecurityProfileBindingsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListDnsSecurityProfileBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapType UpdateDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            NSXTDnsSecurityProfileBindingMapType returnValue = default(NSXTDnsSecurityProfileBindingMapType);
            StringBuilder UpdateDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(DnsSecurityProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdateDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTDnsSecurityProfileBindingMapType GetDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            NSXTDnsSecurityProfileBindingMapType returnValue = default(NSXTDnsSecurityProfileBindingMapType);
            StringBuilder GetDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTDnsSecurityProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTDnsSecurityProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            
            StringBuilder DeleteDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchDnsSecurityProfileBinding(string DomainId, string GroupId, string DnsSecurityProfileBindingMapId, NSXTDnsSecurityProfileBindingMapType DnsSecurityProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (DnsSecurityProfileBindingMapId == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMapId cannot be null"); }
            if (DnsSecurityProfileBindingMap == null) { throw new System.ArgumentNullException("DnsSecurityProfileBindingMap cannot be null"); }
            
            StringBuilder PatchDnsSecurityProfileBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/dns-security-profile-binding-maps/{dns-security-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchDnsSecurityProfileBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchDnsSecurityProfileBindingServiceURL.Replace("{dns-security-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DnsSecurityProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(DnsSecurityProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchDnsSecurityProfileBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchDnsSecurityProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
