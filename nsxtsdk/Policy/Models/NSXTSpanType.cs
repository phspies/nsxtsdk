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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSpanType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy resource type of the streached entity.
        /// </summary>
        [JsonProperty(PropertyName = "span_resource_type")]
        public string? SpanResourceType { get; set; }
        /// <summary>
        /// Represents Policy resource path of streached entity.
        /// </summary>
        [JsonProperty(PropertyName = "span_resource")]
        public string? SpanResource { get; set; }
        /// <summary>
        /// List of SpanSiteInfos representing the strech of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "sites")]
        public IList<NSXTSpanSiteInfoType> Sites { get; set; }
        /// <summary>
        /// Represents Policy resource type streached entity's span leader.
        /// </summary>
        [JsonProperty(PropertyName = "span_leader")]
        public string? SpanLeader { get; set; }
    }
}
