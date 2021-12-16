// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
    public class CentralApiModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public CentralApiModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePutFabricCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePutFabricCentralAPIServiceURL = new StringBuilder("/fabric/nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            InvokePutFabricCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePutFabricCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePutFabricCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + InvokePutFabricCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePostFabricCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePostFabricCentralAPIServiceURL = new StringBuilder("/fabric/nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            InvokePostFabricCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePostFabricCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePostFabricCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + InvokePostFabricCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeDeleteFabricCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeDeleteFabricCentralAPIServiceURL = new StringBuilder("/fabric/nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            InvokeDeleteFabricCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeDeleteFabricCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeDeleteFabricCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + InvokeDeleteFabricCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeGetFabricCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeGetFabricCentralAPIServiceURL = new StringBuilder("/fabric/nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            InvokeGetFabricCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeGetFabricCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeGetFabricCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + InvokeGetFabricCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePutTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePutTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            InvokePutTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePutTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePutTransportNodeCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + InvokePutTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePostTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePostTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            InvokePostTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePostTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePostTransportNodeCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + InvokePostTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeGetTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeGetTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            InvokeGetTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeGetTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeGetTransportNodeCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + InvokeGetTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeDeleteTransportNodeCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeDeleteTransportNodeCentralAPIServiceURL = new StringBuilder("/transport-nodes/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            InvokeDeleteTransportNodeCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeDeleteTransportNodeCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeDeleteTransportNodeCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + InvokeDeleteTransportNodeCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePutClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePutClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            InvokePutClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePutClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePutClusterCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + InvokePutClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokePostClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokePostClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            InvokePostClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokePostClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokePostClusterCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + InvokePostClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeDeleteClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeDeleteClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            InvokeDeleteClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeDeleteClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeDeleteClusterCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + InvokeDeleteClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void InvokeGetClusterCentralAPI(string TargetNodeId, string TargetUri)
        {
            if (TargetNodeId == null) { throw new System.ArgumentNullException("TargetNodeId cannot be null"); }
            if (TargetUri == null) { throw new System.ArgumentNullException("TargetUri cannot be null"); }
            
            StringBuilder InvokeGetClusterCentralAPIServiceURL = new StringBuilder("/cluster/{target-node-id}/{target-uri}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            InvokeGetClusterCentralAPIServiceURL.Replace("{target-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            InvokeGetClusterCentralAPIServiceURL.Replace("{target-uri}", System.Uri.EscapeDataString(Helpers.ConvertToString(TargetUri, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = InvokeGetClusterCentralAPIServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + InvokeGetClusterCentralAPIServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
