// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTraceflowObservationRelayedLogicalType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// This field specified the message type of the relay service REQUEST - The relay service will relay a request message to
        /// the destination server REPLY - The relay service will relay a reply message to the client
        /// </summary>
        [JsonProperty(PropertyName = "message_type")]
        [NSXTProperty(IsRequired: false, Description: @"This field specified the message type of the relay service REQUEST - The relay service will relay a request message to the destination server REPLY - The relay service will relay a reply message to the client")]
        [NSXTDefaultProperty(Default: "REQUEST")]
        public NSXTTraceflowObservationRelayedLogicalMessageTypeEnumType? MessageType { get; set; }
        /// <summary>
        /// This field specified the IP address of the destination which the packet will be relayed.
        /// </summary>
        [JsonProperty(PropertyName = "dst_server_address")]
        [NSXTProperty(IsRequired: false, Description: @"This field specified the IP address of the destination which the packet will be relayed.")]
        public string? DstServerAddress { get; set; }
        /// <summary>
        /// This field specified the logical component that relay service located.
        /// </summary>
        [JsonProperty(PropertyName = "logical_comp_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"This field specified the logical component that relay service located.")]
        public string? LogicalCompUuid { get; set; }
        /// <summary>
        /// This field specified the IP address of the relay service.
        /// </summary>
        [JsonProperty(PropertyName = "relay_server_address")]
        [NSXTProperty(IsRequired: false, Description: @"This field specified the IP address of the relay service.")]
        public string? RelayServerAddress { get; set; }
    }
}
