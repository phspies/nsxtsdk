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
    public class NSXTLBActiveMonitorType : NSXTLBMonitorProfileType
    {
        /// <summary>
        /// Typically, monitors perform healthchecks to Group members using the
        /// member IP address and pool_port.
        /// However, in some cases, customers prefer to run healthchecks against a
        /// different port than the pool member port which handles actual
        /// application traffic. In such cases, the port to run healthchecks
        /// against can be specified in the monitor_port value.
        /// For ICMP monitor, monitor_port is not required.
        /// </summary>
        [JsonProperty(PropertyName = "monitor_port")]
        public int? MonitorPort { get; set; }
        /// <summary>
        /// Only if a healthcheck fails consecutively for a specified number of
        /// times, given with fall_count, to a member will the member status be
        /// marked DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "fall_count")]
        public long? FallCount { get; set; }
        /// <summary>
        /// Active healthchecks are initiated periodically, at a configurable
        /// interval (in seconds), to each member of the Group.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public long? Interval { get; set; }
        /// <summary>
        /// Once a member is DOWN, a specified number of consecutive successful
        /// healthchecks specified by rise_count will bring the member back to UP
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "rise_count")]
        public long? RiseCount { get; set; }
        /// <summary>
        /// Timeout specified in seconds.  After a healthcheck is initiated, if it
        /// does not complete within a certain period, then also the healthcheck
        /// is considered to be unsuccessful. Completing a healthcheck within
        /// timeout means establishing a connection (TCP or SSL), if applicable,
        /// sending the request and receiving the response, all within the
        /// configured timeout.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
    }
}
