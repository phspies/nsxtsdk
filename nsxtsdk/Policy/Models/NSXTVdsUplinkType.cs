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
    /// If Virtual Distributed Switch is used as a HostSwitch to configure TransportNode or TransportNodeProfie, this mapping
        /// should be specified. You can either use vds_uplink_name or vds_lag_name to associate with uplink_name from
        /// UplinkHostSwitch profile.
    /// </summary>
    [NSXTProperty(Description: @"If Virtual Distributed Switch is used as a HostSwitch to configure TransportNode or TransportNodeProfie, this mapping should be specified. You can either use vds_uplink_name or vds_lag_name to associate with uplink_name from UplinkHostSwitch profile.")]
    public class NSXTVdsUplinkType 
    {
        /// <summary>
        /// Uplink name of VDS that is connected to Physical NIC on a host from vSphere.
        /// </summary>
        [JsonProperty(PropertyName = "vds_uplink_name")]
        public string? VdsUplinkName { get; set; }
        /// <summary>
        /// This name is from UplinkHostSwitch profile that is associated with the HostSwitch specified in TransportNode or
        /// TransportNodeProfile configuration. This name will be used as an alias to either VDS uplink or lag in other
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name", Required = Required.AllowNull)]
        public string UplinkName { get; set; }
        /// <summary>
        /// LAG name that is connected to Physical NIC on a host from vSphere.
        /// </summary>
        [JsonProperty(PropertyName = "vds_lag_name")]
        public string? VdsLagName { get; set; }
    }
}
