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
    public class NSXTIpfixCollectorUpmProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// All IPFIX collector profile types.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpfixCollectorUpmProfileResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// IPFIX Collector Set
        /// </summary>
        [JsonProperty(PropertyName = "collectors", Required = Required.AllowNull)]
        public IList<NSXTIpfixCollectorType> Collectors { get; set; }
    }
}
