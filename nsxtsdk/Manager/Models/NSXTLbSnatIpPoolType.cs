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
    public class NSXTLbSnatIpPoolType : NSXTLbSnatTranslationType
    {
        /// <summary>
        /// If an IP range is specified, the range may contain no more than 64
        /// IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<NSXTLbSnatIpElementType> IpAddresses { get; set; }
    }
}
