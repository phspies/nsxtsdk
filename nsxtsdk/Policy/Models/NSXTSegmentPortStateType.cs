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
    /// Contains realized state of the segment port. For example: transport node
        /// on which the port is located, discovered and realized address bindings of
        /// the port.
    /// </summary>
    [NSXTProperty(Description: @"Contains realized state of the segment port. For example: transport nodeon which the port is located, discovered and realized address bindings ofthe port.")]
    public class NSXTSegmentPortStateType 
    {
        /// <summary>
        /// Identifiers of the transport nodes where the port is located
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_ids")]
        public IList<string> TransportNodeIds { get; set; }
        /// <summary>
        /// Contains the list of address bindings for a segment port that were
        /// automatically dicovered using various snooping methods like ARP, DHCP
        /// etc.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_bindings")]
        public IList<NSXTAddressBindingEntryType> DiscoveredBindings { get; set; }
        /// <summary>
        /// If any address binding discovered on the port is also found on
        /// other port on the same segment, then it is included in
        /// the duplicate bindings list along with the ID of the port with
        /// which it conflicts.
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_bindings")]
        public IList<NSXTDuplicateAddressBindingEntryType> DuplicateBindings { get; set; }
        /// <summary>
        /// List of segment port bindings that are realized. This list may be
        /// populated from the discovered bindings or manual user specified bindings.
        /// This binding configuration can be used by features such as firewall,
        /// spoof-guard, traceflow etc.
        /// </summary>
        [JsonProperty(PropertyName = "realized_bindings")]
        public IList<NSXTAddressBindingEntryType> RealizedBindings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        public NSXTSegmentPortAttachmentStateType Attachment { get; set; }
    }
}
