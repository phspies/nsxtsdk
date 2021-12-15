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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Tooltip to be shown while hovering over the dashboard UI element.
    /// </summary>
    [NSXTProperty(Description: @"Tooltip to be shown while hovering over the dashboard UI element.")]
    public class NSXTTooltipType 
    {
        /// <summary>
        /// Text to be shown on tooltip while hovering over UI element. The text would be wrapped if it exceeds 80 chars.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Text to be shown on tooltip while hovering over UI element. The text would be wrapped if it exceeds 80 chars.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Text { get; set; }
        /// <summary>
        /// If true, displays tooltip text in bold
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        [NSXTProperty(IsRequired: false, Description: @"If true, displays tooltip text in bold")]
        public bool? Heading { get; set; }
        /// <summary>
        /// If the condition is met then the tooltip will be applied. If no condition is provided, then the tooltip will be applied
        /// unconditionally. Examples of expression syntax are provided under 'example_request' section of
        /// 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        [NSXTProperty(IsRequired: false, Description: @"If the condition is met then the tooltip will be applied. If no condition is provided, then the tooltip will be applied unconditionally. Examples of expression syntax are provided under &apos;example_request&apos; section of &apos;CreateWidgetConfiguration&apos; API.")]
        public string? Condition { get; set; }
    }
}