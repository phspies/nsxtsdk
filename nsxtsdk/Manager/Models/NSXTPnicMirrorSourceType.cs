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
    public class NSXTPnicMirrorSourceType : NSXTMirrorSourceType
    {
        /// <summary>
        /// Transport node identifier for the pnic located.
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        public string NodeId { get; set; }
        /// <summary>
        /// Whether to filter encapsulated packet.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulated", Required = Required.AllowNull)]
        public bool Encapsulated { get; set; }
        /// <summary>
        /// Source physical NIC device names
        /// </summary>
        [JsonProperty(PropertyName = "source_pnics", Required = Required.AllowNull)]
        public IList<string> SourcePnics { get; set; }
    }
}
