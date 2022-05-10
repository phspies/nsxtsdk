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
    public class NSXTInterfaceArpTableType : NSXTListResultType
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The ID of the logical router port
        /// </summary>
        [JsonProperty(PropertyName = "interface_path", Required = Required.AllowNull)]
        public string InterfacePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTInterfaceArpEntryType> Results { get; set; }
        /// <summary>
        /// Policy path of edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path")]
        public string? EdgePath { get; set; }
        /// <summary>
        /// String Path of the enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
