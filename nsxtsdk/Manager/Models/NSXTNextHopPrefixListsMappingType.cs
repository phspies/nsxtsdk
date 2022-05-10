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
    /// Next hop to prefix lists mapping.
    /// </summary>
    [NSXTProperty(Description: @"Next hop to prefix lists mapping.")]
    public class NSXTNextHopPrefixListsMappingType 
    {
        /// <summary>
        /// Array of Prefix list UUIDs.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_lists", Required = Required.AllowNull)]
        public IList<string> PrefixLists { get; set; }
        /// <summary>
        /// Next hop address.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop", Required = Required.AllowNull)]
        public string NextHop { get; set; }
    }
}
