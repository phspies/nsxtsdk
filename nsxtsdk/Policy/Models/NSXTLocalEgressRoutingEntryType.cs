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
    /// Local egress routing policy
    /// </summary>
    [NSXTProperty(Description: @"Local egress routing policy")]
    public class NSXTLocalEgressRoutingEntryType 
    {
        /// <summary>
        /// Next hop address for proximity routing.
        /// </summary>
        [JsonProperty(PropertyName = "nexthop_address", Required = Required.AllowNull)]
        public string NexthopAddress { get; set; }
        /// <summary>
        /// The destination address of traffic matching a prefix-list is forwarded
        /// to the nexthop_address. Traffic matching a prefix list with Action
        /// DENY will be dropped.
        /// Individual prefix-lists specified could have different actions.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_list_paths", Required = Required.AllowNull)]
        public IList<string> PrefixListPaths { get; set; }
    }
}
