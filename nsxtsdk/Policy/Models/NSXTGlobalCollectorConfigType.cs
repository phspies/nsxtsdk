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
    /// The GlobalCollectorConfig is the base class for global collector configurations for
        /// different types in a NSX domain.
    /// </summary>
    [NSXTProperty(Description: @"The GlobalCollectorConfig is the base class for global collector configurations fordifferent types in a NSX domain.")]
    public class NSXTGlobalCollectorConfigType 
    {
        /// <summary>
        /// Port for the global collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_port", Required = Required.AllowNull)]
        public int CollectorPort { get; set; }
        /// <summary>
        /// Specify the global collector type.
        /// </summary>
        [JsonProperty(PropertyName = "collector_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGlobalCollectorConfigCollectorTypeEnumType CollectorType { get; set; }
        /// <summary>
        /// IP address for the global collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip", Required = Required.AllowNull)]
        public string CollectorIp { get; set; }
    }
}
