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
    public class NSXTDistributedVirtualPortgroupType : NSXTVirtualPortgroupType
    {
        /// <summary>
        /// This parameters reflects the managed entity status of the portgroup
        /// as reported by VC.
        /// </summary>
        [JsonProperty(PropertyName = "overall_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDistributedVirtualPortgroupOverallStatusEnumType? OverallStatus { get; set; }
        /// <summary>
        /// For distributed virtual portgroup, backing type is standard.
        /// For logical switch portgroup, the backing type is set to nsx.
        /// </summary>
        [JsonProperty(PropertyName = "backing_type")]
        public string? BackingType { get; set; }
        /// <summary>
        /// Generated UUID of the portgroup
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
    }
}
