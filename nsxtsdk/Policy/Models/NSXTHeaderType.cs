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
    /// Header of a widget that provides additional information. This will be shown at the container level. It includes details
        /// as label value pairs.
    /// </summary>
    [NSXTProperty(Description: @"Header of a widget that provides additional information. This will be shown at the container level. It includes details as label value pairs.")]
    public class NSXTHeaderType 
    {
        /// <summary>
        /// Alignment of header labels.
        /// </summary>
        [JsonProperty(PropertyName = "content_alignment")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHeaderContentAlignmentEnumType? ContentAlignment { get; set; }
        /// <summary>
        /// An array of widgets which will appear inside the container header Instead of 'sub_headers' property use this property.
        /// </summary>
        [JsonProperty(PropertyName = "sub_header_widgets")]
        public IList<NSXTWidgetItemType> SubHeaderWidgets { get; set; }
        /// <summary>
        /// If the condition is met then the header will be applied. Examples of expression syntax are provided under
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// An array of label-value properties. This field is deprecated instead used 'sub_header_widgets' property to define header
        /// widgets.
        /// </summary>
        [JsonProperty(PropertyName = "sub_headers")]
        public IList<NSXTPropertyItemType> SubHeaders { get; set; }
    }
}
