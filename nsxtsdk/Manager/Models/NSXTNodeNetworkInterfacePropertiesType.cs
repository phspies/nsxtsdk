// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Interface MAC address")]
        public string? PhysicalAddress { get; set; }
        /// <summary>
        /// Interface broadcast address
        /// </summary>
        [JsonProperty(PropertyName = "broadcast_address")]
        [NSXTProperty(IsRequired: false, Description: @"Interface broadcast address")]
        public string? BroadcastAddress { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "link_status")]
        [NSXTProperty(IsRequired: false, Description: @"Interface administration status")]
        public NSXTNodeNetworkInterfacePropertiesLinkStatusEnumType? LinkStatus { get; set; }
        /// <summary>
        /// Interface's default gateway
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        [NSXTProperty(IsRequired: false, Description: @"Interface&apos;s default gateway")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// Bond's primary device name in active-backup bond mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_primary")]
        [NSXTProperty(IsRequired: false, Description: @"Bond&apos;s primary device name in active-backup bond mode")]
        public string? BondPrimary { get; set; }
        /// <summary>
        /// Bond's slave devices
        /// </summary>
        [JsonProperty(PropertyName = "bond_slaves")]
        [NSXTProperty(IsRequired: false, Description: @"Bond&apos;s slave devices")]
        public IList<string> BondSlaves { get; set; }
        /// <summary>
        /// Interface IP addresses
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"Interface IP addresses")]
        public IList<NSXTIPv4AddressPropertiesType> IpAddresses { get; set; }
        /// <summary>
        /// VLAN Id
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        [NSXTProperty(IsRequired: false, Description: @"VLAN Id")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4094)]
        public long? Vlan { get; set; }
        /// <summary>
        /// Bond mode
        /// </summary>
        [JsonProperty(PropertyName = "bond_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Bond mode")]
        public NSXTNodeNetworkInterfacePropertiesBondModeEnumType? BondMode { get; set; }
        /// <summary>
        /// Interface ID
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        [NSXTProperty(IsRequired: false, Description: @"Interface ID")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Interface administration status
        /// </summary>
        [JsonProperty(PropertyName = "admin_status")]
        [NSXTProperty(IsRequired: false, Description: @"Interface administration status")]
        public NSXTNodeNetworkInterfacePropertiesAdminStatusEnumType? AdminStatus { get; set; }
        /// <summary>
        /// Interface plane
        /// </summary>
        [JsonProperty(PropertyName = "plane")]
        [NSXTProperty(IsRequired: false, Description: @"Interface plane")]
        public NSXTNodeNetworkInterfacePropertiesPlaneEnumType? Plane { get; set; }
        /// <summary>
        /// Interface is a KNI
        /// </summary>
        [JsonProperty(PropertyName = "is_kni")]
        [NSXTProperty(IsRequired: false, Description: @"Interface is a KNI")]
        public bool? IsKni { get; set; }
        /// <summary>
        /// Interface configuration
        /// </summary>
        [JsonProperty(PropertyName = "ip_configuration", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Interface configuration")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTNodeNetworkInterfacePropertiesIpConfigurationEnumType IpConfiguration { get; set; }
        /// <summary>
        /// Interface MTU
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        [NSXTProperty(IsRequired: false, Description: @"Interface MTU")]
        public long? Mtu { get; set; }
    }
}
