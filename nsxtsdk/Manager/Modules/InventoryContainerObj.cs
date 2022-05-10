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
    public class InventoryContainerObj
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public InventoryContainerObj(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTContainerApplicationInstanceType> GetContainerApplicationInstance(string ContainerApplicationInstanceId)
        {
            if (ContainerApplicationInstanceId == null) { throw new System.ArgumentNullException("ContainerApplicationInstanceId cannot be null"); }
            StringBuilder GetContainerApplicationInstanceServiceURL = new StringBuilder("/fabric/container-application-instances/{container-application-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerApplicationInstanceServiceURL.Replace("{container-application-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerApplicationInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerApplicationInstanceServiceURL.ToString();
            RestResponse<NSXTContainerApplicationInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerApplicationInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerApplicationInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterListResultType> ListContainerClusters(string? ClusterType = null, string? Cursor = null, string? IncludedFields = null, string? InfraType = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerClustersServiceURL = new StringBuilder("/fabric/container-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ClusterType != null) { request.AddQueryParameter("cluster_type", ClusterType.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (InfraType != null) { request.AddQueryParameter("infra_type", InfraType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerClustersServiceURL.ToString();
            RestResponse<NSXTContainerClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerClustersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerIngressPolicyType> GetContainerIngressPolicy(string IngressPolicyId)
        {
            if (IngressPolicyId == null) { throw new System.ArgumentNullException("IngressPolicyId cannot be null"); }
            StringBuilder GetContainerIngressPolicyServiceURL = new StringBuilder("/fabric/container-ingress-policies/{ingress-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerIngressPolicyServiceURL.Replace("{ingress-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IngressPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerIngressPolicyServiceURL.ToString();
            RestResponse<NSXTContainerIngressPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerIngressPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerIngressPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerIngressPolicyListResultType> ListContainerIngressPolicies(string? ContainerClusterId = null, string? ContainerProjectId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerIngressPoliciesServiceURL = new StringBuilder("/fabric/container-ingress-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (ContainerProjectId != null) { request.AddQueryParameter("container_project_id", ContainerProjectId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerIngressPoliciesServiceURL.ToString();
            RestResponse<NSXTContainerIngressPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerIngressPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerIngressPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerApplicationType> GetContainerApplication(string ContainerApplicationId)
        {
            if (ContainerApplicationId == null) { throw new System.ArgumentNullException("ContainerApplicationId cannot be null"); }
            StringBuilder GetContainerApplicationServiceURL = new StringBuilder("/fabric/container-applications/{container-application-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerApplicationServiceURL.Replace("{container-application-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerApplicationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerApplicationServiceURL.ToString();
            RestResponse<NSXTContainerApplicationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerApplicationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerApplicationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerProjectListResultType> ListContainerProjects(string? ContainerClusterId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerProjectsServiceURL = new StringBuilder("/fabric/container-projects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerProjectsServiceURL.ToString();
            RestResponse<NSXTContainerProjectListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerProjectListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerProjectsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerApplicationListResultType> ListContainerApplications(string? ContainerClusterId = null, string? ContainerProjectId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerApplicationsServiceURL = new StringBuilder("/fabric/container-applications");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (ContainerProjectId != null) { request.AddQueryParameter("container_project_id", ContainerProjectId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerApplicationsServiceURL.ToString();
            RestResponse<NSXTContainerApplicationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerApplicationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerApplicationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerNetworkPolicyListResultType> ListContainerNetworkPolicies(string? ContainerClusterId = null, string? ContainerProjectId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerNetworkPoliciesServiceURL = new StringBuilder("/fabric/container-network-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (ContainerProjectId != null) { request.AddQueryParameter("container_project_id", ContainerProjectId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerNetworkPoliciesServiceURL.ToString();
            RestResponse<NSXTContainerNetworkPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerNetworkPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerNetworkPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerProjectType> GetContainerProject(string ContainerProjectId)
        {
            if (ContainerProjectId == null) { throw new System.ArgumentNullException("ContainerProjectId cannot be null"); }
            StringBuilder GetContainerProjectServiceURL = new StringBuilder("/fabric/container-projects/{container-project-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerProjectServiceURL.Replace("{container-project-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerProjectId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerProjectServiceURL.ToString();
            RestResponse<NSXTContainerProjectType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerProjectType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerProjectServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterType> GetContainerCluster(string ContainerClusterId)
        {
            if (ContainerClusterId == null) { throw new System.ArgumentNullException("ContainerClusterId cannot be null"); }
            StringBuilder GetContainerClusterServiceURL = new StringBuilder("/fabric/container-clusters/{container-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerClusterServiceURL.Replace("{container-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerClusterServiceURL.ToString();
            RestResponse<NSXTContainerClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerClusterServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterNodeType> GetContainerClusterNode(string ContainerClusterNodeId)
        {
            if (ContainerClusterNodeId == null) { throw new System.ArgumentNullException("ContainerClusterNodeId cannot be null"); }
            StringBuilder GetContainerClusterNodeServiceURL = new StringBuilder("/fabric/container-cluster-nodes/{container-cluster-node-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerClusterNodeServiceURL.Replace("{container-cluster-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerClusterNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerClusterNodeServiceURL.ToString();
            RestResponse<NSXTContainerClusterNodeType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterNodeType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerClusterNodeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerNetworkPolicyType> GetContainerNetworkPolicy(string NetworkPolicyId)
        {
            if (NetworkPolicyId == null) { throw new System.ArgumentNullException("NetworkPolicyId cannot be null"); }
            StringBuilder GetContainerNetworkPolicyServiceURL = new StringBuilder("/fabric/container-network-policies/{network-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetContainerNetworkPolicyServiceURL.Replace("{network-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NetworkPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetContainerNetworkPolicyServiceURL.ToString();
            RestResponse<NSXTContainerNetworkPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerNetworkPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetContainerNetworkPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerApplicationInstanceListResultType> ListContainerApplicationInstances(string? ContainerApplicationId = null, string? ContainerClusterId = null, string? ContainerProjectId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerApplicationInstancesServiceURL = new StringBuilder("/fabric/container-application-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerApplicationId != null) { request.AddQueryParameter("container_application_id", ContainerApplicationId.ToString()); }
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (ContainerProjectId != null) { request.AddQueryParameter("container_project_id", ContainerProjectId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerApplicationInstancesServiceURL.ToString();
            RestResponse<NSXTContainerApplicationInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerApplicationInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerApplicationInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTContainerClusterNodeListResultType> ListContainerClusterNodes(string? ContainerClusterId = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? ScopeId = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListContainerClusterNodesServiceURL = new StringBuilder("/fabric/container-cluster-nodes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ContainerClusterId != null) { request.AddQueryParameter("container_cluster_id", ContainerClusterId.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (ScopeId != null) { request.AddQueryParameter("scope_id", ScopeId.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerClusterNodesServiceURL.ToString();
            RestResponse<NSXTContainerClusterNodeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTContainerClusterNodeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerClusterNodesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
