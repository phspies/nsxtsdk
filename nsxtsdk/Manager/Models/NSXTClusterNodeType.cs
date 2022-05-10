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
    /// This type contains attributes of a cluster node that are relevant to the Cluster Boot Manager.
    /// </summary>
    [NSXTProperty(Description: @"This type contains attributes of a cluster node that are relevant to the Cluster Boot Manager.")]
    public class NSXTClusterNodeType 
    {
        /// <summary>
        /// Current clustering status of the node
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeStatusEnumType? Status { get; set; }
        /// <summary>
        /// Entities on the node
        /// </summary>
        [JsonProperty(PropertyName = "entities", Required = Required.AllowNull)]
        public IList<NSXTClusterNodeEntityType> Entities { get; set; }
        /// <summary>
        /// UUID of the node
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid", Required = Required.AllowNull)]
        public string NodeUuid { get; set; }
    }
}
