// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTL4PortSetNSServiceType : NSXTNSServiceElementType
    {
        /// <summary>
        /// Number of values should not exceed 15, ranges count as 2 values.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Number of values should not exceed 15, ranges count as 2 values.")]
        public IList<string> DestinationPorts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "l4_protocol", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTL4PortSetNsserviceL4ProtocolEnumType L4Protocol { get; set; }
        /// <summary>
        /// Number of values should not exceed 15, ranges count as 2 values.
        /// </summary>
        [JsonProperty(PropertyName = "source_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Number of values should not exceed 15, ranges count as 2 values.")]
        public IList<string> SourcePorts { get; set; }
    }
}
