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
    public class NSXTMirrorStackStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// SUCCESS if all the TN's stack status are SUCCESS,
        /// FAILED if some of the TN's stack status are FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "overall_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMirrorStackStatusListResultOverallStatusEnumType OverallStatus { get; set; }
        /// <summary>
        /// List all TN nodes which spaned in remote L3 mirror session mirror
        /// stack health status detailed info, including mirror stack status,
        /// vmknic status, TN node ID, TN node name and last updated status timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTTnNodeStackSpanStatusType> Results { get; set; }
    }
}
