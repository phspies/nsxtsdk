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
    /// Antrea adapter status
    /// </summary>
    [NSXTProperty(Description: @"Antrea adapter status")]
    public class NSXTAntreaAdapterStatusType 
    {
        /// <summary>
        /// Indicate overall healthy status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAntreaAdapterStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Collection of adapter conditions.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<NSXTComponentConditionItemType> Conditions { get; set; }
    }
}
