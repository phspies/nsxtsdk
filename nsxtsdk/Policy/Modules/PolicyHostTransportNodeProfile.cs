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
    public class PolicyHostTransportNodeProfile
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyHostTransportNodeProfile(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyHostTransportNodeProfileListResultType ListPolicyHostTransportNodeProfiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyHostTransportNodeProfileListResultType returnValue = default(NSXTPolicyHostTransportNodeProfileListResultType);
            StringBuilder ListPolicyHostTransportNodeProfilesServiceURL = new StringBuilder("/infra/host-transport-node-profiles");
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
            request.Resource = ListPolicyHostTransportNodeProfilesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyHostTransportNodeProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyHostTransportNodeProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyHostTransportNodeProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyHostTransportNodeProfileType CreateOrUpdatePolicyHostTransportNodeProfile(string TransportNodeProfileId, NSXTPolicyHostTransportNodeProfileType PolicyHostTransportNodeProfile)
        {
            if (TransportNodeProfileId == null) { throw new System.ArgumentNullException("TransportNodeProfileId cannot be null"); }
            if (PolicyHostTransportNodeProfile == null) { throw new System.ArgumentNullException("PolicyHostTransportNodeProfile cannot be null"); }
            NSXTPolicyHostTransportNodeProfileType returnValue = default(NSXTPolicyHostTransportNodeProfileType);
            StringBuilder CreateOrUpdatePolicyHostTransportNodeProfileServiceURL = new StringBuilder("/infra/host-transport-node-profiles/{transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdatePolicyHostTransportNodeProfileServiceURL.Replace("{transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyHostTransportNodeProfile, defaultSerializationSettings));
            request.Resource = CreateOrUpdatePolicyHostTransportNodeProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdatePolicyHostTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyHostTransportNodeProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyHostTransportNodeProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyHostTransportNodeProfile(string TransportNodeProfileId)
        {
            if (TransportNodeProfileId == null) { throw new System.ArgumentNullException("TransportNodeProfileId cannot be null"); }
            
            StringBuilder DeletePolicyHostTransportNodeProfileServiceURL = new StringBuilder("/infra/host-transport-node-profiles/{transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyHostTransportNodeProfileServiceURL.Replace("{transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyHostTransportNodeProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyHostTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyHostTransportNodeProfileType GetPolicyHostTransportNodeProfile(string HostTransportNodeProfileId)
        {
            if (HostTransportNodeProfileId == null) { throw new System.ArgumentNullException("HostTransportNodeProfileId cannot be null"); }
            NSXTPolicyHostTransportNodeProfileType returnValue = default(NSXTPolicyHostTransportNodeProfileType);
            StringBuilder GetPolicyHostTransportNodeProfileServiceURL = new StringBuilder("/infra/host-transport-node-profiles/{host-transport-node-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyHostTransportNodeProfileServiceURL.Replace("{host-transport-node-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(HostTransportNodeProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyHostTransportNodeProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetPolicyHostTransportNodeProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyHostTransportNodeProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyHostTransportNodeProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
