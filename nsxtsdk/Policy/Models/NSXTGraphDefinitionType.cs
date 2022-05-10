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
    /// Defines a graph
    /// </summary>
    [NSXTProperty(Description: @"Defines a graph")]
    public class NSXTGraphDefinitionType 
    {
        /// <summary>
        /// An expression that represents the series of the graph
        /// </summary>
        [JsonProperty(PropertyName = "row_list_field")]
        public string? RowListField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "point_definition", Required = Required.AllowNull)]
        public NSXTPointDefinitionType PointDefinition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
        /// <summary>
        /// Identifier of graph. It can be used to differentiate multiple graph series present in GraphWidgetConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Additional rendering or conditional evaluation of the field values to be performed, if any.
        /// </summary>
        [JsonProperty(PropertyName = "render_configuration")]
        public IList<NSXTRenderConfigurationType> RenderConfiguration { get; set; }
    }
}
