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
    public class NSXTBgpRouteAggregationType 
    {
        /// <summary>
        /// Flag to send only summarized route
        /// </summary>
        [JsonProperty(PropertyName = "summary_only")]
        public bool? SummaryOnly { get; set; }
        /// <summary>
        /// cidr of the aggregate address
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public string Prefix { get; set; }
    }
}
