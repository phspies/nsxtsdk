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
    /// Represents X and Y axis unit of a graph.
    /// </summary>
    [NSXTProperty(Description: @"Represents X and Y axis unit of a graph.")]
    public class NSXTAxisUnitType 
    {
        /// <summary>
        /// If the condition is met then the above unit will be displayed. to UI. If no condition is provided, then the unit will be
        /// displayed unconditionally.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// An Axis unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAxisUnitUnitEnumType? Unit { get; set; }
    }
}
