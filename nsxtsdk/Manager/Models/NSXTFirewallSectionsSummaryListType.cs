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
    public class NSXTFirewallSectionsSummaryListType 
    {
        /// <summary>
        /// Timestamp of the last computation, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "last_compute_time")]
        public long? LastComputeTime { get; set; }
        /// <summary>
        /// List of firewall sections summary.
        /// </summary>
        [JsonProperty(PropertyName = "sections_summary")]
        public IList<NSXTFirewallSectionsSummaryType> SectionsSummary { get; set; }
    }
}
