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
    public class FileUploadFramework
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FileUploadFramework(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBundleIdType> UploadBundleViaRemoteFile(NSXTRemoteBundleUrlType RemoteBundleUrl, string FileType, string Product)
        {
            if (RemoteBundleUrl == null) { throw new System.ArgumentNullException("RemoteBundleUrl cannot be null"); }
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder UploadBundleViaRemoteFileServiceURL = new StringBuilder("/repository/bundles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RemoteBundleUrl);
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = UploadBundleViaRemoteFileServiceURL.ToString();
            RestResponse<NSXTBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadBundleViaRemoteFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBundleIdsType> GetBundleIds(string FileType, string Product)
        {
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder GetBundleIdsServiceURL = new StringBuilder("/repository/bundles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = GetBundleIdsServiceURL.ToString();
            RestResponse<NSXTBundleIdsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBundleIdsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBundleIdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBundleUploadStatusType> GetBundleUploadStatus(string BundleId, string Product)
        {
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder GetBundleUploadStatusServiceURL = new StringBuilder("/repository/bundles/{bundle-id}/upload-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetBundleUploadStatusServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = GetBundleUploadStatusServiceURL.ToString();
            RestResponse<NSXTBundleUploadStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBundleUploadStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBundleUploadStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOvfInfoType> GetOvfDeployInfo(string Product)
        {
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder GetOvfDeployInfoServiceURL = new StringBuilder("/repository/bundles/ovf-deploy-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = GetOvfDeployInfoServiceURL.ToString();
            RestResponse<NSXTOvfInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOvfInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOvfDeployInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CancelBundleUpload(string BundleId, string Product)
        {
            if (BundleId == null) { throw new System.ArgumentNullException("BundleId cannot be null"); }
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder CancelBundleUploadServiceURL = new StringBuilder("/repository/bundles/{bundle-id}?action=cancel_upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelBundleUploadServiceURL.Replace("{bundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(BundleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = CancelBundleUploadServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelBundleUploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBundleUploadPermissionType> GetBundleUploadPermissions(string Product)
        {
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder GetBundleUploadPermissionsServiceURL = new StringBuilder("/repository/bundles/upload-allowed");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = GetBundleUploadPermissionsServiceURL.ToString();
            RestResponse<NSXTBundleUploadPermissionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBundleUploadPermissionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetBundleUploadPermissionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBundleIdType> UploadBundleViaLocalFile(string File, string FileType, string Product)
        {
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            if (FileType == null) { throw new System.ArgumentNullException("FileType cannot be null"); }
            if (Product == null) { throw new System.ArgumentNullException("Product cannot be null"); }
            StringBuilder UploadBundleViaLocalFileServiceURL = new StringBuilder("/repository/bundles?action=upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            
            if (FileType != null) { request.AddQueryParameter("file_type", FileType.ToString()); }
            if (Product != null) { request.AddQueryParameter("product", Product.ToString()); }
            request.Resource = UploadBundleViaLocalFileServiceURL.ToString();
            RestResponse<NSXTBundleIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBundleIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadBundleViaLocalFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
