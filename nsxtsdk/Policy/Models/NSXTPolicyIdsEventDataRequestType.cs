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
    /// Filtering parameters to get only a subset of intrusion events.
    /// </summary>
    [NSXTProperty(Description: @"Filtering parameters to get only a subset of intrusion events.")]
    public class NSXTPolicyIdsEventDataRequestType 
    {
        /// <summary>
        /// An array of filter conditions.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<NSXTFilterRequestType> Filters { get; set; }
    }
}
