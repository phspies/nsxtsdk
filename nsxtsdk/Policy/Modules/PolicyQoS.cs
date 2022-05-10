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
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyQoS(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTQoSProfileType> CreateOrReplaceQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            StringBuilder CreateOrReplaceQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(QoSprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrReplaceQoSprofileServiceURL.ToString();
            RestResponse<NSXTQoSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteQoSprofile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder DeleteQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeleteQoSprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTQoSProfileType> ReadQoSprofile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder ReadQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadQoSprofileServiceURL.ToString();
            RestResponse<NSXTQoSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            StringBuilder PatchQoSprofileServiceURL = new StringBuilder("/infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(QoSprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchQoSprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTQoSProfileListResultType> ListQoSprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListQoSprofilesServiceURL = new StringBuilder("/infra/qos-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListQoSprofilesServiceURL.ToString();
            RestResponse<NSXTQoSProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListQoSprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTQoSProfileType> GlobalGlobalInfraCreateOrReplaceQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            StringBuilder GlobalInfraCreateOrReplaceQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            GlobalInfraCreateOrReplaceQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(QoSprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraCreateOrReplaceQoSprofileServiceURL.ToString();
            RestResponse<NSXTQoSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + GlobalInfraCreateOrReplaceQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraDeleteQoSprofile(string QosProfileId, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder GlobalInfraDeleteQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            GlobalInfraDeleteQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraDeleteQoSprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + GlobalInfraDeleteQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTQoSProfileType> GlobalGlobalInfraReadQoSprofile(string QosProfileId)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            StringBuilder GlobalInfraReadQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadQoSprofileServiceURL.ToString();
            RestResponse<NSXTQoSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraPatchQoSprofile(string QosProfileId, NSXTQoSProfileType QoSprofile, bool? Override = null)
        {
            if (QosProfileId == null) { throw new System.ArgumentNullException("QosProfileId cannot be null"); }
            if (QoSprofile == null) { throw new System.ArgumentNullException("QoSprofile cannot be null"); }
            StringBuilder GlobalInfraPatchQoSprofileServiceURL = new StringBuilder("/global-infra/qos-profiles/{qos-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            GlobalInfraPatchQoSprofileServiceURL.Replace("{qos-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(QosProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(QoSprofile);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = GlobalInfraPatchQoSprofileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + GlobalInfraPatchQoSprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTQoSProfileListResultType> GlobalGlobalInfraListQoSprofiles(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListQoSprofilesServiceURL = new StringBuilder("/global-infra/qos-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListQoSprofilesServiceURL.ToString();
            RestResponse<NSXTQoSProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTQoSProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListQoSprofilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
