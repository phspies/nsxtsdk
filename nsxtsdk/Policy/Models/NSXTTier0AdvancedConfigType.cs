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
    public class NSXTTier0AdvancedConfigType : NSXTConnectivityAdvancedConfigType
    {
        /// <summary>
        /// Extra time in seconds the router must wait before sending the UP
        /// notification after the peer routing session is established. Default
        /// means forward immediately. VRF logical router will set it same as parent
        /// logical router.
        /// </summary>
        [JsonProperty(PropertyName = "forwarding_up_timer")]
        public long? ForwardingUpTimer { get; set; }
    }
}
