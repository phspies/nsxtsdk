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
    public class NSXTL4PortSetServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// Number of values should not exceed 15, ranges count as 2 values.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ports")]
        public IList<string> DestinationPorts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "l4_protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL4PortSetServiceEntryL4ProtocolEnumType L4Protocol { get; set; }
        /// <summary>
        /// Number of values should not exceed 15, ranges count as 2 values.
        /// </summary>
        [JsonProperty(PropertyName = "source_ports")]
        public IList<string> SourcePorts { get; set; }
    }
}
