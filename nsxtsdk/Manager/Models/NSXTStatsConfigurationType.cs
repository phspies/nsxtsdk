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
    public class NSXTStatsConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "stat")]
        public NSXTStatItemType Stat { get; set; }
        /// <summary>
        /// Sections
        /// </summary>
        [JsonProperty(PropertyName = "sections")]
        public IList<NSXTDonutSectionType> Sections { get; set; }
        /// <summary>
        /// A sub-type of StatsConfiguration. If sub-type is not specified the parent type is rendered. The COMPACT sub_type,
        /// conserves the space for the widget. The statistic is placed on the right side on top of the status bar and the title of
        /// the widget is placed on the left side on the top of the status bar. The COMPACT style aligns itself horizontally as per
        /// the width of the container. If multiple widgets are placed insided the container then the widgets are placed one below
        /// the other to conserve the space.
        /// </summary>
        [JsonProperty(PropertyName = "sub_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTStatsConfigurationSubTypeEnumType? SubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public NSXTLabelType Label { get; set; }
    }
}
