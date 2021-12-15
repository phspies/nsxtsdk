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
    /// Label that will be displayed for a UI element.
    /// </summary>
    [NSXTProperty(Description: @"Label that will be displayed for a UI element.")]
    public class NSXTLabelType 
    {
        /// <summary>
        /// Text to be displayed at the label.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Text to be displayed at the label.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Text { get; set; }
        /// <summary>
        /// If true, displays the label only on hover
        /// </summary>
        [JsonProperty(PropertyName = "hover")]
        [NSXTProperty(IsRequired: false, Description: @"If true, displays the label only on hover")]
        public bool? Hover { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        [NSXTProperty(IsRequired: false, Description: @"Hyperlink of the specified UI page that provides details.")]
        public string? Navigation { get; set; }
        /// <summary>
        /// If the condition is met then the label will be applied. Examples of expression syntax are provided under example_request
        /// section of CreateWidgetConfiguration API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        [NSXTProperty(IsRequired: false, Description: @"If the condition is met then the label will be applied. Examples of expression syntax are provided under example_request section of CreateWidgetConfiguration API.")]
        public string? Condition { get; set; }
        /// <summary>
        /// Icons to be applied at dashboard for the label
        /// </summary>
        [JsonProperty(PropertyName = "icons")]
        [NSXTProperty(IsRequired: false, Description: @"Icons to be applied at dashboard for the label")]
        public IList<NSXTIconType> Icons { get; set; }
    }
}
