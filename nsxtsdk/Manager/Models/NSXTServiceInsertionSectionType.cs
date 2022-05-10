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
    public class NSXTServiceInsertionSectionType : NSXTDSSectionType
    {
        /// <summary>
        /// Ensures that a three way TCP handshake is done before the data packets are sent if the value is set to be true.
        /// tcp_strict=true is supported only for stateful sections.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_strict")]
        public bool? TcpStrict { get; set; }
    }
}
