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
    public class NSXTFirewallStatsType : NSXTResourceType
    {
        /// <summary>
        /// Aggregated number of sessions processed by the all firewall rules. This is aggregated statistic which are computed with
        /// lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in
        /// response to this API.
        /// </summary>
        [JsonProperty(PropertyName = "total_session_count")]
        public long? TotalSessionCount { get; set; }
        /// <summary>
        /// This is calculated by sessions count divided by age of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "popularity_index")]
        public long? PopularityIndex { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Accepted counters received by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "l7_accept_count")]
        public long? L7AcceptCount { get; set; }
        /// <summary>
        /// Maximum value of sessions count of all firewall rules of the type. This is aggregated statistic which are computed with
        /// lower frequency compared to generic rule statistics. It may have a computation delay up to 15 minutes in response to
        /// this API.
        /// </summary>
        [JsonProperty(PropertyName = "max_session_count")]
        public long? MaxSessionCount { get; set; }
        /// <summary>
        /// Aggregated number of bytes processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "byte_count")]
        public long? ByteCount { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Rejected with Response counters received by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "l7_reject_with_response_count")]
        public long? L7RejectWithResponseCount { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Rejected counters received by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "l7_reject_count")]
        public long? L7RejectCount { get; set; }
        /// <summary>
        /// Aggregated number of sessions processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "session_count")]
        public long? SessionCount { get; set; }
        /// <summary>
        /// Aggregated number of packets processed by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "packet_count")]
        public long? PacketCount { get; set; }
        /// <summary>
        /// Aggregated number of hits received by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "hit_count")]
        public long? HitCount { get; set; }
        /// <summary>
        /// Maximum value of popularity index of all firewall rules of the type. This is aggregated statistic which are computed
        /// with lower frequency compared to individual generic rule statistics. It may have a computation delay up to 15 minutes in
        /// response to this API.
        /// </summary>
        [JsonProperty(PropertyName = "max_popularity_index")]
        public long? MaxPopularityIndex { get; set; }
        /// <summary>
        /// Rule Identifier of the Firewall rule. This is a globally unique number.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public string? RuleId { get; set; }
    }
}
