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
    /// Represents a column of the Grid
    /// </summary>
    [NSXTProperty(Description: @"Represents a column of the Grid")]
    public class NSXTColumnItemType 
    {
        /// <summary>
        /// Sorting on column is based on the sort_key. sort_key represents the field in the output data on which sort is requested.
        /// </summary>
        [JsonProperty(PropertyName = "sort_key")]
        public string? SortKey { get; set; }
        /// <summary>
        /// Data type of the field.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTColumnItemTypeEnumType Type { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over a cell in the grid.
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public NSXTLabelType Label { get; set; }
        /// <summary>
        /// Field from which values of the column will be derived.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        public string Field { get; set; }
        /// <summary>
        /// If true, the value of the column are sorted in ascending order. Otherwise, in descending order.
        /// </summary>
        [JsonProperty(PropertyName = "sort_ascending")]
        public bool? SortAscending { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// If set to true, hides the column
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details. If drilldown_id is provided, then navigation cannot be used.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Identifies the column and used for fetching content upon an user click or drilldown. If column identifier is not
        /// provided, the column's data will not participate in searches and drilldowns.
        /// </summary>
        [JsonProperty(PropertyName = "column_identifier")]
        public string? ColumnIdentifier { get; set; }
        /// <summary>
        /// Render configuration to be applied, if any.
        /// </summary>
        [JsonProperty(PropertyName = "render_configuration")]
        public IList<NSXTRenderConfigurationType> RenderConfiguration { get; set; }
    }
}
