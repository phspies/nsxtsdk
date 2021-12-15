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
    public class NSXTFirewallStatsType : NSXTResourceType
    {
        /// <summary>
        /// Aggregated number of sessions processed by the all firewall rules. This is aggregated statistic which are computed with
        /// lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in
        /// response to this API.
        /// </summary>
        [JsonProperty(PropertyName = "total_session_count")]
        [NSXTProperty(IsRequired: false, Description: @"Aggregated number of sessions processed by the all firewall rules. This is aggregated statistic which are computed with lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in response to this API.")]
        public long? TotalSessionCount { get; set; }
        /// <summary>
        /// Aggregated number of packets processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "packet_count")]
        [NSXTProperty(IsRequired: false, Description: @"Aggregated number of packets processed by the rule.")]
        public long? PacketCount { get; set; }
        /// <summary>
        /// This is calculated by sessions count divided by age of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "popularity_index")]
        [NSXTProperty(IsRequired: false, Description: @"This is calculated by sessions count divided by age of the rule.")]
        public long? PopularityIndex { get; set; }
        /// <summary>
        /// Maximum value of sessions count of all firewall rules of the type. This is aggregated statistic which are computed with
        /// lower frequency compared to generic rule statistics. It may have a computation delay up to 15 minutes in response to
        /// this API.
        /// </summary>
        [JsonProperty(PropertyName = "max_session_count")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum value of sessions count of all firewall rules of the type. This is aggregated statistic which are computed with lower frequency compared to generic rule statistics. It may have a computation delay up to 15 minutes in response to this API.")]
        public long? MaxSessionCount { get; set; }
        /// <summary>
        /// Aggregated number of bytes processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "byte_count")]
        [NSXTProperty(IsRequired: false, Description: @"Aggregated number of bytes processed by the rule.")]
        public long? ByteCount { get; set; }
        /// <summary>
        /// Maximum value of popularity index of all firewall rules of the type. This is aggregated statistic which are computed
        /// with lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in
        /// response to this API.
        /// </summary>
        [JsonProperty(PropertyName = "max_popularity_index")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum value of popularity index of all firewall rules of the type. This is aggregated statistic which are computed with lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in response to this API.")]
        public long? MaxPopularityIndex { get; set; }
        /// <summary>
        /// Aggregated number of hits received by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "hit_count")]
        [NSXTProperty(IsRequired: false, Description: @"Aggregated number of hits received by the rule.")]
        public long? HitCount { get; set; }
        /// <summary>
        /// Aggregated number of sessions processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "session_count")]
        [NSXTProperty(IsRequired: false, Description: @"Aggregated number of sessions processed by the rule.")]
        public long? SessionCount { get; set; }
        /// <summary>
        /// Rule Identifier of the Firewall rule. This is a globally unique number.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"Rule Identifier of the Firewall rule. This is a globally unique number.")]
        public string? RuleId { get; set; }
    }
}
