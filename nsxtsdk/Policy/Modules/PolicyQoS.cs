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
    public class PolicyQoS
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyQoS(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileType CreateOrReplaceQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            NSXTQoSProfileType returnValue = default(NSXTQoSProfileType);
            StringBuilder CreateOrReplaceQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplaceQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(QoSprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplaceQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteQoSprofile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            
            StringBuilder DeleteQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileType ReadQoSprofile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            NSXTQoSProfileType returnValue = default(NSXTQoSProfileType);
            StringBuilder ReadQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            
            StringBuilder PatchQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(QoSprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileListResultType ListQoSprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTQoSProfileListResultType returnValue = default(NSXTQoSProfileListResultType);
            StringBuilder ListQoSprofilesServiceURL = new StringBuilder("/infra/qos-profiles");
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
            request.Resource = ListQoSprofilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListQoSprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileType GlobalGlobalInfraCreateOrReplaceQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            NSXTQoSProfileType returnValue = default(NSXTQoSProfileType);
            StringBuilder GlobalInfraCreateOrReplaceQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraCreateOrReplaceQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(QoSprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + GlobalInfraCreateOrReplaceQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalGlobalInfraDeleteQoSprofile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            
            StringBuilder GlobalInfraDeleteQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraDeleteQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + GlobalInfraDeleteQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileType GlobalGlobalInfraReadQoSprofile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            NSXTQoSProfileType returnValue = default(NSXTQoSProfileType);
            StringBuilder GlobalInfraReadQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraReadQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraReadQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalGlobalInfraPatchQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            
            StringBuilder GlobalInfraPatchQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraPatchQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(QoSprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchQoSprofileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + GlobalInfraPatchQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTQoSProfileListResultType GlobalGlobalInfraListQoSprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTQoSProfileListResultType returnValue = default(NSXTQoSProfileListResultType);
            StringBuilder GlobalInfraListQoSprofilesServiceURL = new StringBuilder("/global-infra/qos-profiles");
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
            request.Resource = GlobalInfraListQoSprofilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListQoSprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTQoSProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTQoSProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
