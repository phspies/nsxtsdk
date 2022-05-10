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
    public class PolicyCloudNative
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCloudNative(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTUploadBundleStatusType> GetUploadBundleStatus(string SiteId, string BundleId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            StringBuilder GetUploadBundleStatusServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/tools/upload/status/{bundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetUploadBundleStatusServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            GetUploadBundleStatusServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUploadBundleStatusServiceURL.ToString();
            RestResponse<NSXTUploadBundleStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUploadBundleStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetUploadBundleStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentRegistryType> UpdateDeploymentRegistry(string SiteId, NSXTDeploymentRegistryType DeploymentRegistry)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (DeploymentRegistry == null) { throw new System.ArgumentNullException("DeploymentRegistry cannot be null"); }
            StringBuilder UpdateDeploymentRegistryServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/registry");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateDeploymentRegistryServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DeploymentRegistry);
            request.Resource = UpdateDeploymentRegistryServiceURL.ToString();
            RestResponse<NSXTDeploymentRegistryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentRegistryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateDeploymentRegistryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentRegistryType> GetDeploymentRegistry(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetDeploymentRegistryServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/registry");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDeploymentRegistryServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDeploymentRegistryServiceURL.ToString();
            RestResponse<NSXTDeploymentRegistryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentRegistryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDeploymentRegistryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUploadBundleIdType> UploadContainerTools(string SiteId, string File)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder UploadContainerToolsServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/tools/upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadContainerToolsServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            
            request.Resource = UploadContainerToolsServiceURL.ToString();
            RestResponse<NSXTUploadBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUploadBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadContainerToolsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUploadBundleIdType> UploadContainerToolsFromRemoteServer(string SiteId, NSXTUploadBundleRemoteServerType UploadBundleRemoteServer)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (UploadBundleRemoteServer == null) { throw new System.ArgumentNullException("UploadBundleRemoteServer cannot be null"); }
            StringBuilder UploadContainerToolsFromRemoteServerServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/tools/upload_from_remote_server");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadContainerToolsFromRemoteServerServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(UploadBundleRemoteServer);
            request.Resource = UploadContainerToolsFromRemoteServerServiceURL.ToString();
            RestResponse<NSXTUploadBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUploadBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadContainerToolsFromRemoteServerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTUploadBundleIdType> UploadKubeconfig(string SiteId, string File)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder UploadKubeconfigServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/kubeconfig");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadKubeconfigServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            
            request.Resource = UploadKubeconfigServiceURL.ToString();
            RestResponse<NSXTUploadBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTUploadBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadKubeconfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTKubeconfigInfoType> GetKubeconfigInfo(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetKubeconfigInfoServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/kubeconfig");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetKubeconfigInfoServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetKubeconfigInfoServiceURL.ToString();
            RestResponse<NSXTKubeconfigInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTKubeconfigInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetKubeconfigInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTKubernetesToolsInfoType> GetKubernetesToolsInfo(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetKubernetesToolsInfoServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/kubernetes-tools");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetKubernetesToolsInfoServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetKubernetesToolsInfoServiceURL.ToString();
            RestResponse<NSXTKubernetesToolsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTKubernetesToolsInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetKubernetesToolsInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDeploymentRegistryType> ResetDeploymentRegistry(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder ResetDeploymentRegistryServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/registry/reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            ResetDeploymentRegistryServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetDeploymentRegistryServiceURL.ToString();
            RestResponse<NSXTDeploymentRegistryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDeploymentRegistryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + ResetDeploymentRegistryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStorageClassesType> GetStorageClasses(string SiteId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            StringBuilder GetStorageClassesServiceURL = new StringBuilder("/infra/sites/{site-id}/napp/deployment/storage-classes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetStorageClassesServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetStorageClassesServiceURL.ToString();
            RestResponse<NSXTStorageClassesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStorageClassesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetStorageClassesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
