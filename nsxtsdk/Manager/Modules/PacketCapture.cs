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
    public class PacketCapture
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PacketCapture(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPacketCaptureSessionType> TerminatePacketCaptureSession(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder TerminatePacketCaptureSessionServiceURL = new StringBuilder("/pktcap/session/{session-id}?action=terminate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            TerminatePacketCaptureSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = TerminatePacketCaptureSessionServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + TerminatePacketCaptureSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GetCaptureFile(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetCaptureFileServiceURL = new StringBuilder("/pktcap/session/{session-id}/capturefile");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCaptureFileServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCaptureFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCaptureFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionType> DeletePacketCaptureSession(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder DeletePacketCaptureSessionServiceURL = new StringBuilder("/pktcap/session/{session-id}?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeletePacketCaptureSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePacketCaptureSessionServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeletePacketCaptureSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionType> ReadPacketCaptureSession(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder ReadPacketCaptureSessionServiceURL = new StringBuilder("/pktcap/session/{session-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadPacketCaptureSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadPacketCaptureSessionServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPacketCaptureSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionListType> ListPacketCaptureSessions()
        {
            StringBuilder ListPacketCaptureSessionsServiceURL = new StringBuilder("/pktcap/sessions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListPacketCaptureSessionsServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPacketCaptureSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionType> RestartPacketCaptureSession(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder RestartPacketCaptureSessionServiceURL = new StringBuilder("/pktcap/session/{session-id}?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartPacketCaptureSessionServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RestartPacketCaptureSessionServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RestartPacketCaptureSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionListType> DeleteAllCaptureSessions()
        {
            StringBuilder DeleteAllCaptureSessionsServiceURL = new StringBuilder("/pktcap/sessions?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = DeleteAllCaptureSessionsServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteAllCaptureSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPacketCaptureSessionType> CreatePacketCaptureSession(NSXTPacketCaptureRequestType PacketCaptureRequest)
        {
            if (PacketCaptureRequest == null) { throw new System.ArgumentNullException("PacketCaptureRequest cannot be null"); }
            StringBuilder CreatePacketCaptureSessionServiceURL = new StringBuilder("/pktcap/session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PacketCaptureRequest);
            request.Resource = CreatePacketCaptureSessionServiceURL.ToString();
            RestResponse<NSXTPacketCaptureSessionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPacketCaptureSessionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePacketCaptureSessionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
