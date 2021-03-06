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
    /// Standby service contexts relocation setting
    /// </summary>
    [NSXTProperty(Description: @"Standby service contexts relocation setting")]
    public class NSXTStandbyRelocationConfigType 
    {
        /// <summary>
        /// The time interval (in minutes) to wait before starting the standby
        /// service context relocation process. In some cases, the standby
        /// relocation trigger may take more time than what is set in threshold
        /// because of multiple different reasons, as listed below
        /// A. Standby relocation process runs as a background task which poll edge
        /// clusters at pre-defined interval of 5 minutes, to check for standby relocation.
        /// If during one cycle of standby relocation, an edge is found to be down, and the
        /// time remaining to threshold expiry in less then 5 minutes (for example 2 minute),
        /// than this relocation will be picked up in next cycle of standby relocation
        /// after 5 minutes, and not after 2 minutes.
        /// B. If edge becomes down at X time, then edge might take few seconds or
        /// minutes for all services to completely go down and report that they are
        /// down. So actual time when unified appliance knows edge is down may be X + delta.
        /// This delta time adds to the actual standby relocation threshold expiry,
        /// and once the [standby relocation threshold time + delta time] is complete for an
        /// edge node, and the edge is still down, than the standby relocation task will be
        /// performed for this edge node in the next cycle, that may be due to run anytime
        /// within next 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "standby_relocation_threshold")]
        public long? StandbyRelocationThreshold { get; set; }
    }
}
