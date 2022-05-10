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
    /// Information of a network interface present on the partner appliance that needs to be configured by the NSX Manager.
    /// </summary>
    [NSXTProperty(Description: @"Information of a network interface present on the partner appliance that needs to be configured by the NSX Manager.")]
    public class NSXTNicInfoType 
    {
        /// <summary>
        /// Subnet mask associated with the NIC metadata.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask")]
        public string? SubnetMask { get; set; }
        /// <summary>
        /// Gateway address associated with the NIC metadata.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_address")]
        public string? GatewayAddress { get; set; }
        /// <summary>
        /// IP allocation type with values STATIC, DHCP, or NONE indicating that IP address is not required.
        /// </summary>
        [JsonProperty(PropertyName = "ip_allocation_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNicInfoIpAllocationTypeEnumType? IpAllocationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "nic_metadata")]
        public NSXTNicMetadataType NicMetadata { get; set; }
        /// <summary>
        /// Network Id associated with the NIC metadata. It can be a moref, or a logical switch ID. If it is to be taken from 'Agent
        /// VM Settings', then it should be empty.
        /// </summary>
        [JsonProperty(PropertyName = "network_id")]
        public string? NetworkId { get; set; }
        /// <summary>
        /// If the nic should get IP using a static IP pool then IP pool id should be provided here.
        /// </summary>
        [JsonProperty(PropertyName = "ip_pool_id")]
        public string? IpPoolId { get; set; }
        /// <summary>
        /// IP address associated with the NIC metadata. Required only when assigning IP statically for a deployment that is for a
        /// single VM instance.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
