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
    /// Contians realized state of the logical port. For example, transport node
        /// on which the port is located, discovered and realized address bindings of
        /// the logical port.
    /// </summary>
    [NSXTProperty(Description: @"Contians realized state of the logical port. For example, transport nodeon which the port is located, discovered and realized address bindings ofthe logical port.")]
    public class NSXTLogicalPortStateType 
    {
        /// <summary>
        /// Identifiers of the transport node where the port is located
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_ids")]
        public IList<string> TransportNodeIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        public NSXTLogicalPortAttachmentStateType Attachment { get; set; }
        /// <summary>
        /// If any address binding discovered on the port is also found on
        /// other port on the same logical switch, then it is included in
        /// the duplicate bindings list along with the ID of the port with
        /// which it conflicts.
        /// </summary>
        [JsonProperty(PropertyName = "duplicate_bindings")]
        public IList<NSXTDuplicateAddressBindingEntryType> DuplicateBindings { get; set; }
        /// <summary>
        /// Contains the list of address bindings for a logical port that were
        /// automatically dicovered using various snooping methods like ARP, DHCP
        /// etc.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_bindings")]
        public IList<NSXTAddressBindingEntryType> DiscoveredBindings { get; set; }
        /// <summary>
        /// Id of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// List of logical port bindings that are realized. This list may be
        /// populated from the discovered bindings or manual user specified bindings.
        /// This binding configuration can be used by features such as firewall,
        /// spoof-guard, traceflow etc.
        /// </summary>
        [JsonProperty(PropertyName = "realized_bindings")]
        public IList<NSXTAddressBindingEntryType> RealizedBindings { get; set; }
    }
}
