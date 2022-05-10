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
    /// Icon to be applied at dashboard for widgets and UI elements.
    /// </summary>
    [NSXTProperty(Description: @"Icon to be applied at dashboard for widgets and UI elements.")]
    public class NSXTIconType 
    {
        /// <summary>
        /// If specified as PRE, the icon appears before the UI element. If set as POST, the icon appears after the UI element.
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIconPlacementEnumType? Placement { get; set; }
        /// <summary>
        /// Icon color applied to icon in hex format.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string? Color { get; set; }
        /// <summary>
        /// Icon will be rendered based on its type. For example, if ERROR is chosen, then icon representing error will be rendered.
        /// or else custom svg icon name can be given.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Icon size unit applied to icon along with size. if 'size' property value is provided and no value is provided for this
        /// property then default value for this proerty is set to 'px'.
        /// </summary>
        [JsonProperty(PropertyName = "size_unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIconSizeUnitEnumType? SizeUnit { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over the icon.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// Icon size in unit applied to icon.A unit can be specified by the 'size_unit' property.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public double? Size { get; set; }
    }
}
