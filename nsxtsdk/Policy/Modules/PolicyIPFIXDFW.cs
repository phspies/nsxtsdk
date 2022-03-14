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
    public class PolicyIPFIXDFW
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyIPFIXDFW(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> GlobalGlobalInfraCreateOrReplaceIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            NSXTIPFIXDFWCollectorProfileType returnValue = default(NSXTIPFIXDFWCollectorProfileType);
            StringBuilder GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixdfwcollectorProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + GlobalInfraCreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            
            StringBuilder GlobalInfraPatchIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixdfwcollectorProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + GlobalInfraPatchIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> GlobalGlobalInfraReadIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            NSXTIPFIXDFWCollectorProfileType returnValue = default(NSXTIPFIXDFWCollectorProfileType);
            StringBuilder GlobalInfraReadIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraReadIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraReadIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            
            StringBuilder GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + GlobalInfraDeleteIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> CreateOrReplaceIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            NSXTIPFIXDFWProfileType returnValue = default(NSXTIPFIXDFWProfileType);
            StringBuilder CreateOrReplaceIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplaceIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Ipfixdfwprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpfixdfwprofileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplaceIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixdfwprofile(string IpfixDfwProfileId, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            
            StringBuilder DeleteIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpfixdfwprofileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            
            StringBuilder PatchIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Ipfixdfwprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpfixdfwprofileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> ReadIpfixdfwprofile(string IpfixDfwProfileId)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            NSXTIPFIXDFWProfileType returnValue = default(NSXTIPFIXDFWProfileType);
            StringBuilder ReadIpfixdfwprofileServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpfixdfwprofileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileListResultType> ListIpfixdfwprofiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPFIXDFWProfileListResultType returnValue = default(NSXTIPFIXDFWProfileListResultType);
            StringBuilder ListIpfixdfwprofilesServiceURL = new StringBuilder("/infra/ipfix-dfw-profiles");
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
            request.Resource = ListIpfixdfwprofilesServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListIpfixdfwprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileListResultType> ListIpfixdfwcollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPFIXDFWCollectorProfileListResultType returnValue = default(NSXTIPFIXDFWCollectorProfileListResultType);
            StringBuilder ListIpfixdfwcollectorProfilesServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles");
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
            request.Resource = ListIpfixdfwcollectorProfilesServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListIpfixdfwcollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> CreateOrReplaceIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            NSXTIPFIXDFWCollectorProfileType returnValue = default(NSXTIPFIXDFWCollectorProfileType);
            StringBuilder CreateOrReplaceIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplaceIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixdfwcollectorProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplaceIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, NSXTIPFIXDFWCollectorProfileType IpfixdfwcollectorProfile, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            if (IpfixdfwcollectorProfile == null) { throw new System.ArgumentNullException("IpfixdfwcollectorProfile cannot be null"); }
            
            StringBuilder PatchIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixdfwcollectorProfile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileType> ReadIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            NSXTIPFIXDFWCollectorProfileType returnValue = default(NSXTIPFIXDFWCollectorProfileType);
            StringBuilder ReadIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIpfixdfwcollectorProfile(string IpfixDfwCollectorProfileId, bool? Override = null)
        {
            if (IpfixDfwCollectorProfileId == null) { throw new System.ArgumentNullException("IpfixDfwCollectorProfileId cannot be null"); }
            
            StringBuilder DeleteIpfixdfwcollectorProfileServiceURL = new StringBuilder("/infra/ipfix-dfw-collector-profiles/{ipfix-dfw-collector-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpfixdfwcollectorProfileServiceURL.Replace("{ipfix-dfw-collector-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwCollectorProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteIpfixdfwcollectorProfileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIpfixdfwcollectorProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileListResultType> GlobalGlobalInfraListIpfixdfwprofiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPFIXDFWProfileListResultType returnValue = default(NSXTIPFIXDFWProfileListResultType);
            StringBuilder GlobalInfraListIpfixdfwprofilesServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles");
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
            request.Resource = GlobalInfraListIpfixdfwprofilesServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListIpfixdfwprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> GlobalGlobalInfraCreateOrReplaceIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            NSXTIPFIXDFWProfileType returnValue = default(NSXTIPFIXDFWProfileType);
            StringBuilder GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Ipfixdfwprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + GlobalInfraCreateOrReplaceIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteIpfixdfwprofile(string IpfixDfwProfileId, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            
            StringBuilder GlobalInfraDeleteIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraDeleteIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteIpfixdfwprofileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + GlobalInfraDeleteIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchIpfixdfwprofile(string IpfixDfwProfileId, NSXTIPFIXDFWProfileType Ipfixdfwprofile, bool? Override = null)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            if (Ipfixdfwprofile == null) { throw new System.ArgumentNullException("Ipfixdfwprofile cannot be null"); }
            
            StringBuilder GlobalInfraPatchIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraPatchIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Ipfixdfwprofile, defaultSerializationSettings));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchIpfixdfwprofileServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + GlobalInfraPatchIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWProfileType> GlobalGlobalInfraReadIpfixdfwprofile(string IpfixDfwProfileId)
        {
            if (IpfixDfwProfileId == null) { throw new System.ArgumentNullException("IpfixDfwProfileId cannot be null"); }
            NSXTIPFIXDFWProfileType returnValue = default(NSXTIPFIXDFWProfileType);
            StringBuilder GlobalInfraReadIpfixdfwprofileServiceURL = new StringBuilder("/global-infra/ipfix-dfw-profiles/{ipfix-dfw-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GlobalInfraReadIpfixdfwprofileServiceURL.Replace("{ipfix-dfw-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IpfixDfwProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadIpfixdfwprofileServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraReadIpfixdfwprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPFIXDFWCollectorProfileListResultType> GlobalGlobalInfraListIpfixdfwcollectorProfiles(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIPFIXDFWCollectorProfileListResultType returnValue = default(NSXTIPFIXDFWCollectorProfileListResultType);
            StringBuilder GlobalInfraListIpfixdfwcollectorProfilesServiceURL = new StringBuilder("/global-infra/ipfix-dfw-collector-profiles");
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
            request.Resource = GlobalInfraListIpfixdfwcollectorProfilesServiceURL.ToString();
            IRestResponse<NSXTIPFIXDFWCollectorProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPFIXDFWCollectorProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GlobalInfraListIpfixdfwcollectorProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
