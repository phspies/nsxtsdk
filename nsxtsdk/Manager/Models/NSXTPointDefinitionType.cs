// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Defines the point of a graph.
    /// </summary>
    [NSXTProperty(Description: @"Defines the point of a graph.")]
    public class NSXTPointDefinitionType 
    {
        /// <summary>
        /// Represents the variable for the Y value of points that are plotted on the graph.
        /// </summary>
        [JsonProperty(PropertyName = "y_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Represents the variable for the Y value of points that are plotted on the graph.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string YValue { get; set; }
        /// <summary>
        /// An expression that represents the points of the graph
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"An expression that represents the points of the graph")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Field { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget. A widget is considered as drilldown
        /// widget when it is associated with any other widget and provides more detailed information about any data item from the
        /// parent widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of drilldown widget, if any. Id should be a valid id of an existing widget. A widget is considered as drilldown widget when it is associated with any other widget and provides more detailed information about any data item from the parent widget.")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// Represents the variable for the X value of points that are plotted on the graph.
        /// </summary>
        [JsonProperty(PropertyName = "x_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Represents the variable for the X value of points that are plotted on the graph.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string XValue { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        [NSXTProperty(IsRequired: false, Description: @"Hyperlink of the specified UI page that provides details.")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over the point of a graph.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        [NSXTProperty(IsRequired: false, Description: @"Multi-line text to be shown on tooltip while hovering over the point of a graph.")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
    }
}
