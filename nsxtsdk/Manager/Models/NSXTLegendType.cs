// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTLegendDisplayModeEnumType? DisplayMode { get; set; }
        /// <summary>
        /// Describes the alignment of legend. Alignment of a legend denotes how individual items of the legend are aligned in a
        /// container. For example, if VERTICAL is chosen then the items of the legend will appear one below the other and if
        /// HORIZONTAL is chosen then the items will appear side by side.
        /// </summary>
        public NSXTLegendAlignmentEnumType? Alignment { get; set; }
        /// <summary>
        /// Show checkbox along with legends if value is set to true. Widget filtering capability can be enable based on legend
        /// checkbox selection. for 'display_mode' SHOW_OTHER_GROUP_WITH_LEGENDS filterable property is not supported.
        /// </summary>
        public bool? Filterable { get; set; }
        /// <summary>
        /// Describes the relative placement of legend. The legend of a widget can be placed either to the TOP or BOTTOM or LEFT or
        /// RIGHT relative to the widget. For example, if RIGHT is chosen then legend is placed to the right of the widget.
        /// </summary>
        public NSXTLegendPositionEnumType? Position { get; set; }
        /// <summary>
        /// If set to true, it will display the counts in legend. If set to false, counts of entities are not displayed in the
        /// legend.
        /// </summary>
        public bool? DisplayCount { get; set; }
        /// <summary>
        /// Describes the render type for the legend. The legend for an entity describes the entity in the widget. The supported
        /// legend type is a circle against which the entity's details such as display_name are shown. The color of the circle
        /// denotes the color of the entity shown inside the widget.
        /// </summary>
        public NSXTLegendTypeEnumType? Type { get; set; }
        /// <summary>
        /// A minimum number of legends to be displayed upfront. if 'display_mode' is set to SHOW_MIN_NO_OF_LEGENDS then this
        /// property value will be used to display number of legends upfront in the UI.
        /// </summary>
        public int? MinLegendsDisplayCount { get; set; }
        /// <summary>
        /// Show unit of entities in the legend.
        /// </summary>
        public string? Unit { get; set; }
        /// <summary>
        /// A translated label for showing other category label in legends.
        /// </summary>
        public string? OtherGroupLegendLabel { get; set; }
    }
}
