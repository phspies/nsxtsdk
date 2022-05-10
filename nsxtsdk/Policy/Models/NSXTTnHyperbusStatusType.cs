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
    public class NSXTTnHyperbusStatusType 
    {
        /// <summary>
        /// Display the hyperbus status
        /// </summary>
        [JsonProperty(PropertyName = "hyperbus_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTnHyperbusStatusHyperbusStatusEnumType HyperbusStatus { get; set; }
        /// <summary>
        /// Transport node id.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public string TransportNodeId { get; set; }
    }
}
