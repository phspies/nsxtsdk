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
    /// Detailed information about static address for the port.
    /// </summary>
    [NSXTProperty(Description: @"Detailed information about static address for the port.")]
    public class NSXTPortAddressBindingEntryType 
    {
        /// <summary>
        /// IP Address for port binding
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// VLAN ID for port binding
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public long? VlanId { get; set; }
        /// <summary>
        /// Mac address for port binding
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
    }
}
