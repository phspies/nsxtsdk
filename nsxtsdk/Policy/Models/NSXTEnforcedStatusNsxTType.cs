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
    /// NSX-T Enforced Status.
    /// </summary>
    [NSXTProperty(Description: @"NSX-T Enforced Status.")]
    public class NSXTEnforcedStatusNsxTType 
    {
        /// <summary>
        /// Enforced Realized Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEnforcedStatusNsxTStatusEnumType? Status { get; set; }
        /// <summary>
        /// Status Message conveying hints depending on the status value.
        /// </summary>
        [JsonProperty(PropertyName = "status_message")]
        public string? StatusMessage { get; set; }
    }
}
