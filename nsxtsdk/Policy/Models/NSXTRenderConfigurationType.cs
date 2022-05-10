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
    /// Render configuration to be applied to the widget.
    /// </summary>
    [NSXTProperty(Description: @"Render configuration to be applied to the widget.")]
    public class NSXTRenderConfigurationType 
    {
        /// <summary>
        /// The color to use when rendering an entity. For example, set color as 'RED' to render a portion of donut in red.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string? Color { get; set; }
        /// <summary>
        /// If the condition is met then the rendering specified for the condition will be applied. Examples of expression syntax
        /// are provided under 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// If specified, overrides the field value. This can be used to display a meaningful value in situations where field value
        /// is not available or not configured.
        /// </summary>
        [JsonProperty(PropertyName = "display_value")]
        public string? DisplayValue { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over the UI element if the condition is met.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// Icons to be applied at dashboard for widgets and UI elements.
        /// </summary>
        [JsonProperty(PropertyName = "icons")]
        public IList<NSXTIconType> Icons { get; set; }
    }
}
