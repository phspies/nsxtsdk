// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRuleStatisticsType : NSXTResourceType
    {
        /// <summary>
        /// Aggregated number of sessions processed by all the rules
        /// This is aggregated statistic which are computed with lower
        /// frequency compared to individual generic rule  statistics.
        /// It may have a computation delay up to 15 minutes in
        /// response to this API.
        /// </summary>
        public long? TotalSessionCount { get; set; }
        /// <summary>
        /// This is calculated by sessions count divided by age of the rule.
        /// </summary>
        public long? PopularityIndex { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Accepted counters received by the rule.
        /// </summary>
        public long? L7AcceptCount { get; set; }
        /// <summary>
        /// Maximum value of sessions count of all rules of the type.
        /// This is aggregated statistic which are computed with lower
        /// frequency compared to generic rule statistics. It may have
        /// a computation delay up to 15 minutes in response to this API.
        /// </summary>
        public long? MaxSessionCount { get; set; }
        /// <summary>
        /// Aggregated number of bytes processed by the rule.
        /// </summary>
        public long? ByteCount { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Rejected with Response counters received by the rule.
        /// </summary>
        public long? L7RejectWithResponseCount { get; set; }
        /// <summary>
        /// Aggregated number of L7 Profile Rejected counters received by the rule.
        /// </summary>
        public long? L7RejectCount { get; set; }
        /// <summary>
        /// Aggregated number of sessions processed by the rule.
        /// </summary>
        public long? SessionCount { get; set; }
        /// <summary>
        /// Path of the rule.
        /// </summary>
        public string? Rule { get; set; }
        /// <summary>
        /// Aggregated number of packets processed by the rule.
        /// </summary>
        public long? PacketCount { get; set; }
        /// <summary>
        /// Realized id of the rule on NSX MP. Policy Manager can create more than
        /// one rule per policy rule, in which case this identifier helps to
        /// distinguish between the multple rules created.
        /// </summary>
        public string? InternalRuleId { get; set; }
        /// <summary>
        /// Aggregated number of hits received by the rule.
        /// </summary>
        public long? HitCount { get; set; }
        /// <summary>
        /// Path of the LR on which the section is applied in case of Edge FW.
        /// </summary>
        public string? LrPath { get; set; }
        /// <summary>
        /// Maximum value of popularity index of all rules of the type.
        /// This is aggregated statistic which are computed with lower
        /// frequency compared to individual generic rule statistics.
        /// It may have a computation delay up to 15 minutes in response
        /// to this API.
        /// </summary>
        public long? MaxPopularityIndex { get; set; }
    }
}
