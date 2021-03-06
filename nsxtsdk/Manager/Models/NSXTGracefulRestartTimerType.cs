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
    /// BGP Graceful Restart timers configuration
    /// </summary>
    [NSXTProperty(Description: @"BGP Graceful Restart timers configuration")]
    public class NSXTGracefulRestartTimerType 
    {
        /// <summary>
        /// Maximum time BGP speaker will take for the BGP session to be
        /// re-established after a restart. Ranges from 1 sec to 3600 sec.
        /// This can be used to speed up routing convergence by its peer in
        /// case that the BGP speaker does not come back after a restart.
        /// If the session does not get re-established within the "Restart Time"
        /// that the Restarting Speaker advertised previously, the Receiving
        /// Speaker will delete all the stale routes from that peer.
        /// </summary>
        [JsonProperty(PropertyName = "restart_timer")]
        public long? RestartTimer { get; set; }
        /// <summary>
        /// Maximum time before stale routes are removed from the RIB when the
        /// local BGP process restarts. Ranges from 1 sec to 3600 sec.
        /// </summary>
        [JsonProperty(PropertyName = "stale_timer")]
        public long? StaleTimer { get; set; }
    }
}
