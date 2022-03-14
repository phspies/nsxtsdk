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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Session statistics gives aggregated statistics of all policies for all the tunnels.
    /// </summary>
    [NSXTProperty(Description: @"Session statistics gives aggregated statistics of all policies for all the tunnels.")]
    public class NSXTIPSecVPNSessionStatisticsType 
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVPNIKETrafficStatisticsType IkeTrafficStatistics { get; set; }
        /// <summary>
        /// Display name of vpn session.
        /// </summary>
        public string? DisplayName { get; set; }
        /// <summary>
        /// Gives aggregate traffic statistics across all ipsec tunnels and individual tunnel statistics.
        /// </summary>
        public IList<NSXTIPSecVPNPolicyTrafficStatisticsType> PolicyStatistics { get; set; }
        /// <summary>
        /// Partial statistics if true specifies that the statistics are only from active node.
        /// </summary>
        public bool? PartialStats { get; set; }
        /// <summary>
        /// UUID of vpn session.
        /// </summary>
        public string? IpsecVpnSessionId { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVPNIKESessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
