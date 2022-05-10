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
    public class NSXTEvpnTunnelEndpointConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// MTU
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
        /// <summary>
        /// edge path
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
        /// <summary>
        /// local addresses
        /// </summary>
        [JsonProperty(PropertyName = "local_addresses", Required = Required.AllowNull)]
        public IList<string> LocalAddresses { get; set; }
    }
}
