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
    public class NSXTPnicMirrorDestinationType : NSXTMirrorDestinationType
    {
        /// <summary>
        /// Physical NIC device names to which to send the mirrored packets
        /// </summary>
        [JsonProperty(PropertyName = "dest_pnics", Required = Required.AllowNull)]
        public IList<string> DestPnics { get; set; }
        /// <summary>
        /// Transport node to which to send the mirrored packets
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        public string NodeId { get; set; }
    }
}
