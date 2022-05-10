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
    public class NSXTIpfixCollectorType 
    {
        /// <summary>
        /// IP address for the IPFIX collector
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip_address", Required = Required.AllowNull)]
        public string CollectorIpAddress { get; set; }
        /// <summary>
        /// Port for the IPFIX collector
        /// </summary>
        [JsonProperty(PropertyName = "collector_port")]
        public int? CollectorPort { get; set; }
    }
}
