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
    /// Represents layout of a container or widget
    /// </summary>
    [NSXTProperty(Description: @"Represents layout of a container or widget")]
    public class NSXTLayoutType 
    {
        /// <summary>
        /// Describes layout of a container or widget. Layout describes how individual widgets are placed inside the container. For
        /// example, if HORIZONTAL is chosen widgets are placed side by side inside the container. If VERTICAL is chosen then
        /// widgets are placed one below the other. If GRID is chosen then the container or widget display area is divided into a
        /// grid of m rows and n columns, as specified in the properties, and the widgets are placed inside the grid. If AUTO is
        /// chosen then container or widgets display area will be automatically calculated depending upon the required width.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLayoutTypeEnumType? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public NSXTLayoutPropertiesType Properties { get; set; }
    }
}
