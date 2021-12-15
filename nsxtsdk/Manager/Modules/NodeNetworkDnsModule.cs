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
    public class NodeNetworkDnsModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeNetworkDnsModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeNameServersPropertiesType UpdateNodeNameServers(NSXTNodeNameServersPropertiesType NodeNameServersProperties)
        {
            if (NodeNameServersProperties == null) { throw new System.ArgumentNullException("NodeNameServersProperties cannot be null"); }
            NSXTNodeNameServersPropertiesType returnValue = default(NSXTNodeNameServersPropertiesType);
            StringBuilder UpdateNodeNameServersServiceURL = new StringBuilder("/node/network/name-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NodeNameServersProperties, defaultSerializationSettings));
            request.Resource = UpdateNodeNameServersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeNameServersPropertiesType>(response.Content, defaultSerializationSettings);
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
        public NSXTNodeNameServersPropertiesType ReadNodeNameServers()
        {
            NSXTNodeNameServersPropertiesType returnValue = default(NSXTNodeNameServersPropertiesType);
            StringBuilder ReadNodeNameServersServiceURL = new StringBuilder("/node/network/name-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadNodeNameServersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeNameServersPropertiesType>(response.Content, defaultSerializationSettings);
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
        public NSXTNodeSearchDomainsPropertiesType UpdateNodeSearchDomains(NSXTNodeSearchDomainsPropertiesType NodeSearchDomainsProperties)
        {
            if (NodeSearchDomainsProperties == null) { throw new System.ArgumentNullException("NodeSearchDomainsProperties cannot be null"); }
            NSXTNodeSearchDomainsPropertiesType returnValue = default(NSXTNodeSearchDomainsPropertiesType);
            StringBuilder UpdateNodeSearchDomainsServiceURL = new StringBuilder("/node/network/search-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NodeSearchDomainsProperties, defaultSerializationSettings));
            request.Resource = UpdateNodeSearchDomainsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeSearchDomainsPropertiesType>(response.Content, defaultSerializationSettings);
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
        public NSXTNodeSearchDomainsPropertiesType ReadNodeSearchDomains()
        {
            NSXTNodeSearchDomainsPropertiesType returnValue = default(NSXTNodeSearchDomainsPropertiesType);
            StringBuilder ReadNodeSearchDomainsServiceURL = new StringBuilder("/node/network/search-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ReadNodeSearchDomainsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeSearchDomainsPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}