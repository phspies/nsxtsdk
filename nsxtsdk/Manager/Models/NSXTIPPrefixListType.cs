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
    public class NSXTIPPrefixListType : NSXTManagedResourceType
    {
        /// <summary>
        /// Ordered list of PrefixConfig
        /// </summary>
        [JsonProperty(PropertyName = "prefixes", Required = Required.AllowNull)]
        public IList<NSXTPrefixConfigType> Prefixes { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
    }
}
