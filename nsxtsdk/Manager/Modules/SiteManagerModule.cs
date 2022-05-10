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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class SiteManagerModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SiteManagerModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFederationConfigurationType> GetSiteConfiguration()
        {
            StringBuilder GetSiteConfigurationServiceURL = new StringBuilder("/sites");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiteConfigurationServiceURL.ToString();
            RestResponse<NSXTFederationConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiteConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSiteCompatibilityInfoType> CompatibleList()
        {
            StringBuilder CompatibleListServiceURL = new StringBuilder("/sites/compatibility");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = CompatibleListServiceURL.ToString();
            RestResponse<NSXTSiteCompatibilityInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSiteCompatibilityInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + CompatibleListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFederationConfigurationType> GetSiteConfigurationVersioned310()
        {
            StringBuilder GetSiteConfigurationVersioned310ServiceURL = new StringBuilder("/sites?version=3.1.0");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiteConfigurationVersioned310ServiceURL.ToString();
            RestResponse<NSXTFederationConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiteConfigurationVersioned310ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLocalSiteConfigurationType> GetSiteSelf()
        {
            StringBuilder GetSiteSelfServiceURL = new StringBuilder("/sites/self");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiteSelfServiceURL.ToString();
            RestResponse<NSXTLocalSiteConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLocalSiteConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiteSelfServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRemoteSiteCompatibilityInfoType> CompatibleListRemote(NSXTRemoteSiteCredentialType RemoteSiteCredential)
        {
            if (RemoteSiteCredential == null) { throw new System.ArgumentNullException("RemoteSiteCredential cannot be null"); }
            StringBuilder CompatibleListRemoteServiceURL = new StringBuilder("/sites/compatibility/remote");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.AddJsonBody(RemoteSiteCredential);
            request.Resource = CompatibleListRemoteServiceURL.ToString();
            RestResponse<NSXTRemoteSiteCompatibilityInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRemoteSiteCompatibilityInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + CompatibleListRemoteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFederationConfigurationType> GetSiteConfigurationVersionedLatest()
        {
            StringBuilder GetSiteConfigurationVersionedLatestServiceURL = new StringBuilder("/sites?version=latest");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiteConfigurationVersionedLatestServiceURL.ToString();
            RestResponse<NSXTFederationConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiteConfigurationVersionedLatestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSwitchoverStatusType> MakeActiveStatus()
        {
            StringBuilder MakeActiveStatusServiceURL = new StringBuilder("/sites/switchover-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = MakeActiveStatusServiceURL.ToString();
            RestResponse<NSXTSwitchoverStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSwitchoverStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + MakeActiveStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFederationConfigurationType> GetSiteConfigurationVersioned302()
        {
            StringBuilder GetSiteConfigurationVersioned302ServiceURL = new StringBuilder("/sites?version=3.0.2");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetSiteConfigurationVersioned302ServiceURL.ToString();
            RestResponse<NSXTFederationConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiteConfigurationVersioned302ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFederationStatusType> GetFederationStatus()
        {
            StringBuilder GetFederationStatusServiceURL = new StringBuilder("/sites/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetFederationStatusServiceURL.ToString();
            RestResponse<NSXTFederationStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFederationStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFederationStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
