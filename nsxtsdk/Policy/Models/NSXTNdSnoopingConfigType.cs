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
    /// Contains Neighbor Discovery Protocol (ND) snooping related configuration.
    /// </summary>
    [NSXTProperty(Description: @"Contains Neighbor Discovery Protocol (ND) snooping related configuration.")]
    public class NSXTNdSnoopingConfigType 
    {
        /// <summary>
        /// Maximum number of ND (Neighbor Discovery Protocol) snooped IPv6 addresses
        /// </summary>
        [JsonProperty(PropertyName = "nd_snooping_limit")]
        public int? NdSnoopingLimit { get; set; }
        /// <summary>
        /// Enable this method will snoop the NS (Neighbor Solicitation) and NA
        /// (Neighbor Advertisement) messages in the ND (Neighbor Discovery Protocol)
        /// family of messages which are transmitted by a VM. From the NS messages,
        /// we will learn about the source which sent this NS message. From the
        /// NA message, we will learn the resolved address in the message which
        /// the VM is a recipient of. Addresses snooped by this method are
        /// subject to TOFU (Trust on First Use) policies as enforced by the system.
        /// </summary>
        [JsonProperty(PropertyName = "nd_snooping_enabled")]
        public bool? NdSnoopingEnabled { get; set; }
    }
}
