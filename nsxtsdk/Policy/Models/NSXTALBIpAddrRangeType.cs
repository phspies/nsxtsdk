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
    /// Advanced load balancer IpAddrRange object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddrRange object")]
    public class NSXTALBIpAddrRangeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "begin", Required = Required.AllowNull)]
        public NSXTALBIpAddrType Begin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public NSXTALBIpAddrType End { get; set; }
    }
}
