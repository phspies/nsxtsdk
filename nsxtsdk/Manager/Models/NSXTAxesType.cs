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
    /// Represents X and Y axes of a graph. For a multi-graph, the same axes are shared by all the graphs.
    /// </summary>
    [NSXTProperty(Description: @"Represents X and Y axes of a graph. For a multi-graph, the same axes are shared by all the graphs.")]
    public class NSXTAxesType 
    {
        /// <summary>
        /// A list of Y-Axis Labels with condition support. If needed, this property can be used to provide a list of y-axis label
        /// with condition support. For a label with single condition,'y-label' property can be used.
        /// </summary>
        [JsonProperty(PropertyName = "y_labels")]
        public IList<NSXTLabelType> YLabels { get; set; }
        /// <summary>
        /// A list of Y-Axis unit Labels with condition support. If needed, this property can be used to provide a list of y-axis
        /// unit label with condition support. This unit label can be used to display the point value along with units like
        /// percentage, milliseconds etc.
        /// </summary>
        [JsonProperty(PropertyName = "y_axis_unit_labels")]
        public IList<NSXTLabelType> YAxisUnitLabels { get; set; }
        /// <summary>
        /// A list of X-Axis Labels with condition support. If needed, this property can be used to provide a list of x-axis label
        /// with condition support. For a label with single condition,'x-label' property can be used.
        /// </summary>
        [JsonProperty(PropertyName = "x_labels")]
        public IList<NSXTLabelType> XLabels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "x_label")]
        public NSXTLabelType XLabel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "y_label")]
        public NSXTLabelType YLabel { get; set; }
        /// <summary>
        /// A list of Y-Axis unit with condition support. If needed, this property can be used to provide a list of y-axis unit with
        /// condition support. This unit could be like percentage, seconds, milliseconds etc.
        /// </summary>
        [JsonProperty(PropertyName = "y_axis_units")]
        public IList<NSXTAxisUnitType> YAxisUnits { get; set; }
    }
}
