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
    /// Advanced load balancer Vip object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer Vip object")]
    public class NSXTALBVipType 
    {
        /// <summary>
        /// Manually override the network on which the Vip is placed.
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// Auto-allocate VIP from the provided subnet.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_ip")]
        public bool? AutoAllocateIp { get; set; }
        /// <summary>
        /// (internal-use) Network port assigned to the Vip IP address.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Availability-zone to place the Virtual Service.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "floating_ip")]
        public NSXTALBIpAddrType FloatingIp { get; set; }
        /// <summary>
        /// Auto-allocate floating/elastic IP from the Cloud
        /// infrastructure.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_floating_ip")]
        public bool? AutoAllocateFloatingIp { get; set; }
        /// <summary>
        /// If auto_allocate_floating_ip is True and more than one
        /// floating-ip subnets exist, then the subnet for the floating
        /// IP address allocation.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_subnet_uuid")]
        public string? FloatingSubnetUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public NSXTALBIpAddrType Ip6Address { get; set; }
        /// <summary>
        /// (internal-use) VIP allocated by Avi in the Cloud
        /// infrastructure.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_vip")]
        public bool? AviAllocatedVip { get; set; }
        /// <summary>
        /// Specifies whether to auto-allocate only a V4 address, only
        /// a V6 address, or one of each type.
        /// Enum options - V4_ONLY, V6_ONLY, V4_V6.
        /// Allowed in Basic(Allowed values- V4_ONLY) edition,
        /// Essentials(Allowed values- V4_ONLY) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as V4_ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_ip_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvipAutoAllocateIpTypeEnumType? AutoAllocateIpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// If auto_allocate_ip is True, then the subnet for the Vip IP
        /// address allocation.
        /// This field is applicable only if the VirtualService belongs
        /// to an Openstack or AWS cloud, in which case it is mandatory,
        /// if auto_allocate is selected.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_uuid")]
        public string? SubnetUuid { get; set; }
        /// <summary>
        /// If auto_allocate_floating_ip is True and more than one
        /// floating-ip subnets exist, then the subnet for the floating
        /// IPv6 address allocation.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_subnet6_uuid")]
        public string? FloatingSubnet6Uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// If auto_allocate_ip is True, then the subnet for the Vip
        /// IPv6 address allocation.
        /// This field is applicable only if the VirtualService belongs
        /// to an Openstack or AWS cloud, in which case it is mandatory,
        /// if auto_allocate is selected.
        /// Allowed in Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6_uuid")]
        public string? Subnet6Uuid { get; set; }
        /// <summary>
        /// Unique ID associated with the vip.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id", Required = Required.AllowNull)]
        public string VipId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "floating_ip6")]
        public NSXTALBIpAddrType FloatingIp6 { get; set; }
        /// <summary>
        /// (internal-use) FIP allocated by Avi in the Cloud
        /// infrastructure.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_fip")]
        public bool? AviAllocatedFip { get; set; }
        /// <summary>
        /// Discovered networks providing reachability for client
        /// facing Vip IP.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_networks")]
        public IList<NSXTALBDiscoveredNetworkType> DiscoveredNetworks { get; set; }
        /// <summary>
        /// Enable or disable the Vip.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ipam_network_subnet")]
        public NSXTALBIPNetworkSubnetType IpamNetworkSubnet { get; set; }
        /// <summary>
        /// Placement networks/subnets to use for vip placement.
        /// Maximum of 10 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "placement_networks")]
        public IList<NSXTALBVipPlacementNetworkType> PlacementNetworks { get; set; }
        /// <summary>
        /// Mask applied for the Vip, non-default mask supported only
        /// for wildcard Vip.
        /// Allowed values are 0-32.
        /// Allowed in Basic(Allowed values- 32) edition,
        /// Essentials(Allowed values- 32) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 32.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length")]
        public long? PrefixLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
    }
}
