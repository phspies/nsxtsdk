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
    /// Status of the Identity Firewall enabled Compute collection.
    /// </summary>
    [NSXTProperty(Description: @"Status of the Identity Firewall enabled Compute collection.")]
    public class NSXTIdfwComputeCollectionConditionType 
    {
        /// <summary>
        /// IDFW enabled Compute collection status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdfwComputeCollectionConditionStatusEnumType Status { get; set; }
        /// <summary>
        /// Status of the Compute collection.
        /// </summary>
        [JsonProperty(PropertyName = "status_detail")]
        public string? StatusDetail { get; set; }
    }
}
