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
    public class NSXTDhcpHeaderType 
    {
        /// <summary>
        /// This is used to specify the general type of message. A client sending request to a server uses an op code of
        /// BOOTREQUEST, while a server replying uses an op code of BOOTREPLY.
        /// </summary>
        [JsonProperty(PropertyName = "op_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDhcpHeaderOpCodeEnumType? OpCode { get; set; }
    }
}
