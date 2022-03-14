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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbServiceStatisticsCounterType 
    {
        /// <summary>
        /// Number of l4 total sessions
        /// </summary>
        public long? L4TotalSessions { get; set; }
        /// <summary>
        /// Number of l7 current sessions
        /// </summary>
        public long? L7CurrentSessions { get; set; }
        /// <summary>
        /// L4 max sessions is used to show the peak L4 max session data since
        /// load balancer starts to provide service.
        /// </summary>
        public long? L4MaxSessions { get; set; }
        /// <summary>
        /// Number of l4 current sessions
        /// </summary>
        public long? L4CurrentSessions { get; set; }
        /// <summary>
        /// Number of l7 total sessions
        /// </summary>
        public long? L7TotalSessions { get; set; }
        /// <summary>
        /// The average number of l4 current sessions per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        public double? L4CurrentSessionRate { get; set; }
        /// <summary>
        /// The average number of l7 current requests per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        public double? L7CurrentSessionRate { get; set; }
        /// <summary>
        /// L7 max sessions is used to show the peak L7 max session data since
        /// load balancer starts to provide service.
        /// </summary>
        public long? L7MaxSessions { get; set; }
    }
}
