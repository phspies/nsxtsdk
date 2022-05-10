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
    /// Configuration field to hold BGP restart timers
    /// </summary>
    [NSXTProperty(Description: @"Configuration field to hold BGP restart timers")]
    public class NSXTBgpGracefulRestartTimerType 
    {
        /// <summary>
        /// Maximum time taken (in seconds) for a BGP session to be established after a restart.
        /// This can be used to speed up routing convergence by its peer in case the BGP speaker
        /// does not come back up after a restart. If the session is not re-established within this
        /// timer,  the receiving speaker will delete all the stale routes from that peer.
        /// </summary>
        [JsonProperty(PropertyName = "restart_timer")]
        public long? RestartTimer { get; set; }
        /// <summary>
        /// Maximum time (in seconds) before stale routes are removed from the
        /// RIB (Routing Information Base) when BGP restarts.
        /// </summary>
        [JsonProperty(PropertyName = "stale_route_timer")]
        public long? StaleRouteTimer { get; set; }
    }
}
