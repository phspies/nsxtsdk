// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? IcmpCode { get; set; }
        /// <summary>
        /// ICMP message type
        /// </summary>
        public long? IcmpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        public NSXTIcmptypeServiceEntryProtocolEnumType Protocol { get; set; }
    }
}
