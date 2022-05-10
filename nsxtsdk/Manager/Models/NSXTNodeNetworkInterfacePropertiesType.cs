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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNodeNetworkInterfacePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Interface MAC address
        /// </summary>
        [JsonProperty(PropertyName = "physical_address")]
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Interface broadcast address
        /// </summary>
        [JsonProperty(PropertyName = "broadcast_address")]
        public string? BroadcastAddress { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "link_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesLinkStatusEnumType? LinkStatus { get; set; }
        /// <summary>
        /// Interface's default gateway
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// Bond's primary device name in active-backup bond mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_primary")]
        public string? BondPrimary { get; set; }
        /// <summary>
        /// Bond's slave devices
        /// </summary>
        [JsonProperty(PropertyName = "bond_slaves")]
        public IList<string> BondSlaves { get; set; }
        /// <summary>
        /// Interface IP addresses
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<NSXTIPv4AddressPropertiesType> IpAddresses { get; set; }
        /// <summary>
        /// VLAN Id
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "admin_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesAdminStatusEnumType? AdminStatus { get; set; }
        /// <summary>
        /// Bond's primary device name in active-backup bond mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_primary_slave")]
        public string? BondPrimarySlave { get; set; }
        /// <summary>
        /// Interface MTU
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public long? Mtu { get; set; }
        /// <summary>
        /// Bond mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesBondModeEnumType? BondMode { get; set; }
        /// <summary>
        /// Interface plane
        /// </summary>
        [JsonProperty(PropertyName = "plane")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesPlaneEnumType? Plane { get; set; }
        /// <summary>
        /// Bond's currently active slave device
        /// </summary>
        [JsonProperty(PropertyName = "bond_cur_active_slave")]
        public string? BondCurActiveSlave { get; set; }
        /// <summary>
        /// Interface is a KNI
        /// </summary>
        [JsonProperty(PropertyName = "is_kni")]
        public bool? IsKni { get; set; }
        /// <summary>
        /// Bond's rate at which we'll ask our link partner to transmit LACPDU packets in 802.3ad mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_lacp_rate")]
        public string? BondLacpRate { get; set; }
        /// <summary>
        /// Interface configuration
        /// </summary>
        [JsonProperty(PropertyName = "ip_configuration", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesIpConfigurationEnumType IpConfiguration { get; set; }
        /// <summary>
        /// Interface ID
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Bond's transmit hash policy for balance-xor and 802.3ad modes
        /// </summary>
        [JsonProperty(PropertyName = "bond_xmit_hash_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeNetworkInterfacePropertiesBondXmitHashPolicyEnumType? BondXmitHashPolicy { get; set; }
    }
}
