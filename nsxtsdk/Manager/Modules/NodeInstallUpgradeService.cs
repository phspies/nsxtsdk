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
    public class NodeInstallUpgradeService
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeInstallUpgradeService(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateRepositoryServiceActionStart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateRepositoryServiceActionStartServiceURL = new StringBuilder("/node/services/install-upgrade?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateRepositoryServiceActionStartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType ReadRepositoryServiceStatus()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder ReadRepositoryServiceStatusServiceURL = new StringBuilder("/node/services/install-upgrade/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadRepositoryServiceStatusServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void UpdateUcState(NSXTUcStatePropertiesType UcStateProperties)
        {
            if (UcStateProperties == null) { throw new System.ArgumentNullException("UcStateProperties cannot be null"); }
            
            StringBuilder UpdateUcStateServiceURL = new StringBuilder("/node/services/install-upgrade/uc-state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(UcStateProperties, defaultSerializationSettings));
            request.Resource = UpdateUcStateServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateRepositoryServiceActionRestart()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateRepositoryServiceActionRestartServiceURL = new StringBuilder("/node/services/install-upgrade?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateRepositoryServiceActionRestartServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeServiceStatusPropertiesType CreateRepositoryServiceActionStop()
        {
            NSXTNodeServiceStatusPropertiesType returnValue = default(NSXTNodeServiceStatusPropertiesType);
            StringBuilder CreateRepositoryServiceActionStopServiceURL = new StringBuilder("/node/services/install-upgrade?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = CreateRepositoryServiceActionStopServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeServiceStatusPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeInstallUpgradeServicePropertiesType UpdateRepositoryService(NSXTNodeInstallUpgradeServicePropertiesType NodeInstallUpgradeServiceProperties)
        {
            if (NodeInstallUpgradeServiceProperties == null) { throw new System.ArgumentNullException("NodeInstallUpgradeServiceProperties cannot be null"); }
            NSXTNodeInstallUpgradeServicePropertiesType returnValue = default(NSXTNodeInstallUpgradeServicePropertiesType);
            StringBuilder UpdateRepositoryServiceServiceURL = new StringBuilder("/node/services/install-upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NodeInstallUpgradeServiceProperties, defaultSerializationSettings));
            request.Resource = UpdateRepositoryServiceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeInstallUpgradeServicePropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeInstallUpgradeServicePropertiesType ReadRepositoryService()
        {
            NSXTNodeInstallUpgradeServicePropertiesType returnValue = default(NSXTNodeInstallUpgradeServicePropertiesType);
            StringBuilder ReadRepositoryServiceServiceURL = new StringBuilder("/node/services/install-upgrade");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadRepositoryServiceServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeInstallUpgradeServicePropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}