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
    public class ServiceInsertionVMDeployment
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServiceInsertionVMDeployment(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTServiceInstanceStatusType> GetServiceInstanceStatus(string ServiceId, string ServiceInstanceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetServiceInstanceStatusServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInstanceStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInstanceStatusServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetServiceInstanceStatusServiceURL.ToString();
            RestResponse<NSXTServiceInstanceStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInstanceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDeploymentStatusType> GetServiceDeploymentStatus(string ServiceId, string ServiceDeploymentId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            StringBuilder GetServiceDeploymentStatusServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceDeploymentStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceDeploymentStatusServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetServiceDeploymentStatusServiceURL.ToString();
            RestResponse<NSXTServiceDeploymentStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDeploymentStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceDeploymentStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpgradeServiceVms(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder UpgradeServiceVmsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes?action=upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpgradeServiceVmsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpgradeServiceVmsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = UpgradeServiceVmsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpgradeServiceVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpgradeServiceDeployment(string ServiceId, string ServiceDeploymentId, NSXTDeploymentSpecNameType DeploymentSpecName)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            if (DeploymentSpecName == null) { throw new System.ArgumentNullException("DeploymentSpecName cannot be null"); }
            StringBuilder UpgradeServiceDeploymentServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}?action=upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpgradeServiceDeploymentServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpgradeServiceDeploymentServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(DeploymentSpecName);
            request.Resource = UpgradeServiceDeploymentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpgradeServiceDeploymentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeployServiceVms(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeployServiceVmsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes?action=deploy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeployServiceVmsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeployServiceVmsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeployServiceVmsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeployServiceVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceVms(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeleteServiceVmsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteServiceVmsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceVmsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceVmsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteServiceVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDeploymentType> UpdateServiceDeployment(string ServiceId, string ServiceDeploymentId, NSXTServiceDeploymentType ServiceDeployment)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            if (ServiceDeployment == null) { throw new System.ArgumentNullException("ServiceDeployment cannot be null"); }
            StringBuilder UpdateServiceDeploymentServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceDeploymentServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceDeploymentServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceDeployment);
            request.Resource = UpdateServiceDeploymentServiceURL.ToString();
            RestResponse<NSXTServiceDeploymentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDeploymentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceDeploymentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDeploymentType> GetServiceDeployment(string ServiceId, string ServiceDeploymentId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            StringBuilder GetServiceDeploymentServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceDeploymentServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceDeploymentServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceDeploymentServiceURL.ToString();
            RestResponse<NSXTServiceDeploymentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDeploymentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceDeploymentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceDeployment(string ServiceId, string ServiceDeploymentId, bool? Force = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            StringBuilder DeleteServiceDeploymentServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceDeploymentServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceDeploymentServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeleteServiceDeploymentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceDeploymentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDeploymentType> DeployService(string ServiceId, NSXTServiceDeploymentType ServiceDeployment)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeployment == null) { throw new System.ArgumentNullException("ServiceDeployment cannot be null"); }
            StringBuilder DeployServiceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeployServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceDeployment);
            request.Resource = DeployServiceServiceURL.ToString();
            RestResponse<NSXTServiceDeploymentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDeploymentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeployServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDeploymentListResultType> GetServiceDeployments(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetServiceDeploymentsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceDeploymentsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceDeploymentsServiceURL.ToString();
            RestResponse<NSXTServiceDeploymentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDeploymentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceDeploymentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInstanceRuntimeListResultType> ListInstanceRuntimes(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ListInstanceRuntimesServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInstanceRuntimesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInstanceRuntimesServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListInstanceRuntimesServiceURL.ToString();
            RestResponse<NSXTInstanceRuntimeListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInstanceRuntimeListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInstanceRuntimesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task UpdateServiceVmState(string ServiceId, string ServiceInstanceId, string InstanceRuntimeId, string? Action = null, string? UnhealthyReason = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceRuntimeId == null) { throw new System.ArgumentNullException("InstanceRuntimeId cannot be null"); }
            StringBuilder UpdateServiceVmStateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes/{instance-runtime-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpdateServiceVmStateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceVmStateServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceVmStateServiceURL.Replace("{instance-runtime-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InstanceRuntimeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (UnhealthyReason != null) { request.AddQueryParameter("unhealthy_reason", UnhealthyReason.ToString()); }
            request.Resource = UpdateServiceVmStateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateServiceVmStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetServiceDeploymentState(string ServiceId, string ServiceDeploymentId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDeploymentId == null) { throw new System.ArgumentNullException("ServiceDeploymentId cannot be null"); }
            StringBuilder GetServiceDeploymentStateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-deployments/{service-deployment-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceDeploymentStateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceDeploymentStateServiceURL.Replace("{service-deployment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceDeploymentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceDeploymentStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceDeploymentStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuntimeInterfaceOperationalStatusType> GetRuntimeInterfaceOperationalStatus(string ServiceId, string ServiceInstanceId, string InstanceRuntimeId, string InterfaceIndex, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceRuntimeId == null) { throw new System.ArgumentNullException("InstanceRuntimeId cannot be null"); }
            if (InterfaceIndex == null) { throw new System.ArgumentNullException("InterfaceIndex cannot be null"); }
            StringBuilder GetRuntimeInterfaceOperationalStatusServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes/{instance-runtime-id}/interfaces/{interface_index}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRuntimeInterfaceOperationalStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceOperationalStatusServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceOperationalStatusServiceURL.Replace("{instance-runtime-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InstanceRuntimeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceOperationalStatusServiceURL.Replace("{interface_index}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceIndex, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetRuntimeInterfaceOperationalStatusServiceURL.ToString();
            RestResponse<NSXTRuntimeInterfaceOperationalStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuntimeInterfaceOperationalStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRuntimeInterfaceOperationalStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTConfigurationStateType> GetServiceInstanceState(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetServiceInstanceStateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInstanceStateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInstanceStateServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInstanceStateServiceURL.ToString();
            RestResponse<NSXTConfigurationStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTConfigurationStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInstanceStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuntimeInterfaceStatisticsType> GetRuntimeInterfaceStatistics(string ServiceId, string ServiceInstanceId, string InstanceRuntimeId, string InterfaceIndex, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceRuntimeId == null) { throw new System.ArgumentNullException("InstanceRuntimeId cannot be null"); }
            if (InterfaceIndex == null) { throw new System.ArgumentNullException("InterfaceIndex cannot be null"); }
            StringBuilder GetRuntimeInterfaceStatisticsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-runtimes/{instance-runtime-id}/interfaces/{interface_index}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRuntimeInterfaceStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceStatisticsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceStatisticsServiceURL.Replace("{instance-runtime-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InstanceRuntimeId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuntimeInterfaceStatisticsServiceURL.Replace("{interface_index}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceIndex, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetRuntimeInterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTRuntimeInterfaceStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuntimeInterfaceStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRuntimeInterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
