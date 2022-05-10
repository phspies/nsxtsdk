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
    /// This object holds auto assigned route distinguishers for Layer 2 and Layer 3 configurations.
    /// </summary>
    [NSXTProperty(Description: @"This object holds auto assigned route distinguishers for Layer 2 and Layer 3 configurations.")]
    public class NSXTAutoRdsType 
    {
        /// <summary>
        /// This field is auto assigned by the system.
        /// The auto RD seed is populated when user does not assign a
        /// route_distinguisher field in the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "l3_auto_rd")]
        public string? L3AutoRd { get; set; }
        /// <summary>
        /// List of layer 2 Auto assigned Route Distinguisher
        /// </summary>
        [JsonProperty(PropertyName = "l2_auto_rds")]
        public IList<NSXTL2AutoRDType> L2AutoRds { get; set; }
    }
}
