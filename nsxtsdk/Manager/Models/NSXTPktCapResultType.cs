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
    /// The packet capture result for transport nodes
    /// </summary>
    [NSXTProperty(Description: @"The packet capture result for transport nodes")]
    public class NSXTPktCapResultType 
    {
        /// <summary>
        /// The packet capture resource info for ports where packet
        /// capture action is performed
        /// </summary>
        public IList<NSXTPktCapResourceType> PktcapResourceList { get; set; }
        /// <summary>
        /// Type of the transport node
        /// </summary>
        public NSXTPktCapResultTransportNodeTypeEnumType? TransportNodeType { get; set; }
        /// <summary>
        /// The ID of transport node where packet capture action is deployed
        /// </summary>
        public string? TransportNodeId { get; set; }
    }
}
