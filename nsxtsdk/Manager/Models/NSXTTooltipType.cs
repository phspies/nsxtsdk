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
    /// Tooltip to be shown while hovering over the dashboard UI element.
    /// </summary>
    [NSXTProperty(Description: @"Tooltip to be shown while hovering over the dashboard UI element.")]
    public class NSXTTooltipType 
    {
        /// <summary>
        /// Text to be shown on tooltip while hovering over UI element. The text would be wrapped if it exceeds 80 chars.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        public string Text { get; set; }
        /// <summary>
        /// If true, displays tooltip text in bold
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        public bool? Heading { get; set; }
        /// <summary>
        /// If the condition is met then the tooltip will be applied. If no condition is provided, then the tooltip will be applied
        /// unconditionally. Examples of expression syntax are provided under 'example_request' section of
        /// 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
    }
}
