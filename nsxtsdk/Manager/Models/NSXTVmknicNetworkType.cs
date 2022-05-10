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
    /// Mapping of all vmk interfaces to destination networks
    /// </summary>
    [NSXTProperty(Description: @"Mapping of all vmk interfaces to destination networks")]
    public class NSXTVmknicNetworkType 
    {
        /// <summary>
        /// When migrating vmks to N-VDS/logical switches, the id is the logical switch id. When migrating out of N-VDS/logical
        /// switches, the id is the vSphere Switch portgroup name in a single vSphere Standard Switch (VSS), or distributed virtual
        /// portgroup name in a single distributed virtual switch (DVS).
        /// </summary>
        [JsonProperty(PropertyName = "destination_network", Required = Required.AllowNull)]
        public string DestinationNetwork { get; set; }
        /// <summary>
        /// The vmk interface name, e.g., vmk0, vmk1; the id assigned by vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "device_name", Required = Required.AllowNull)]
        public string DeviceName { get; set; }
    }
}
