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
    public class PolicyFirewallSessionTimerProfileBinding
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyFirewallSessionTimerProfileBinding(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType GlobalListPolicyFirewallSessionTimerBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType);
            StringBuilder ListPolicyFirewallSessionTimerBindingsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallSessionTimerBindingsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyFirewallSessionTimerBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType ListPolicyFirewallSessionTimerBindings(string DomainId, string GroupId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType);
            StringBuilder ListPolicyFirewallSessionTimerBindingsServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyFirewallSessionTimerBindingsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallSessionTimerBindingsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyFirewallSessionTimerBindingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType ListFirewallSessionTimerBindingsAcrossDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType);
            StringBuilder ListFirewallSessionTimerBindingsAcrossDomainsServiceURL = new StringBuilder("/infra/domains/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapType GlobalUpdatePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapType);
            StringBuilder UpdatePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallSessionTimerProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalPatchPolicyFirewallSessionTimerProfileBindingMap(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            
            StringBuilder PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallSessionTimerProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalDeletePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            
            StringBuilder DeletePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapType GlobalGetPolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapType);
            StringBuilder GetPolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapType UpdatePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapType);
            StringBuilder UpdatePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdatePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallSessionTimerProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdatePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyFirewallSessionTimerProfileBindingMap(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId, NSXTPolicyFirewallSessionTimerProfileBindingMapType PolicyFirewallSessionTimerProfileBindingMap)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            if (PolicyFirewallSessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallSessionTimerProfileBindingMap cannot be null"); }
            
            StringBuilder PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallSessionTimerProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyFirewallSessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            
            StringBuilder DeletePolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapType GetPolicyFirewallSessionTimerBinding(string DomainId, string GroupId, string FirewallSessionTimerProfileBindingMapId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (FirewallSessionTimerProfileBindingMapId == null) { throw new System.ArgumentNullException("FirewallSessionTimerProfileBindingMapId cannot be null"); }
            NSXTPolicyFirewallSessionTimerProfileBindingMapType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapType);
            StringBuilder GetPolicyFirewallSessionTimerBindingServiceURL = new StringBuilder("/infra/domains/{domain-id}/groups/{group-id}/firewall-session-timer-profile-binding-maps/{firewall-session-timer-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyFirewallSessionTimerBindingServiceURL.Replace("{firewall-session-timer-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSessionTimerProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallSessionTimerBindingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyFirewallSessionTimerBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType GlobalListFirewallSessionTimerBindingsAcrossDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType);
            StringBuilder ListFirewallSessionTimerBindingsAcrossDomainsServiceURL = new StringBuilder("/global-infra/domains/firewall-session-timer-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListFirewallSessionTimerBindingsAcrossDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyFirewallSessionTimerProfileBindingMapListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
