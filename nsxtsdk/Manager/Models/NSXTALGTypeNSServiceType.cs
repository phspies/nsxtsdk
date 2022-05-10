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
    public class NSXTALGTypeNSServiceType : NSXTNSServiceElementType
    {
        /// <summary>
        /// The Application Layer Gateway (ALG) protocol.
        /// Please note, protocol NBNS_BROADCAST and NBDG_BROADCAST are  deprecated.
        /// Please use UDP protocol and create L4 Port Set type of service instead.
        /// </summary>
        [JsonProperty(PropertyName = "alg", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlgtypeNsserviceAlgEnumType Alg { get; set; }
        /// <summary>
        /// The destination_port cannot be empty and must be a single value.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ports", Required = Required.AllowNull)]
        public IList<string> DestinationPorts { get; set; }
        /// <summary>
        /// Source ports
        /// </summary>
        [JsonProperty(PropertyName = "source_ports")]
        public IList<string> SourcePorts { get; set; }
    }
}
