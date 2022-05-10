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
    public class PolicyTask
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTask(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTImportTaskType> CancelImportTask()
        {
            StringBuilder CancelImportTaskServiceURL = new StringBuilder("/infra/settings/firewall/import?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CancelImportTaskServiceURL.ToString();
            RestResponse<NSXTImportTaskType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTImportTaskType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelImportTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExportTaskType> InvokeExportTask(NSXTExportRequestParameterType ExportRequestParameter)
        {
            if (ExportRequestParameter == null) { throw new System.ArgumentNullException("ExportRequestParameter cannot be null"); }
            StringBuilder InvokeExportTaskServiceURL = new StringBuilder("/infra/settings/firewall/export");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ExportRequestParameter);
            request.Resource = InvokeExportTaskServiceURL.ToString();
            RestResponse<NSXTExportTaskType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExportTaskType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + InvokeExportTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExportTaskType> GetExportTask()
        {
            StringBuilder GetExportTaskServiceURL = new StringBuilder("/infra/settings/firewall/export");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetExportTaskServiceURL.ToString();
            RestResponse<NSXTExportTaskType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExportTaskType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetExportTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DownloadExportedFile()
        {
            StringBuilder DownloadExportedFileServiceURL = new StringBuilder("/infra/settings/firewall/export?action=download");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = DownloadExportedFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + DownloadExportedFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTImportTaskType> GetImportTask()
        {
            StringBuilder GetImportTaskServiceURL = new StringBuilder("/infra/settings/firewall/import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetImportTaskServiceURL.ToString();
            RestResponse<NSXTImportTaskType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTImportTaskType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetImportTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExportTaskType> CancelExportTask()
        {
            StringBuilder CancelExportTaskServiceURL = new StringBuilder("/infra/settings/firewall/export?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CancelExportTaskServiceURL.ToString();
            RestResponse<NSXTExportTaskType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExportTaskType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelExportTaskServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
