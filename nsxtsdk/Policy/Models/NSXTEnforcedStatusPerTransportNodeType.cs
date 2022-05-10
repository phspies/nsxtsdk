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
    /// Detailed Realized Status Per Transport Node.
    /// </summary>
    [NSXTProperty(Description: @"Detailed Realized Status Per Transport Node.")]
    public class NSXTEnforcedStatusPerTransportNodeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "enforced_status")]
        public NSXTEnforcedStatusNsxTType EnforcedStatus { get; set; }
        /// <summary>
        /// Policy Path referencing the transport node.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// UUID identifying uniquely the Transport Node.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_id")]
        public string? NsxId { get; set; }
        /// <summary>
        /// Display name of the transport node.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
    }
}
