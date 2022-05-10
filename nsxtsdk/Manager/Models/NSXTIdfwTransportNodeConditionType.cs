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
    /// Status of the Identity Firewall Compute Collection's transport node.
    /// </summary>
    [NSXTProperty(Description: @"Status of the Identity Firewall Compute Collection&apos;s transport node.")]
    public class NSXTIdfwTransportNodeConditionType 
    {
        /// <summary>
        /// Transport node status for IDFW compute collection.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdfwTransportNodeConditionStatusEnumType Status { get; set; }
        /// <summary>
        /// IDFW Compute collection's transport node condition.
        /// </summary>
        [JsonProperty(PropertyName = "status_detail")]
        public string? StatusDetail { get; set; }
    }
}
