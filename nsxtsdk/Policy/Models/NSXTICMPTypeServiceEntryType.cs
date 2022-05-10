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
    public class NSXTICMPTypeServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// ICMP message code
        /// </summary>
        [JsonProperty(PropertyName = "icmp_code")]
        public long? IcmpCode { get; set; }
        /// <summary>
        /// ICMP message type
        /// </summary>
        [JsonProperty(PropertyName = "icmp_type")]
        public long? IcmpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIcmptypeServiceEntryProtocolEnumType Protocol { get; set; }
    }
}
