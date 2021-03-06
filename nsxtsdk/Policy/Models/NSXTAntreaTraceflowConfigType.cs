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
    public class NSXTAntreaTraceflowConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Destination external id for Antrea traceflow. Must be
        /// ContainerApplicationInstance or ContainerApplication. Ignored if
        /// destination_ip provided in packet data.
        /// </summary>
        [JsonProperty(PropertyName = "destination_external_id")]
        public string? DestinationExternalId { get; set; }
        /// <summary>
        /// Container cluster ID in inventory. This property is used to identify
        /// multiple clusters under single NSX-T.
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_id", Required = Required.AllowNull)]
        public string ContainerClusterId { get; set; }
        /// <summary>
        /// This field indicates if intent is transient and will be cleaned up by the system if set to true.
        /// </summary>
        [JsonProperty(PropertyName = "is_transient")]
        public bool? IsTransient { get; set; }
        /// <summary>
        /// Source external id for Antrea traceflow. Must be
        /// ContainerApplicationInstance external_id.
        /// </summary>
        [JsonProperty(PropertyName = "source_external_id", Required = Required.AllowNull)]
        public string SourceExternalId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "packet")]
        public NSXTAntreaTraceflowPacketDataType Packet { get; set; }
    }
}
