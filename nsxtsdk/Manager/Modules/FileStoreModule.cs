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
    public class FileStoreModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FileStoreModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task CopyToRemoteFileCopyToRemoteFile(string FileName, NSXTCopyToRemoteFilePropertiesType CopyToRemoteFileProperties)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            if (CopyToRemoteFileProperties == null) { throw new System.ArgumentNullException("CopyToRemoteFileProperties cannot be null"); }
            StringBuilder CopyToRemoteFileCopyToRemoteFileServiceURL = new StringBuilder("/node/file-store/{file-name}?action=copy_to_remote_file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CopyToRemoteFileCopyToRemoteFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CopyToRemoteFileProperties);
            request.Resource = CopyToRemoteFileCopyToRemoteFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CopyToRemoteFileCopyToRemoteFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesType> UpdateFile(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder UpdateFileServiceURL = new StringBuilder("/node/file-store/{file-name}/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = UpdateFileServiceURL.ToString();
            RestResponse<NSXTFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ReadFile(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder ReadFileServiceURL = new StringBuilder("/node/file-store/{file-name}/data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFileThumbprintType> ReadFileThumbprint(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder ReadFileThumbprintServiceURL = new StringBuilder("/node/file-store/{file-name}/thumbprint");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFileThumbprintServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFileThumbprintServiceURL.ToString();
            RestResponse<NSXTFileThumbprintType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFileThumbprintType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFileThumbprintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesType> CreateFile(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder CreateFileServiceURL = new StringBuilder("/node/file-store/{file-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CreateFileServiceURL.ToString();
            RestResponse<NSXTFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteFile(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder DeleteFileServiceURL = new StringBuilder("/node/file-store/{file-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesType> ReadFileProperties(string FileName)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            StringBuilder ReadFilePropertiesServiceURL = new StringBuilder("/node/file-store/{file-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFilePropertiesServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFilePropertiesServiceURL.ToString();
            RestResponse<NSXTFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFilePropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesType> CopyFromRemoteFileCopyFromRemoteFile(string FileName, NSXTCopyFromRemoteFilePropertiesType CopyFromRemoteFileProperties)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            if (CopyFromRemoteFileProperties == null) { throw new System.ArgumentNullException("CopyFromRemoteFileProperties cannot be null"); }
            StringBuilder CopyFromRemoteFileCopyFromRemoteFileServiceURL = new StringBuilder("/node/file-store/{file-name}?action=copy_from_remote_file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CopyFromRemoteFileCopyFromRemoteFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CopyFromRemoteFileProperties);
            request.Resource = CopyFromRemoteFileCopyFromRemoteFileServiceURL.ToString();
            RestResponse<NSXTFilePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CopyFromRemoteFileCopyFromRemoteFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesListResultType> ListFiles()
        {
            StringBuilder ListFilesServiceURL = new StringBuilder("/node/file-store");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListFilesServiceURL.ToString();
            RestResponse<NSXTFilePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateRemoteDirectoryCreateRemoteDirectory(NSXTCreateRemoteDirectoryPropertiesType CreateRemoteDirectoryProperties)
        {
            if (CreateRemoteDirectoryProperties == null) { throw new System.ArgumentNullException("CreateRemoteDirectoryProperties cannot be null"); }
            StringBuilder CreateRemoteDirectoryCreateRemoteDirectoryServiceURL = new StringBuilder("/node/file-store?action=create_remote_directory");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CreateRemoteDirectoryProperties);
            request.Resource = CreateRemoteDirectoryCreateRemoteDirectoryServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateRemoteDirectoryCreateRemoteDirectoryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
