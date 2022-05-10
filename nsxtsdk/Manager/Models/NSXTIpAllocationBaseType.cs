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
    public class NSXTIpAllocationBaseType : NSXTManagedResourceType
    {
        /// <summary>
        /// Lease time, in seconds, [60-(2^32-1)]. Default is 86400.
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public long? LeaseTime { get; set; }
        /// <summary>
        /// Gateway ip address of the allocation.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        public string? GatewayIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public NSXTDhcpOptionsType Options { get; set; }
    }
}
