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
    public class NSXTIPFIXDFWCollectorType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IP address for the IPFIX DFW collector.
        /// IP addresses such as 0.0.0.0, 127.0.0.1, 255.255.255.255 are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip_address", Required = Required.AllowNull)]
        public string CollectorIpAddress { get; set; }
        /// <summary>
        /// Port for the IPFIX DFW collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_port", Required = Required.AllowNull)]
        public int CollectorPort { get; set; }
    }
}
