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
    public class NSXTPortMirroringSessionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Port mirroring session direction
        /// </summary>
        [JsonProperty(PropertyName = "direction", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringSessionDirectionEnumType Direction { get; set; }
        /// <summary>
        /// Mirror sources
        /// </summary>
        [JsonProperty(PropertyName = "mirror_sources", Required = Required.AllowNull)]
        public IList<NSXTMirrorSourceType> MirrorSources { get; set; }
        /// <summary>
        /// Only for Remote SPAN Port Mirror.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_vlan_id")]
        public long? EncapsulationVlanId { get; set; }
        /// <summary>
        /// If this property is unset, this session will be treated as
        /// LocalPortMirrorSession.
        /// </summary>
        [JsonProperty(PropertyName = "session_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringSessionSessionTypeEnumType? SessionType { get; set; }
        /// <summary>
        /// If this property is set, the packet will be truncated to the provided
        /// length. If this property is unset, entire packet will be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "snap_length")]
        public long? SnapLength { get; set; }
        /// <summary>
        /// An array of 5-tuples used to filter packets for the mirror session, if not provided, all the packets will be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "port_mirroring_filters")]
        public IList<NSXTPortMirroringFilterType> PortMirroringFilters { get; set; }
        /// <summary>
        /// If set to mirror, mirror packet will be sent via dedicated mirror stack
        /// to destination; If set to default, mirror packet will be sent via default stack;
        /// So far, the value mirror can only be chosen in L3PortMirrorSession.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_ip_stack")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringSessionTcpIpStackEnumType? TcpIpStack { get; set; }
        /// <summary>
        /// Only for Remote SPAN Port Mirror. Whether to preserve original VLAN.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_original_vlan")]
        public bool? PreserveOriginalVlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mirror_destination", Required = Required.AllowNull)]
        public NSXTMirrorDestinationType MirrorDestination { get; set; }
    }
}
