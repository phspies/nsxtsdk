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
    public class NSXTLegendWidgetConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "layout", Required = Required.AllowNull)]
        public NSXTLegendType Layout { get; set; }
        /// <summary>
        /// Id of source widget, if any. Id should be a valid id of an existing widget. This property can be used to identify the
        /// source of the data for this legend widget.
        /// </summary>
        [JsonProperty(PropertyName = "source_widget_id", Required = Required.AllowNull)]
        public string SourceWidgetId { get; set; }
    }
}
