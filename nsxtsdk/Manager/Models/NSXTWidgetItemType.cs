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
    /// Represents a reference to a widget that is held by a container or a multi-widget or a View.
    /// </summary>
    [NSXTProperty(Description: @"Represents a reference to a widget that is held by a container or a multi-widget or a View.")]
    public class NSXTWidgetItemType 
    {
        /// <summary>
        /// Represents the vertical span of the widget / container
        /// </summary>
        [JsonProperty(PropertyName = "rowspan")]
        public int? Rowspan { get; set; }
        /// <summary>
        /// If true, separates this widget in a container.
        /// </summary>
        [JsonProperty(PropertyName = "separator")]
        public bool? Separator { get; set; }
        /// <summary>
        /// Determines placement of widget or container relative to other widgets and containers. The lower the weight, the higher
        /// it is in the placement order.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
        /// <summary>
        /// Represents the horizontal span of the widget / container.
        /// </summary>
        [JsonProperty(PropertyName = "span")]
        public int? Span { get; set; }
        /// <summary>
        /// Id of the widget configuration that is held by a multi-widget or a container or a view.
        /// </summary>
        [JsonProperty(PropertyName = "widget_id", Required = Required.AllowNull)]
        public string WidgetId { get; set; }
        /// <summary>
        /// Aligns widget either left or right.
        /// </summary>
        [JsonProperty(PropertyName = "alignment")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTWidgetItemAlignmentEnumType? Alignment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
    }
}
