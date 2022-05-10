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
    public class NSXTPolicyMulticastConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Replication multicast range. Required when enabled.
        /// </summary>
        [JsonProperty(PropertyName = "replication_multicast_range")]
        public string? ReplicationMulticastRange { get; set; }
        /// <summary>
        /// Updates to IGMP profile applied on all Tier0 gateways consuming the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_profile_path")]
        public string? IgmpProfilePath { get; set; }
        /// <summary>
        /// Updates to PIM profile applied on all Tier0 gateways consuming the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "pim_profile_path")]
        public string? PimProfilePath { get; set; }
        /// <summary>
        /// Enable/disable Multicast Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
