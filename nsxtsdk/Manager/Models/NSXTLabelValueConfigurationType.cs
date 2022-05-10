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
    public class NSXTLabelValueConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "layout")]
        public NSXTLayoutType Layout { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// A sub-type of LabelValueConfiguration. If sub-type is not specified the parent type is rendered. For VERTICALLY_ALIGNED
        /// sub_type, the value is placed below the label. For HORIZONTALLY_ALIGNED sub_type, the value is placed right hand side of
        /// the label.
        /// </summary>
        [JsonProperty(PropertyName = "sub_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLabelValueConfigurationSubTypeEnumType? SubType { get; set; }
        /// <summary>
        /// An array of label-value properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties", Required = Required.AllowNull)]
        public IList<NSXTPropertyItemType> Properties { get; set; }
    }
}
