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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTraceflowObservationReplicationLogicalType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// The label of VTEP
        /// </summary>
        [JsonProperty(PropertyName = "vtep_label")]
        public long? VtepLabel { get; set; }
        /// <summary>
        /// This field specifies the type of replication message TX_VTEP - Transmit replication to all VTEPs TX_MTEP - Transmit
        /// replication to all MTEPs RX - Receive replication
        /// </summary>
        [JsonProperty(PropertyName = "replication_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationReplicationLogicalReplicationTypeEnumType? ReplicationType { get; set; }
        /// <summary>
        /// Local IP address of the component that replicates the packet.
        /// </summary>
        [JsonProperty(PropertyName = "local_ip_address")]
        public string? LocalIpAddress { get; set; }
        /// <summary>
        /// The name of uplink
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name")]
        public string? UplinkName { get; set; }
    }
}
