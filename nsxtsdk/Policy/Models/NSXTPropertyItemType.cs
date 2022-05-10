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
    /// Represents a label-value pair.
    /// </summary>
    [NSXTProperty(Description: @"Represents a label-value pair.")]
    public class NSXTPropertyItemType 
    {
        /// <summary>
        /// A style object applicable for the property item. It could be the any padding, margin style sheet applicable to the
        /// property item. A 'style' property is supported in case of layout 'AUTO' only.
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public object? Style { get; set; }
        /// <summary>
        /// Represent the vertical span of the widget / container
        /// </summary>
        [JsonProperty(PropertyName = "rowspan")]
        public int? Rowspan { get; set; }
        /// <summary>
        /// Represent the horizontal span of the widget / container.
        /// </summary>
        [JsonProperty(PropertyName = "span")]
        public int? Span { get; set; }
        /// <summary>
        /// Label value separator used between label and value. It can be any separator like ":"  or "-".
        /// </summary>
        [JsonProperty(PropertyName = "label_value_separator")]
        public string? LabelValueSeparator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
        /// <summary>
        /// Represents field value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        public string Field { get; set; }
        /// <summary>
        /// If true, separates this property in a widget.
        /// </summary>
        [JsonProperty(PropertyName = "separator")]
        public bool? Separator { get; set; }
        /// <summary>
        /// Data type of the field.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPropertyItemTypeEnumType Type { get; set; }
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget. A widget is considered as drilldown
        /// widget when it is associated with any other widget and provides more detailed information about any data item from the
        /// parent widget.
        /// </summary>
        [JsonProperty(PropertyName = "drilldown_id")]
        public string? DrilldownId { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details. This will be linked with value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// Set to true if the field is a heading. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "heading")]
        public bool? Heading { get; set; }
        /// <summary>
        /// If the condition is met then the property will be displayed. Examples of expression syntax are provided under
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// Render configuration to be applied, if any.
        /// </summary>
        [JsonProperty(PropertyName = "render_configuration")]
        public IList<NSXTRenderConfigurationType> RenderConfiguration { get; set; }
    }
}
