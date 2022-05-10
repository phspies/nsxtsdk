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
    public class NSXTBridgeEndpointStatusType 
    {
        /// <summary>
        /// The Ids of the transport nodes which actively serve the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "active_nodes")]
        public IList<string> ActiveNodes { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The id of the bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "endpoint_id")]
        public string? EndpointId { get; set; }
    }
}
