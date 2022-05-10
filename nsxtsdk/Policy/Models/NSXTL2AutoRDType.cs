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
    /// Layer 2 Auto assigned Route Distinguisher
    /// </summary>
    [NSXTProperty(Description: @"Layer 2 Auto assigned Route Distinguisher")]
    public class NSXTL2AutoRDType 
    {
        /// <summary>
        /// Layer 2 Virtual Network Interface
        /// </summary>
        [JsonProperty(PropertyName = "l2_vni")]
        public string? L2Vni { get; set; }
        /// <summary>
        /// Layer 2 auto assigned route distinghusher
        /// </summary>
        [JsonProperty(PropertyName = "l2_auto_rd")]
        public string? L2AutoRd { get; set; }
    }
}
