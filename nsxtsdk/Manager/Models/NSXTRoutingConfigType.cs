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
    public class NSXTRoutingConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// Defines the extra time the router must wait before sending the UP notification
        /// after the first BGP session is established. Default means forward immediately.
        /// For TIER0/TIER1 logical router, default is 0. VRF logical router will set it same as
        /// parent logical router.
        /// </summary>
        [JsonProperty(PropertyName = "forwarding_up_timer")]
        public long? ForwardingUpTimer { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
    }
}
