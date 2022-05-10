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
    /// pNIC/bond statuses
    /// </summary>
    [NSXTProperty(Description: @"pNIC/bond statuses")]
    public class NSXTPnicBondStatusType 
    {
        /// <summary>
        /// Status of pNIC/bond
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPnicBondStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// type, whether the object is a pNIC or a bond
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPnicBondStatusTypeEnumType? Type { get; set; }
        /// <summary>
        /// Name of the pNIC/bond
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
