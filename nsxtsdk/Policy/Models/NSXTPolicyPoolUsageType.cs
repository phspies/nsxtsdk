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
    /// IP usage statistics in a IpAddressPool.
    /// </summary>
    [NSXTProperty(Description: @"IP usage statistics in a IpAddressPool.")]
    public class NSXTPolicyPoolUsageType 
    {
        /// <summary>
        /// Total number of requested IP allocations in a IpAddressPool
        /// </summary>
        [JsonProperty(PropertyName = "requested_ip_allocations")]
        public long? RequestedIpAllocations { get; set; }
        /// <summary>
        /// Total number of allocated IPs shown are from NSX manager.
        /// NSX manager uses default release delay of 2 mins. Till this delay passes,
        /// IPs will be shown as allocated (and counted in allocated ips).
        /// In this period of time there could be mismatch in requested_ip_allocations
        /// and allocated_ip_allocations.
        /// </summary>
        [JsonProperty(PropertyName = "allocated_ip_allocations")]
        public long? AllocatedIpAllocations { get; set; }
        /// <summary>
        /// Total number of available IPs in a IpAddressPool
        /// </summary>
        [JsonProperty(PropertyName = "available_ips")]
        public long? AvailableIps { get; set; }
        /// <summary>
        /// Total number of IPs in a IpAddressPool
        /// </summary>
        [JsonProperty(PropertyName = "total_ips")]
        public long? TotalIps { get; set; }
    }
}
