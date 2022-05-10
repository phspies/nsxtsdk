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
    /// The DVS Configuration
    /// </summary>
    [NSXTProperty(Description: @"The DVS Configuration")]
    public class NSXTDVSConfigType 
    {
        /// <summary>
        /// The DVS name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// It contains information about VMware specific multiple dynamic LACP groups.
        /// </summary>
        [JsonProperty(PropertyName = "lacp_group_configs")]
        public IList<NSXTLacpGroupConfigInfoType> LacpGroupConfigs { get; set; }
        /// <summary>
        /// host_infra_traffic_res specifies bandwidth allocation for
        /// various traffic resources.
        /// </summary>
        [JsonProperty(PropertyName = "host_infra_traffic_res")]
        public IList<NSXTResourceAllocationType> HostInfraTrafficRes { get; set; }
        /// <summary>
        /// Names of uplink ports for this DVS.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_port_names", Required = Required.AllowNull)]
        public IList<string> UplinkPortNames { get; set; }
        /// <summary>
        /// The DVS uuid
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Enabled or disabled sending LLDP packets
        /// </summary>
        [JsonProperty(PropertyName = "lldp_send_enabled")]
        public bool? LldpSendEnabled { get; set; }
        /// <summary>
        /// Maximum Transmission Unit used for uplinks
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
    }
}
