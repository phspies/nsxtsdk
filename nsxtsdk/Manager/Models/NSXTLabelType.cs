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
    /// Label that will be displayed for a UI element.
    /// </summary>
    [NSXTProperty(Description: @"Label that will be displayed for a UI element.")]
    public class NSXTLabelType 
    {
        /// <summary>
        /// Text to be displayed at the label.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        public string Text { get; set; }
        /// <summary>
        /// If true, displays the label only on hover
        /// </summary>
        [JsonProperty(PropertyName = "hover")]
        public bool? Hover { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// If the condition is met then the label will be applied. Examples of expression syntax are provided under example_request
        /// section of CreateWidgetConfiguration API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// Icons to be applied at dashboard for the label
        /// </summary>
        [JsonProperty(PropertyName = "icons")]
        public IList<NSXTIconType> Icons { get; set; }
    }
}
