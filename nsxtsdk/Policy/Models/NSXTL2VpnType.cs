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
    public class NSXTL2VpnType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of paths referencing transport tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "transport_tunnels", Required = Required.AllowNull)]
        public IList<string> TransportTunnels { get; set; }
        /// <summary>
        /// Enable to extend all the associated segments.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
