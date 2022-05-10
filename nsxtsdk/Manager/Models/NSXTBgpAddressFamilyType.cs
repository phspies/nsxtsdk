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
    public class NSXTBgpAddressFamilyType 
    {
        /// <summary>
        /// Count of out prefixes
        /// </summary>
        [JsonProperty(PropertyName = "out_prefix_count")]
        public long? OutPrefixCount { get; set; }
        /// <summary>
        /// BGP address family type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpAddressFamilyTypeEnumType? Type { get; set; }
        /// <summary>
        /// Count of in prefixes
        /// </summary>
        [JsonProperty(PropertyName = "in_prefix_count")]
        public long? InPrefixCount { get; set; }
    }
}
