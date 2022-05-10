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
    /// Advanced load balancer EquivalentLabels object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer EquivalentLabels object")]
    public class NSXTALBEquivalentLabelsType 
    {
        /// <summary>
        /// Equivalent labels.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }
    }
}
