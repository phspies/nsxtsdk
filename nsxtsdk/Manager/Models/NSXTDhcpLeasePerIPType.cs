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
    public class NSXTDhcpLeasePerIPType 
    {
        /// <summary>
        /// subnet of client network
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
        /// <summary>
        /// lease time of the ip address, in seconds
        /// </summary>
        [JsonProperty(PropertyName = "lease_time")]
        public string? LeaseTime { get; set; }
        /// <summary>
        /// mac address of client
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
        /// <summary>
        /// expire time of the lease
        /// </summary>
        [JsonProperty(PropertyName = "expire_time")]
        public string? ExpireTime { get; set; }
        /// <summary>
        /// start time of lease
        /// </summary>
        [JsonProperty(PropertyName = "start_time", Required = Required.AllowNull)]
        public string StartTime { get; set; }
        /// <summary>
        /// ip address of client
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
    }
}
