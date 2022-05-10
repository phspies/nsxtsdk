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
    public class NSXTIPProtocolServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol_number", Required = Required.AllowNull)]
        public long ProtocolNumber { get; set; }
    }
}
