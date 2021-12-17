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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Additional configuration required for federation.
    /// </summary>
    [NSXTProperty(Description: @"Additional configuration required for federation.")]
    public class NSXTFederationConnectivityConfigType 
    {
        public NSXTFederationConnectivityConfigType()
        {
        }
        /// <summary>
        /// Global id for by Layer3 services for federation usecases.
        /// </summary>
        [JsonProperty(PropertyName = "global_overlay_id")]
        [NSXTProperty(IsRequired: false, Description: @"Global id for by Layer3 services for federation usecases.")]
        public long? GlobalOverlayId { get; set; }
    }
}
