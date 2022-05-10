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
    public class NSXTBinaryPacketDataType : NSXTPacketDataType
    {
        /// <summary>
        /// Up to 1000 bytes of payload may be supplied (with a base64-encoded length of 1336 bytes.) Additional bytes of traceflow
        /// metadata will be appended to the payload. The payload must contain all headers (Ethernet, IP, etc). Note that VLAN is
        /// not supported in the logical space. Hence, payload must not contain 802.1Q headers.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public string? Payload { get; set; }
    }
}
