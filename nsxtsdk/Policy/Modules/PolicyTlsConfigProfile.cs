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
    public class PolicyTlsConfigProfile
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyTlsConfigProfile(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileListResultType GlobalGlobalInfraListPolicyTlsConfigProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyTlsConfigProfileListResultType returnValue = default(NSXTPolicyTlsConfigProfileListResultType);
            StringBuilder GlobalInfraListPolicyTlsConfigProfilesServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles");
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
            request.Resource = GlobalInfraListPolicyTlsConfigProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListPolicyTlsConfigProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileType UpdatePolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            NSXTPolicyTlsConfigProfileType returnValue = default(NSXTPolicyTlsConfigProfileType);
            StringBuilder UpdatePolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTlsConfigProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = UpdatePolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdatePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileType GetPolicyTlsConfigProfile(string TlsInspectionConfigProfile)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            NSXTPolicyTlsConfigProfileType returnValue = default(NSXTPolicyTlsConfigProfileType);
            StringBuilder GetPolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            
            StringBuilder PatchPolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTlsConfigProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchPolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyTlsConfigProfile(string TlsInspectionConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            
            StringBuilder DeletePolicyTlsConfigProfileServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileListResultType ListPolicyTlsConfigProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyTlsConfigProfileListResultType returnValue = default(NSXTPolicyTlsConfigProfileListResultType);
            StringBuilder ListPolicyTlsConfigProfilesServiceURL = new StringBuilder("/infra/security/tls-inspection-config-profiles");
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
            request.Resource = ListPolicyTlsConfigProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyTlsConfigProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileType GlobalGlobalInfraUpdatePolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            NSXTPolicyTlsConfigProfileType returnValue = default(NSXTPolicyTlsConfigProfileType);
            StringBuilder GlobalInfraUpdatePolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTlsConfigProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + GlobalInfraUpdatePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTlsConfigProfileType GlobalGlobalInfraGetPolicyTlsConfigProfile(string TlsInspectionConfigProfile)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            NSXTPolicyTlsConfigProfileType returnValue = default(NSXTPolicyTlsConfigProfileType);
            StringBuilder GlobalInfraGetPolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraGetPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraGetPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTlsConfigProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTlsConfigProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalGlobalInfraPatchPolicyTlsConfigProfile(string TlsInspectionConfigProfile, NSXTPolicyTlsConfigProfileType PolicyTlsConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            if (PolicyTlsConfigProfile == null) { throw new System.ArgumentNullException("PolicyTlsConfigProfile cannot be null"); }
            
            StringBuilder GlobalInfraPatchPolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraPatchPolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTlsConfigProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchPolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + GlobalInfraPatchPolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalGlobalInfraDeletePolicyTlsConfigProfile(string TlsInspectionConfigProfile, bool? Override = null)
        {
            if (TlsInspectionConfigProfile == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfile cannot be null"); }
            
            StringBuilder GlobalInfraDeletePolicyTlsConfigProfileServiceURL = new StringBuilder("/global-infra/security/tls-inspection-config-profiles/{tls-inspection-config-profile}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraDeletePolicyTlsConfigProfileServiceURL.Replace("{tls-inspection-config-profile}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfile, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeletePolicyTlsConfigProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + GlobalInfraDeletePolicyTlsConfigProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
