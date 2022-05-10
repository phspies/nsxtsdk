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
    /// Trunk VLAN id range
    /// </summary>
    [NSXTProperty(Description: @"Trunk VLAN id range")]
    public class NSXTTrunkVlanRangeType 
    {
        /// <summary>
        /// Virtual Local Area Network Identifier
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public long Start { get; set; }
        /// <summary>
        /// Virtual Local Area Network Identifier
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public long End { get; set; }
    }
}
