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
    public class ExcludeList
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ExcludeList(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTResourceReferenceType> RemoveMember(string ObjectId, bool? DeepCheck = null, string? ObjectType = null)
        {
            if (ObjectId == null) { throw new System.ArgumentNullException("ObjectId cannot be null"); }
            StringBuilder RemoveMemberServiceURL = new StringBuilder("/firewall/excludelist?action=remove_member");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (DeepCheck != null) { request.AddQueryParameter("deep_check", DeepCheck.ToString()); }
            if (ObjectId != null) { request.AddQueryParameter("object_id", ObjectId.ToString()); }
            if (ObjectType != null) { request.AddQueryParameter("object_type", ObjectType.ToString()); }
            request.Resource = RemoveMemberServiceURL.ToString();
            RestResponse<NSXTResourceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTResourceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RemoveMemberServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExcludeListType> UpdateExcludeList(NSXTExcludeListType ExcludeList)
        {
            if (ExcludeList == null) { throw new System.ArgumentNullException("ExcludeList cannot be null"); }
            StringBuilder UpdateExcludeListServiceURL = new StringBuilder("/firewall/excludelist");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(ExcludeList);
            request.Resource = UpdateExcludeListServiceURL.ToString();
            RestResponse<NSXTExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExcludeListType> GetExcludeList()
        {
            StringBuilder GetExcludeListServiceURL = new StringBuilder("/firewall/excludelist");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetExcludeListServiceURL.ToString();
            RestResponse<NSXTExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTResourceReferenceType> AddMember(NSXTResourceReferenceType ResourceReference)
        {
            if (ResourceReference == null) { throw new System.ArgumentNullException("ResourceReference cannot be null"); }
            StringBuilder AddMemberServiceURL = new StringBuilder("/firewall/excludelist?action=add_member");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ResourceReference);
            request.Resource = AddMemberServiceURL.ToString();
            RestResponse<NSXTResourceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTResourceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddMemberServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTResourceReferenceType> CheckMemberIfExists(string ObjectId, bool? DeepCheck = null, string? ObjectType = null)
        {
            if (ObjectId == null) { throw new System.ArgumentNullException("ObjectId cannot be null"); }
            StringBuilder CheckMemberIfExistsServiceURL = new StringBuilder("/firewall/excludelist?action=check_if_exists");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (DeepCheck != null) { request.AddQueryParameter("deep_check", DeepCheck.ToString()); }
            if (ObjectId != null) { request.AddQueryParameter("object_id", ObjectId.ToString()); }
            if (ObjectType != null) { request.AddQueryParameter("object_type", ObjectType.ToString()); }
            request.Resource = CheckMemberIfExistsServiceURL.ToString();
            RestResponse<NSXTResourceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTResourceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckMemberIfExistsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
