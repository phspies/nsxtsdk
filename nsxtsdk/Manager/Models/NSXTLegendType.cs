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
    /// Represents legend that describes the entities of the widget.
    /// </summary>
    [NSXTProperty(Description: @"Represents legend that describes the entities of the widget.")]
    public class NSXTLegendType 
    {
        /// <summary>
        /// Display mode for legends.
        /// </summary>
        [JsonProperty(PropertyName = "display_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLegendDisplayModeEnumType? DisplayMode { get; set; }
        /// <summary>
        /// Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a
        /// container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if
        /// HORIZONTAL is chosen then the items will appear side by side.
        /// </summary>
        [JsonProperty(PropertyName = "alignment")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLegendAlignmentEnumType? Alignment { get; set; }
        /// <summary>
        /// Show checkbox along with legends if value is set to true. Widget filtering capability can be enable based on legend
        /// checkbox selection. for 'display_mode' SHOW_OTHER_GROUP_WITH_LEGENDS filterable property is not supported.
        /// </summary>
        [JsonProperty(PropertyName = "filterable")]
        public bool? Filterable { get; set; }
        /// <summary>
        /// Describes the relative placement of legend. The legend of a widget can be placed either to the TOP or BOTTOM or LEFT or
        /// RIGHT relative to the widget. For example, if RIGHT is chosen then legend is placed to the right of the widget.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLegendPositionEnumType? Position { get; set; }
        /// <summary>
        /// If set to true, it will display the counts in legend. If set to false, counts of entities are not displayed in the
        /// legend.
        /// </summary>
        [JsonProperty(PropertyName = "display_count")]
        public bool? DisplayCount { get; set; }
        /// <summary>
        /// Describes the render type for the legend. The legend for an entity describes the entity in the widget. The supported
        /// legend type is a circle against which the entity's details such as display_name are shown. The color of the circle
        /// denotes the color of the entity shown inside the widget.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLegendTypeEnumType? Type { get; set; }
        /// <summary>
        /// A minimum number of legends to be displayed upfront. if 'display_mode' is set to SHOW_MIN_NO_OF_LEGENDS then this
        /// property value will be used to display number of legends upfront in the UI.
        /// </summary>
        [JsonProperty(PropertyName = "min_legends_display_count")]
        public int? MinLegendsDisplayCount { get; set; }
        /// <summary>
        /// Show unit of entities in the legend.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string? Unit { get; set; }
        /// <summary>
        /// A translated label for showing other category label in legends.
        /// </summary>
        [JsonProperty(PropertyName = "other_group_legend_label")]
        public string? OtherGroupLegendLabel { get; set; }
    }
}
