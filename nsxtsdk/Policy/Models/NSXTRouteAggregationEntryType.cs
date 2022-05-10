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
    /// List of routes to be aggregated
    /// </summary>
    [NSXTProperty(Description: @"List of routes to be aggregated")]
    public class NSXTRouteAggregationEntryType 
    {
        /// <summary>
        /// Send only summarized route.
        /// Summarization reduces number of routes advertised by representing
        /// multiple related routes with prefix property.
        /// </summary>
        [JsonProperty(PropertyName = "summary_only")]
        public bool? SummaryOnly { get; set; }
        /// <summary>
        /// CIDR of aggregate address
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public string Prefix { get; set; }
    }
}
