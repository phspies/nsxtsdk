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
    public class NSXTIPFIXL2CollectorType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IP address for the IPFIX L2 collector.
        /// IP addresses such as 0.0.0.0, 127.0.0.1, 255.255.255.255 are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip_address", Required = Required.AllowNull)]
        public string CollectorIpAddress { get; set; }
        /// <summary>
        /// Port number for the IPFIX L2 collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_port")]
        public int? CollectorPort { get; set; }
    }
}
