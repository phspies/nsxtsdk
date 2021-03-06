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
    public class NSXTIPProtocolNSServiceType : NSXTNSServiceElementType
    {
        /// <summary>
        /// The IP protocol number
        /// </summary>
        [JsonProperty(PropertyName = "protocol_number", Required = Required.AllowNull)]
        public long ProtocolNumber { get; set; }
    }
}
