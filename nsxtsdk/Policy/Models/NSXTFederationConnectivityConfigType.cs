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
    /// Additional configuration required for federation.
    /// </summary>
    [NSXTProperty(Description: @"Additional configuration required for federation.")]
    public class NSXTFederationConnectivityConfigType 
    {
        /// <summary>
        /// Global id for by Layer3 services for federation usecases.
        /// </summary>
        [JsonProperty(PropertyName = "global_overlay_id")]
        public long? GlobalOverlayId { get; set; }
    }
}
