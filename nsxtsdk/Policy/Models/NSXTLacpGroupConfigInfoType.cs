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
    public class NSXTLacpGroupConfigInfoType 
    {
        /// <summary>
        /// The key represents the identifier for the group that is unique
        /// across VC.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// The display name of the LACP group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Keys for the uplink ports in the group. Each uplink port is
        /// assigned a key that is unique across VC.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_port_keys")]
        public IList<string> UplinkPortKeys { get; set; }
        /// <summary>
        /// To set the lag mode as fast for LACP. By default, it will be slow.
        /// </summary>
        [JsonProperty(PropertyName = "timeout_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLacpGroupConfigInfoTimeoutTypeEnumType? TimeoutType { get; set; }
        /// <summary>
        /// Load balance algorithm used in LACP group. The possible values
        /// are dictated by the values available in VC. Please refer
        /// VMwareDvsLacpLoadBalanceAlgorithm documentation for a full list
        /// of values. A few examples are srcDestIp where source and destination
        /// IP are considered, srcIp where only source IP is considered.
        /// </summary>
        [JsonProperty(PropertyName = "load_balance_algorithm")]
        public string? LoadBalanceAlgorithm { get; set; }
        /// <summary>
        /// The number of uplink ports
        /// </summary>
        [JsonProperty(PropertyName = "uplink_num")]
        public long? UplinkNum { get; set; }
        /// <summary>
        /// Names for the uplink ports in the group.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_names")]
        public IList<string> UplinkNames { get; set; }
        /// <summary>
        /// The mode of LACP can be ACTIVE or PASSIVE. If the mode is ACTIVE, LACP
        /// is enabled unconditionally. If the mode is PASSIVE, LACP is enabled
        /// only if LACP device is detected.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLacpGroupConfigInfoModeEnumType? Mode { get; set; }
    }
}
