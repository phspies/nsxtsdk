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
    public class NSXTIPSecVpnSessionStatisticsType : NSXTL3VpnStatisticsPerEnforcementPointType
    {
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVpnIkeTrafficStatisticsType IkeTrafficStatistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVpnIkeSessionStatusType IkeStatus { get; set; }
        /// <summary>
        /// Gives aggregate traffic statistics across all ipsec tunnels and individual tunnel
        /// statistics.
        /// </summary>
        public IList<NSXTIPSecVpnPolicyTrafficStatisticsType> PolicyStatistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVpnTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
