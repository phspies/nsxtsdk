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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyMulticast(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIgmpProfileListResultType> ListPolicyIgmpProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyIgmpProfileServiceURL.ToString();
            RestResponse<NSXTPolicyIgmpProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIgmpProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyPimProfileListResultType> ListPolicyPimProfile(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyPimProfileServiceURL.ToString();
            RestResponse<NSXTPolicyPimProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyPimProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTier1MulticastConfigType> CreateOrUpdatePolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId, NSXTPolicyTier1MulticastConfigType PolicyTier1MulticastConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyTier1MulticastConfig == null) { throw new System.ArgumentNullException("PolicyTier1MulticastConfig cannot be null"); }
            StringBuilder CreateOrUpdatePolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTier1MulticastConfig);
            request.Resource = CreateOrUpdatePolicyTier1MulticastConfigServiceURL.ToString();
            RestResponse<NSXTPolicyTier1MulticastConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTier1MulticastConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyTier1MulticastConfigType> ReadPolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ReadPolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyTier1MulticastConfigServiceURL.ToString();
            RestResponse<NSXTPolicyTier1MulticastConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyTier1MulticastConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyTier1MulticastConfig(string Tier1Id, string LocaleServicesId, NSXTPolicyTier1MulticastConfigType PolicyTier1MulticastConfig)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyTier1MulticastConfig == null) { throw new System.ArgumentNullException("PolicyTier1MulticastConfig cannot be null"); }
            StringBuilder PatchPolicyTier1MulticastConfigServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyTier1MulticastConfigServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyTier1MulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyTier1MulticastConfig);
            request.Resource = PatchPolicyTier1MulticastConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyTier1MulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIgmpProfileType> CreateOrUpdatePolicyIgmpProfile(string IgmpProfileId, NSXTPolicyIgmpProfileType PolicyIgmpProfile)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            if (PolicyIgmpProfile == null) { throw new System.ArgumentNullException("PolicyIgmpProfile cannot be null"); }
            StringBuilder CreateOrUpdatePolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyIgmpProfile);
            request.Resource = CreateOrUpdatePolicyIgmpProfileServiceURL.ToString();
            RestResponse<NSXTPolicyIgmpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIgmpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyIgmpProfile(string IgmpProfileId, NSXTPolicyIgmpProfileType PolicyIgmpProfile)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            if (PolicyIgmpProfile == null) { throw new System.ArgumentNullException("PolicyIgmpProfile cannot be null"); }
            StringBuilder PatchPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyIgmpProfile);
            request.Resource = PatchPolicyIgmpProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIgmpProfileType> ReadPolicyIgmpProfile(string IgmpProfileId)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            StringBuilder ReadPolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyIgmpProfileServiceURL.ToString();
            RestResponse<NSXTPolicyIgmpProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIgmpProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyIgmpProfile(string IgmpProfileId)
        {
            if (IgmpProfileId == null) { throw new System.ArgumentNullException("IgmpProfileId cannot be null"); }
            StringBuilder DeletePolicyIgmpProfileServiceURL = new StringBuilder("/infra/igmp-profiles/{igmp-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyIgmpProfileServiceURL.Replace("{igmp-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IgmpProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyIgmpProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyIgmpProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyPimProfileType> CreateOrUpdatePolicyPimProfile(string PimProfileId, NSXTPolicyPimProfileType PolicyPimProfile)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            if (PolicyPimProfile == null) { throw new System.ArgumentNullException("PolicyPimProfile cannot be null"); }
            StringBuilder CreateOrUpdatePolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyPimProfile);
            request.Resource = CreateOrUpdatePolicyPimProfileServiceURL.ToString();
            RestResponse<NSXTPolicyPimProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyPimProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyPimProfileType> ReadPolicyPimProfile(string PimProfileId)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            StringBuilder ReadPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyPimProfileServiceURL.ToString();
            RestResponse<NSXTPolicyPimProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyPimProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyPimProfile(string PimProfileId)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            StringBuilder DeletePolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyPimProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyPimProfile(string PimProfileId, NSXTPolicyPimProfileType PolicyPimProfile)
        {
            if (PimProfileId == null) { throw new System.ArgumentNullException("PimProfileId cannot be null"); }
            if (PolicyPimProfile == null) { throw new System.ArgumentNullException("PolicyPimProfile cannot be null"); }
            StringBuilder PatchPolicyPimProfileServiceURL = new StringBuilder("/infra/pim-profiles/{pim-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyPimProfileServiceURL.Replace("{pim-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PimProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyPimProfile);
            request.Resource = PatchPolicyPimProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyPimProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastConfigType> CreateOrUpdatePolicyMulticastConfig(string Tier0Id, string LocaleServicesId, NSXTPolicyMulticastConfigType PolicyMulticastConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyMulticastConfig == null) { throw new System.ArgumentNullException("PolicyMulticastConfig cannot be null"); }
            StringBuilder CreateOrUpdatePolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdatePolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyMulticastConfig);
            request.Resource = CreateOrUpdatePolicyMulticastConfigServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyMulticastConfig(string Tier0Id, string LocaleServicesId, NSXTPolicyMulticastConfigType PolicyMulticastConfig)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (PolicyMulticastConfig == null) { throw new System.ArgumentNullException("PolicyMulticastConfig cannot be null"); }
            StringBuilder PatchPolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyMulticastConfig);
            request.Resource = PatchPolicyMulticastConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyMulticastConfigType> ReadPolicyMulticastConfig(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ReadPolicyMulticastConfigServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/multicast");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPolicyMulticastConfigServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadPolicyMulticastConfigServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPolicyMulticastConfigServiceURL.ToString();
            RestResponse<NSXTPolicyMulticastConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyMulticastConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPolicyMulticastConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
