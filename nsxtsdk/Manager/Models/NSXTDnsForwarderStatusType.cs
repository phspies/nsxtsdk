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
    /// The current runtime status of the DNS forwarder including the hosting
        /// transport nodes and forwarder service status.
    /// </summary>
    [NSXTProperty(Description: @"The current runtime status of the DNS forwarder including the hostingtransport nodes and forwarder service status.")]
    public class NSXTDnsForwarderStatusType 
    {
        /// <summary>
        /// UP means the DNS forwarder is working correctly on the active transport
        /// node and the stand-by transport node (if present). Failover will occur
        /// if either node goes down.
        /// DOWN means the DNS forwarder is down on both active transport node and
        /// standby node (if present). The DNS forwarder does not function in this
        /// situation.
        /// Error means there is some error on one or both transport node, or no
        /// status was reported from one or both transport nodes. The dns forwarder
        /// may be working (or not working).
        /// NO_BACKUP means dns forwarder is working in only one transport node,
        /// either because it is down on the standby node, or no standby is configured.
        /// An forwarder outage will occur if the active node goes down.
        /// </summary>
        public NSXTDnsForwarderStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Time stamp of the current status, in ms
        /// </summary>
        public long? Timestamp { get; set; }
        /// <summary>
        /// Uuid of stand_by transport node. null if non-HA mode
        /// </summary>
        public string? StandbyNode { get; set; }
        /// <summary>
        /// Extra message, if available
        /// </summary>
        public string? ExtraMessage { get; set; }
        /// <summary>
        /// Uuid of active transport node
        /// </summary>
        public string? ActiveNode { get; set; }
    }
}
