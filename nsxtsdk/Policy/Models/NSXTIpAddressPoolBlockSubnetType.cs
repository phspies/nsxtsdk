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
    public class NSXTIpAddressPoolBlockSubnetType : NSXTIpAddressPoolSubnetType
    {
        /// <summary>
        /// The path of the IpAddressBlock from which the subnet is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "ip_block_path", Required = Required.AllowNull)]
        public string IpBlockPath { get; set; }
        /// <summary>
        /// For internal system use Only. Represents start ip address of the subnet from IP block. Subnet ip adddress will start
        /// from this ip address.
        /// </summary>
        [JsonProperty(PropertyName = "start_ip")]
        public string? StartIp { get; set; }
        /// <summary>
        /// If this property is set to true, the first IP in the range will be reserved for gateway.
        /// </summary>
        [JsonProperty(PropertyName = "auto_assign_gateway")]
        public bool? AutoAssignGateway { get; set; }
        /// <summary>
        /// The size parameter is required for subnet creation. It must be specified during creation but cannot be changed later.
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
    }
}
