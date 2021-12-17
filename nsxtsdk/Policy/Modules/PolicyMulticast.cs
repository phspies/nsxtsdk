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
    public class PolicyMulticast
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyMulticast(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyIgmpProfileListResultType ListPolicyIgmpProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyIgmpProfileListResultType returnValue = default(NSXTPolicyIgmpProfileListResultType);
            StringBuilder ListPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles");
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
            request.Resource = ListPolicyIgmpProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyIgmpProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyIgmpProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyPimProfileListResultType ListPolicyPimProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyPimProfileListResultType returnValue = default(NSXTPolicyPimProfileListResultType);
            StringBuilder ListPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles");
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
            request.Resource = ListPolicyPimProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyPimProfileListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyPimProfileListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTier1MulticastConfigType CreateOrUpdatePolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId, NSXTPolicyTier1MulticastConfigType PolicyTier1MulticastConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyTier1MulticastConfig == null) { throw new System.ArgumentNullException("PolicyTier1MulticastConfig cannot be null"); }
            NSXTPolicyTier1MulticastConfigType returnValue = default(NSXTPolicyTier1MulticastConfigType);
            StringBuilder CreateOrUpdatePolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdatePolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTier1MulticastConfig, defaultSerializationSettings));
            request.Resource = CreateOrUpdatePolicyTier1MulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdatePolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTier1MulticastConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTier1MulticastConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyTier1MulticastConfigType ReadPolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            NSXTPolicyTier1MulticastConfigType returnValue = default(NSXTPolicyTier1MulticastConfigType);
            StringBuilder ReadPolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyTier1MulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyTier1MulticastConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyTier1MulticastConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId, NSXTPolicyTier1MulticastConfigType PolicyTier1MulticastConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyTier1MulticastConfig == null) { throw new System.ArgumentNullException("PolicyTier1MulticastConfig cannot be null"); }
            
            StringBuilder PatchPolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyTier1MulticastConfig, defaultSerializationSettings));
            request.Resource = PatchPolicyTier1MulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyIgmpProfileType CreateOrUpdatePolicyIgmpProfile(string IgmpProfileId, NSXTPolicyIgmpProfileType PolicyIgmpProfile)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            if (PolicyIgmpProfile == null) { throw new System.ArgumentNullException("PolicyIgmpProfile cannot be null"); }
            NSXTPolicyIgmpProfileType returnValue = default(NSXTPolicyIgmpProfileType);
            StringBuilder CreateOrUpdatePolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdatePolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyIgmpProfile, defaultSerializationSettings));
            request.Resource = CreateOrUpdatePolicyIgmpProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdatePolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyIgmpProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyIgmpProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyIgmpProfile(string IgmpProfileId, NSXTPolicyIgmpProfileType PolicyIgmpProfile)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            if (PolicyIgmpProfile == null) { throw new System.ArgumentNullException("PolicyIgmpProfile cannot be null"); }
            
            StringBuilder PatchPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyIgmpProfile, defaultSerializationSettings));
            request.Resource = PatchPolicyIgmpProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyIgmpProfileType ReadPolicyIgmpProfile(string IgmpProfileId)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            NSXTPolicyIgmpProfileType returnValue = default(NSXTPolicyIgmpProfileType);
            StringBuilder ReadPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyIgmpProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyIgmpProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyIgmpProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyIgmpProfile(string IgmpProfileId)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            
            StringBuilder DeletePolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyIgmpProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyPimProfileType CreateOrUpdatePolicyPimProfile(string PimProfileId, NSXTPolicyPimProfileType PolicyPimProfile)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            if (PolicyPimProfile == null) { throw new System.ArgumentNullException("PolicyPimProfile cannot be null"); }
            NSXTPolicyPimProfileType returnValue = default(NSXTPolicyPimProfileType);
            StringBuilder CreateOrUpdatePolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdatePolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyPimProfile, defaultSerializationSettings));
            request.Resource = CreateOrUpdatePolicyPimProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdatePolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyPimProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyPimProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyPimProfileType ReadPolicyPimProfile(string PimProfileId)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            NSXTPolicyPimProfileType returnValue = default(NSXTPolicyPimProfileType);
            StringBuilder ReadPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyPimProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyPimProfileType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyPimProfileType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyPimProfile(string PimProfileId)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            
            StringBuilder DeletePolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyPimProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeletePolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyPimProfile(string PimProfileId, NSXTPolicyPimProfileType PolicyPimProfile)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            if (PolicyPimProfile == null) { throw new System.ArgumentNullException("PolicyPimProfile cannot be null"); }
            
            StringBuilder PatchPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyPimProfile, defaultSerializationSettings));
            request.Resource = PatchPolicyPimProfileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyMulticastConfigType CreateOrUpdatePolicyMulticastConfig(string Tier0Id, string LocaleServicesId, NSXTPolicyMulticastConfigType PolicyMulticastConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyMulticastConfig == null) { throw new System.ArgumentNullException("PolicyMulticastConfig cannot be null"); }
            NSXTPolicyMulticastConfigType returnValue = default(NSXTPolicyMulticastConfigType);
            StringBuilder CreateOrUpdatePolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrUpdatePolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyMulticastConfig, defaultSerializationSettings));
            request.Resource = CreateOrUpdatePolicyMulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrUpdatePolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyMulticastConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyMulticastConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyMulticastConfig(string Tier0Id, string LocaleServicesId, NSXTPolicyMulticastConfigType PolicyMulticastConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyMulticastConfig == null) { throw new System.ArgumentNullException("PolicyMulticastConfig cannot be null"); }
            
            StringBuilder PatchPolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyMulticastConfig, defaultSerializationSettings));
            request.Resource = PatchPolicyMulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchPolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyMulticastConfigType ReadPolicyMulticastConfig(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            NSXTPolicyMulticastConfigType returnValue = default(NSXTPolicyMulticastConfigType);
            StringBuilder ReadPolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadPolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyMulticastConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadPolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTPolicyMulticastConfigType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTPolicyMulticastConfigType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
