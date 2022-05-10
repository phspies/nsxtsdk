using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMetadataProxyStatisticsPerLogicalSwitchType 
    {
        /// <summary>
        /// requests to nova server
        /// </summary>
        [JsonProperty(PropertyName = "requests_to_nova_server", Required = Required.AllowNull)]
        public long RequestsToNovaServer { get; set; }
        /// <summary>
        /// responses to clients
        /// </summary>
        [JsonProperty(PropertyName = "responses_to_clients", Required = Required.AllowNull)]
        public long ResponsesToClients { get; set; }
        /// <summary>
        /// succeeded responses from  nova server
        /// </summary>
        [JsonProperty(PropertyName = "succeeded_responses_from_nova_server", Required = Required.AllowNull)]
        public long SucceededResponsesFromNovaServer { get; set; }
        /// <summary>
        /// uuid of attached logical switch
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id", Required = Required.AllowNull)]
        public string LogicalSwitchId { get; set; }
        /// <summary>
        /// requests from clients
        /// </summary>
        [JsonProperty(PropertyName = "requests_from_clients", Required = Required.AllowNull)]
        public long RequestsFromClients { get; set; }
        /// <summary>
        /// error responses from  nova server
        /// </summary>
        [JsonProperty(PropertyName = "error_responses_from_nova_server", Required = Required.AllowNull)]
        public long ErrorResponsesFromNovaServer { get; set; }
    }
}
