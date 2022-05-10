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
    public class NSXTBaseTier0InterfaceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specify IP address and network prefix for interface.
        /// </summary>
        [JsonProperty(PropertyName = "subnets", Required = Required.AllowNull)]
        public IList<NSXTInterfaceSubnetType> Subnets { get; set; }
        /// <summary>
        /// Policy path of dhcp-relay-config to be attached to this Interface.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_relay_path")]
        public string? DhcpRelayPath { get; set; }
    }
}
