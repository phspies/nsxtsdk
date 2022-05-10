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
    /// Represents an entity or portion to be plotted on a donut or stats chart.
    /// </summary>
    [NSXTProperty(Description: @"Represents an entity or portion to be plotted on a donut or stats chart.")]
    public class NSXTDonutPartType 
    {
        /// <summary>
        /// A numerical value that represents the portion or entity of the donut or stats chart.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        public string Field { get; set; }
        /// <summary>
        /// If true, legend will be shown only if the data for the part is available. This is applicable only if legends are
        /// specified in widget configuration.
        /// </summary>
        [JsonProperty(PropertyName = "hide_empty_legend")]
        public bool? HideEmptyLegend { get; set; }
        /// <summary>
        /// If the condition is met then the part will be displayed. Examples of expression syntax are provided under
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget. A widget is considered as drilldown
        /// widget when it is associated with any other widget and provides more detailed information about any data item from the
        /// parent widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details. If drilldown_id is provided, then navigation cannot be used.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over the portion.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// Additional rendering or conditional evaluation of the field values to be performed, if any.
        /// </summary>
        [JsonProperty(PropertyName = "render_configuration")]
        public IList<NSXTRenderConfigurationType> RenderConfiguration { get; set; }
    }
}
