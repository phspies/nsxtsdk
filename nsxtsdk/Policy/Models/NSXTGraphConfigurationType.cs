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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGraphConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// x value type.
        /// </summary>
        [JsonProperty(PropertyName = "x_value_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGraphConfigurationXValueTypeEnumType? XValueType { get; set; }
        /// <summary>
        /// y value type.
        /// </summary>
        [JsonProperty(PropertyName = "y_value_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGraphConfigurationYValueTypeEnumType? YValueType { get; set; }
        /// <summary>
        /// Graphs
        /// </summary>
        [JsonProperty(PropertyName = "graphs", Required = Required.AllowNull)]
        public IList<NSXTGraphDefinitionType> Graphs { get; set; }
        /// <summary>
        /// List of line chart plotting configuration. This plotting configuration will be applicable for the LINE_GRAPH only.
        /// </summary>
        [JsonProperty(PropertyName = "line_chart_plot_configs")]
        public IList<NSXTLineChartPlotConfigurationType> LineChartPlotConfigs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "axes")]
        public NSXTAxesType Axes { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Describes the the type of graph. LINE_GRAPH shows a line graph chart BAR_GRAPH shows a simple bar graph chart
        /// STACKED_BAR_GRAPH shows a stacked bar graph chart
        /// </summary>
        [JsonProperty(PropertyName = "sub_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGraphConfigurationSubTypeEnumType? SubType { get; set; }
        /// <summary>
        /// If true, value of a point is shown as label on X axis. If false, value of point is not shown as label on X axis. false
        /// can be useful in situations where there are too many points and showing the X value as label can clutter the X axis.
        /// </summary>
        [JsonProperty(PropertyName = "display_x_value")]
        public bool? DisplayXValue { get; set; }
        /// <summary>
        /// An array of graphs colors which will be applied to each graph seperately. if number of provided colors are smaller than
        /// number of graph in the widget then colors are applied in circular manner.
        /// </summary>
        [JsonProperty(PropertyName = "graphs_colors")]
        public IList<string> GraphsColors { get; set; }
    }
}
