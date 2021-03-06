using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMetadataProxyStatisticsPerSegmentType 
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
        /// requests from clients
        /// </summary>
        [JsonProperty(PropertyName = "requests_from_clients", Required = Required.AllowNull)]
        public long RequestsFromClients { get; set; }
        /// <summary>
        /// error responses from  nova server
        /// </summary>
        [JsonProperty(PropertyName = "error_responses_from_nova_server", Required = Required.AllowNull)]
        public long ErrorResponsesFromNovaServer { get; set; }
        /// <summary>
        /// Policy path of the attached segment
        /// </summary>
        [JsonProperty(PropertyName = "segment_path", Required = Required.AllowNull)]
        public string SegmentPath { get; set; }
    }
}
