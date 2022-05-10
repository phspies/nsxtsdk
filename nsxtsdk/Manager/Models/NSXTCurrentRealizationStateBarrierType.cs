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
    /// The current global barrier number of the realized state
    /// </summary>
    [NSXTProperty(Description: @"The current global barrier number of the realized state")]
    public class NSXTCurrentRealizationStateBarrierType 
    {
        /// <summary>
        /// Gives the current global barrier number for NSX
        /// </summary>
        [JsonProperty(PropertyName = "current_barrier_number")]
        public long? CurrentBarrierNumber { get; set; }
    }
}
