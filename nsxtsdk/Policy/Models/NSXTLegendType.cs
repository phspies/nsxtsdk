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
    /// Represents legend that describes the entities of the widget.
    /// </summary>
    [NSXTProperty(Description: @"Represents legend that describes the entities of the widget.")]
    public class NSXTLegendType 
    {
        /// <summary>
        /// Describes the relative placement of legend. The legend of a widget can be placed either to the TOP or BOTTOM or LEFT or
        /// RIGHT relative to the widget. For example, if RIGHT is chosen then legend is placed to the right of the widget.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        [NSXTProperty(IsRequired: false, Description: @"Describes the relative placement of legend. The legend of a widget can be placed either to the TOP or BOTTOM or LEFT or RIGHT relative to the widget. For example, if RIGHT is chosen then legend is placed to the right of the widget.")]
        [NSXTDefaultProperty(Default: "RIGHT")]
        public NSXTLegendPositionEnumType? Position { get; set; }
        /// <summary>
        /// If set to true, it will display the counts in legend. If set to false, counts of entities are not displayed in the
        /// legend.
        /// </summary>
        [JsonProperty(PropertyName = "display_count")]
        [NSXTProperty(IsRequired: false, Description: @"If set to true, it will display the counts in legend. If set to false, counts of entities are not displayed in the legend.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DisplayCount { get; set; }
        /// <summary>
        /// Describes the render type for the legend. The legend for an entity describes the entity in the widget. The supported
        /// legend type is a circle against which the entity's details such as display_name are shown. The color of the circle
        /// denotes the color of the entity shown inside the widget.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Describes the render type for the legend. The legend for an entity describes the entity in the widget. The supported legend type is a circle against which the entity&apos;s details such as display_name are shown. The color of the circle denotes the color of the entity shown inside the widget.")]
        [NSXTDefaultProperty(Default: "CIRCLE")]
        public NSXTLegendTypeEnumType? Type { get; set; }
        /// <summary>
        /// Show unit of entities in the legend.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        [NSXTProperty(IsRequired: false, Description: @"Show unit of entities in the legend.")]
        public string? Unit { get; set; }
        /// <summary>
        /// Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a
        /// container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if
        /// HORIZONTAL is chosen then the items will appear side by side.
        /// </summary>
        [JsonProperty(PropertyName = "alignment")]
        [NSXTProperty(IsRequired: false, Description: @"Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if HORIZONTAL is chosen then the items will appear side by side.")]
        [NSXTDefaultProperty(Default: "VERTICAL")]
        public NSXTLegendAlignmentEnumType? Alignment { get; set; }
    }
}