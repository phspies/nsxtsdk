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
    public class PolicySiteGM
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySiteGM(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFederationConfigType> ReadFederationConfig()
        {
            StringBuilder ReadFederationConfigServiceURL = new StringBuilder("/infra/federation-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadFederationConfigServiceURL.ToString();
            RestResponse<NSXTFederationConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFederationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalManagerListResultType> GlobalGlobalInfraListInfraGlobalManagers(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GlobalInfraListInfraGlobalManagersServiceURL = new StringBuilder("/global-infra/global-managers");
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
            request.Resource = GlobalInfraListInfraGlobalManagersServiceURL.ToString();
            RestResponse<NSXTGlobalManagerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalManagerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListInfraGlobalManagersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsListenerCertificateType> GetInfraSiteListenerCertificate(string Address, int Port)
        {
            if (Address == null) { throw new System.ArgumentNullException("Address cannot be null"); }
            if (Port == null) { throw new System.ArgumentNullException("Port cannot be null"); }
            StringBuilder GetInfraSiteListenerCertificateServiceURL = new StringBuilder("/infra/sites/listener_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (Port != null) { request.AddQueryParameter("port", Port.ToString()); }
            request.Resource = GetInfraSiteListenerCertificateServiceURL.ToString();
            RestResponse<NSXTTlsListenerCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsListenerCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraSiteListenerCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFederationConfigType> GlobalGlobalInfraReadFederationConfig()
        {
            StringBuilder GlobalInfraReadFederationConfigServiceURL = new StringBuilder("/global-infra/federation-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GlobalInfraReadFederationConfigServiceURL.ToString();
            RestResponse<NSXTFederationConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadFederationConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteType> CreateOrUpdateInfraSite(string SiteId, NSXTSiteType Site)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (Site == null) { throw new System.ArgumentNullException("Site cannot be null"); }
            StringBuilder CreateOrUpdateInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Site);
            request.Resource = CreateOrUpdateInfraSiteServiceURL.ToString();
            RestResponse<NSXTSiteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteType> ReadSite(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder ReadSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSiteServiceURL.ToString();
            RestResponse<NSXTSiteType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchInfraSite(string SiteId, NSXTSiteType Site)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (Site == null) { throw new System.ArgumentNullException("Site cannot be null"); }
            StringBuilder PatchInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Site);
            request.Resource = PatchInfraSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraSite(string SiteId, bool? Force = null)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder DeleteInfraSiteServiceURL = new StringBuilder("/infra/sites/{site-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraSiteServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteInfraSiteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraSiteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalManagerType> GlobalGlobalInfraReadInfraGlobalManager(string GlobalManagerId)
        {
            if (GlobalManagerId == null) { throw new System.ArgumentNullException("GlobalManagerId cannot be null"); }
            StringBuilder GlobalInfraReadInfraGlobalManagerServiceURL = new StringBuilder("/global-infra/global-managers/{global-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadInfraGlobalManagerServiceURL.Replace("{global-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GlobalManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadInfraGlobalManagerServiceURL.ToString();
            RestResponse<NSXTGlobalManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadInfraGlobalManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGlobalManagerConfigType> GlobalGlobalInfraReadGlobalManagerConfigWithSensitiveData()
        {
            StringBuilder GlobalInfraReadGlobalManagerConfigWithSensitiveDataServiceURL = new StringBuilder("/global-infra/global-manager-config?action=show-sensitive-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GlobalInfraReadGlobalManagerConfigWithSensitiveDataServiceURL.ToString();
            RestResponse<NSXTGlobalManagerConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGlobalManagerConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadGlobalManagerConfigWithSensitiveDataServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsListenerCertificateType> GlobalGlobalInfraGetInfraSiteListenerCertificate(string Address, int Port)
        {
            if (Address == null) { throw new System.ArgumentNullException("Address cannot be null"); }
            if (Port == null) { throw new System.ArgumentNullException("Port cannot be null"); }
            StringBuilder GlobalInfraGetInfraSiteListenerCertificateServiceURL = new StringBuilder("/global-infra/sites/listener_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (Port != null) { request.AddQueryParameter("port", Port.ToString()); }
            request.Resource = GlobalInfraGetInfraSiteListenerCertificateServiceURL.ToString();
            RestResponse<NSXTTlsListenerCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsListenerCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetInfraSiteListenerCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
