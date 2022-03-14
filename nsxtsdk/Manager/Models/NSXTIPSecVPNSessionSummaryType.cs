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
    /// Summarized view of all selected IPSec VPN sessions.
    /// </summary>
    [NSXTProperty(Description: @"Summarized view of all selected IPSec VPN sessions.")]
    public class NSXTIPSecVPNSessionSummaryType 
    {
        /// <summary>
        /// Traffic summary per session.
        /// </summary>
        public IList<NSXTIPSecVPNSessionTrafficSummaryType> TrafficSummaryPerSession { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPsecVPNIKESessionSummaryType SessionSummary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTIPSecVPNTrafficCountersType AggregateTrafficCounters { get; set; }
    }
}
