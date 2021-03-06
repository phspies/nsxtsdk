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
    public class NSXTPortMirroringProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If set to INCLUDE, packets matching all filters will be mirrored.
        /// If set to EXCLUDE, packets NOT matching any filters will be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "filter_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringProfileFilterActionEnumType? FilterAction { get; set; }
        /// <summary>
        /// User can provide Mirror stack or Default stack to send mirror traffic. If profile type is REMOTE_L3_SPAN, tcp_ip_stack
        /// type is used else ignored.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_ip_stack")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringProfileTcpIpStackEnumType? TcpIpStack { get; set; }
        /// <summary>
        /// Allows user to select type of port mirroring session.
        /// </summary>
        [JsonProperty(PropertyName = "profile_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringProfileProfileTypeEnumType? ProfileType { get; set; }
        /// <summary>
        /// An array of 5-tuples used to filter packets for the mirror session. If not provided, all the packets will be mirrored.
        /// This field is with filter_action which defines whether packets matching the filter will be included or excluded
        /// </summary>
        [JsonProperty(PropertyName = "port_mirroring_filters")]
        public IList<NSXTPortMirrorFilterType> PortMirroringFilters { get; set; }
        /// <summary>
        /// If this property is set, the packet will be truncated to the provided
        /// length. If this property is unset, entire packet will be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "snap_length")]
        public int? SnapLength { get; set; }
        /// <summary>
        /// User can provide Mirror Destination type e.g GRE, ERSPAN_TWO or ERSPAN_THREE.If profile type is REMOTE_L3_SPAN,
        /// encapsulation type is used else ignored.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringProfileEncapsulationTypeEnumType? EncapsulationType { get; set; }
        /// <summary>
        /// Used by physical switch for the mirror traffic forwarding.
        /// Must be provided and only effective when encapsulation type is
        /// ERSPAN type II or type III.
        /// </summary>
        [JsonProperty(PropertyName = "erspan_id")]
        public int? ErspanId { get; set; }
        /// <summary>
        /// User-configurable 32-bit key only for GRE
        /// </summary>
        [JsonProperty(PropertyName = "gre_key")]
        public int? GreKey { get; set; }
        /// <summary>
        /// Port mirroring profile direction
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringProfileDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Data from source group will be copied to members of
        /// destination group. Only IPSET group and group with
        /// membership criteria VM is supported. IPSET group allows only
        /// three ip's.
        /// </summary>
        [JsonProperty(PropertyName = "destination_group", Required = Required.AllowNull)]
        public string DestinationGroup { get; set; }
    }
}
