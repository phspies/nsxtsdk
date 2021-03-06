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
    public class NSXTIpBlockSubnetType : NSXTManagedResourceType
    {
        /// <summary>
        /// For internal system use Only. Represents start ip address of the subnet from IP block. Subnet ip adddress will start
        /// from this ip address.
        /// </summary>
        [JsonProperty(PropertyName = "start_ip")]
        public string? StartIp { get; set; }
        /// <summary>
        /// Represents network address and the prefix length which will be associated with a layer-2 broadcast domain
        /// </summary>
        [JsonProperty(PropertyName = "cidr")]
        public string? Cidr { get; set; }
        /// <summary>
        /// A collection of IPv4/IPv6 IP ranges used for IP allocation.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_ranges")]
        public IList<NSXTIpPoolRangeType> AllocationRanges { get; set; }
        /// <summary>
        /// Block id for which the subnet is created.
        /// </summary>
        [JsonProperty(PropertyName = "block_id", Required = Required.AllowNull)]
        public string BlockId { get; set; }
        /// <summary>
        /// Represents the size or number of ip addresses in the subnet
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
    }
}
