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
    /// Properties of the layout of a container or widget
    /// </summary>
    [NSXTProperty(Description: @"Properties of the layout of a container or widget")]
    public class NSXTLayoutPropertiesType 
    {
        /// <summary>
        /// Describes the number of rows of grid layout of a container or widget. This property is applicable for grid layout only.
        /// </summary>
        [JsonProperty(PropertyName = "num_rows")]
        public int? NumRows { get; set; }
        /// <summary>
        /// Describes the number of columns of grid layout of a container or widget. This property is applicable for grid layout
        /// only.
        /// </summary>
        [JsonProperty(PropertyName = "num_columns")]
        public int? NumColumns { get; set; }
    }
}
