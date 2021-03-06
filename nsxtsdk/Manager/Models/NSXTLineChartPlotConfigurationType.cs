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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLineChartPlotConfigurationType : NSXTWidgetPlotConfigurationType
    {
        /// <summary>
        /// Used for displaying the curved lines for a series in a line chart. By default,
        /// straight line is used to for a series in a line chart.
        /// </summary>
        [JsonProperty(PropertyName = "show_curved_lines")]
        public bool? ShowCurvedLines { get; set; }
        /// <summary>
        /// Show the data unit in tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "show_unit_in_tooltip")]
        public bool? ShowUnitInTooltip { get; set; }
        /// <summary>
        /// Fill the line chart area with a gradient series color.
        /// </summary>
        [JsonProperty(PropertyName = "fill_gradient_area")]
        public bool? FillGradientArea { get; set; }
        /// <summary>
        /// Controls the visiblity of the grid lines in
        /// line chart.
        /// </summary>
        [JsonProperty(PropertyName = "show_grid_lines")]
        public bool? ShowGridLines { get; set; }
        /// <summary>
        /// Controls the visiblity of the min and max value
        /// across line series in line chart.
        /// </summary>
        [JsonProperty(PropertyName = "show_min_max_on_series")]
        public bool? ShowMinMaxOnSeries { get; set; }
        /// <summary>
        /// Sort the data in grouped tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "sort_data_in_grouped_tooltip")]
        public bool? SortDataInGroupedTooltip { get; set; }
        /// <summary>
        /// Specifies whether the series should be sorted by the latest data point.
        /// </summary>
        [JsonProperty(PropertyName = "sort_series")]
        public bool? SortSeries { get; set; }
        /// <summary>
        /// Controls the visiblity of the grouped tooltip in a
        /// line chart across all series.
        /// </summary>
        [JsonProperty(PropertyName = "show_grouped_tooltip")]
        public bool? ShowGroupedTooltip { get; set; }
        /// <summary>
        /// Show the data in tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "show_data_in_tooltip")]
        public bool? ShowDataInTooltip { get; set; }
        /// <summary>
        /// Specifies the number of series to be displayed in a line chart. If no value is provided all the series will be
        /// displayed.
        /// </summary>
        [JsonProperty(PropertyName = "num_of_series_to_display")]
        public int? NumOfSeriesToDisplay { get; set; }
        /// <summary>
        /// Controls the visiblity of the data points on the line
        /// chart. If value is set to false data points wont be high-
        /// lighted on the lines.
        /// </summary>
        [JsonProperty(PropertyName = "show_data_points")]
        public bool? ShowDataPoints { get; set; }
    }
}
