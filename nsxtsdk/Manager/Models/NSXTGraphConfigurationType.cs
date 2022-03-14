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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGraphConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// x value type.
        /// </summary>
        public NSXTGraphConfigurationXValueTypeEnumType? XValueType { get; set; }
        /// <summary>
        /// y value type.
        /// </summary>
        public NSXTGraphConfigurationYValueTypeEnumType? YValueType { get; set; }
        /// <summary>
        /// Graphs
        /// </summary>
        [JsonProperty(PropertyName = "graphs", Required = Required.AllowNull)]
        public IList<NSXTGraphDefinitionType> Graphs { get; set; }
        /// <summary>
        /// List of line chart plotting configuration. This plotting configuration will be applicable for the LINE_GRAPH only.
        /// </summary>
        public IList<NSXTLineChartPlotConfigurationType> LineChartPlotConfigs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTAxesType Axes { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        public string? Navigation { get; set; }
        /// <summary>
        /// Describes the the type of graph. LINE_GRAPH shows a line graph chart BAR_GRAPH shows a simple bar graph chart
        /// STACKED_BAR_GRAPH shows a stacked bar graph chart
        /// </summary>
        public NSXTGraphConfigurationSubTypeEnumType? SubType { get; set; }
        /// <summary>
        /// If true, value of a point is shown as label on X axis. If false, value of point is not shown as label on X axis. false
        /// can be useful in situations where there are too many points and showing the X value as label can clutter the X axis.
        /// </summary>
        public bool? DisplayXValue { get; set; }
        /// <summary>
        /// An array of graphs colors which will be applied to each graph seperately. if number of provided colors are smaller than
        /// number of graph in the widget then colors are applied in circular manner.
        /// </summary>
        public IList<string> GraphsColors { get; set; }
    }
}
