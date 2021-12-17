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
    public class NSXTBgpAddressFamilyType 
    {
        public NSXTBgpAddressFamilyType()
        {
        }
        /// <summary>
        /// Count of out prefixes
        /// </summary>
        [JsonProperty(PropertyName = "out_prefix_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of out prefixes")]
        public long? OutPrefixCount { get; set; }
        /// <summary>
        /// BGP address family type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"BGP address family type")]
        public NSXTBgpAddressFamilyTypeEnumType? Type { get; set; }
        /// <summary>
        /// Count of in prefixes
        /// </summary>
        [JsonProperty(PropertyName = "in_prefix_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of in prefixes")]
        public long? InPrefixCount { get; set; }
    }
}
