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
    /// Represents a column of the Grid
    /// </summary>
    [NSXTProperty(Description: @"Represents a column of the Grid")]
    public class NSXTColumnItemType 
    {
        /// <summary>
        /// Sorting on column is based on the sort_key. sort_key represents the field in the output data on which sort is requested.
        /// </summary>
        [JsonProperty(PropertyName = "sort_key")]
        [NSXTProperty(IsRequired: false, Description: @"Sorting on column is based on the sort_key. sort_key represents the field in the output data on which sort is requested.")]
        public string? SortKey { get; set; }
        /// <summary>
        /// Data type of the field.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Data type of the field.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "String")]
        public NSXTColumnItemTypeEnumType Type { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over a cell in the grid.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        [NSXTProperty(IsRequired: false, Description: @"Multi-line text to be shown on tooltip while hovering over a cell in the grid.")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// Label of the column.
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Label of the column.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLabelType Label { get; set; }
        /// <summary>
        /// Field from which values of the column will be derived.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Field from which values of the column will be derived.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Field { get; set; }
        /// <summary>
        /// If true, the value of the column are sorted in ascending order. Otherwise, in descending order.
        /// </summary>
        [JsonProperty(PropertyName = "sort_ascending")]
        [NSXTProperty(IsRequired: false, Description: @"If true, the value of the column are sorted in ascending order. Otherwise, in descending order.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? SortAscending { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of drilldown widget, if any. Id should be a valid id of an existing widget.")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// If set to true, hides the column
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        [NSXTProperty(IsRequired: false, Description: @"If set to true, hides the column")]
        public bool? Hidden { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details. If drilldown_id is provided, then navigation cannot be used.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        [NSXTProperty(IsRequired: false, Description: @"Hyperlink of the specified UI page that provides details. If drilldown_id is provided, then navigation cannot be used.")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Identifies the column and used for fetching content upon an user click or drilldown. If column identifier is not
        /// provided, the column's data will not participate in searches and drilldowns.
        /// </summary>
        [JsonProperty(PropertyName = "column_identifier")]
        [NSXTProperty(IsRequired: false, Description: @"Identifies the column and used for fetching content upon an user click or drilldown. If column identifier is not provided, the column&apos;s data will not participate in searches and drilldowns.")]
        public string? ColumnIdentifier { get; set; }
        /// <summary>
        /// Render configuration to be applied, if any.
        /// </summary>
        [JsonProperty(PropertyName = "render_configuration")]
        [NSXTProperty(IsRequired: false, Description: @"Render configuration to be applied, if any.")]
        public IList<NSXTRenderConfigurationType> RenderConfiguration { get; set; }
    }
}