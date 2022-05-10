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
    public class NSXTLbIcmpMonitorType : NSXTLbActiveMonitorType
    {
        /// <summary>
        /// The data size(in byte) of the ICMP healthcheck packet
        /// </summary>
        [JsonProperty(PropertyName = "data_length")]
        public long? DataLength { get; set; }
    }
}
