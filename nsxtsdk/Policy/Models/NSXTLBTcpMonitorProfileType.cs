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
    public class NSXTLBTcpMonitorProfileType : NSXTLBActiveMonitorType
    {
        /// <summary>
        /// Expected data, if specified, can be anywhere in the response and it has
        /// to be a string, regular expressions are not supported.
        /// </summary>
        [JsonProperty(PropertyName = "receive")]
        public string? Receive { get; set; }
        /// <summary>
        /// If both send and receive are not specified, then just a TCP connection
        /// is established (3-way handshake) to validate server is healthy, no
        /// data is sent.
        /// </summary>
        [JsonProperty(PropertyName = "send")]
        public string? Send { get; set; }
    }
}
