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
    public class HostPrepServiceFabric
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public HostPrepServiceFabric(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTSupportedHostOSListResultType GetSupportedHostOstypes()
        {
            NSXTSupportedHostOSListResultType returnValue = default(NSXTSupportedHostOSListResultType);
            StringBuilder GetSupportedHostOstypesServiceURL = new StringBuilder("/fabric/ostypes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetSupportedHostOstypesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetSupportedHostOstypesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTSupportedHostOSListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTSupportedHostOSListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeType PerformHostNodeUpgradeActionUpgradeInfra(string NodeId, bool? DisableVmMigration = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            NSXTNodeType returnValue = default(NSXTNodeType);
            StringBuilder PerformHostNodeUpgradeActionUpgradeInfraServiceURL = new StringBuilder("/fabric/nodes/{node-id}?action=upgrade_infra");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            PerformHostNodeUpgradeActionUpgradeInfraServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (DisableVmMigration != null) { request.AddQueryParameter("disable_vm_migration", DisableVmMigration.ToString()); }
            request.Resource = PerformHostNodeUpgradeActionUpgradeInfraServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + PerformHostNodeUpgradeActionUpgradeInfraServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTNodeType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTNodeType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
