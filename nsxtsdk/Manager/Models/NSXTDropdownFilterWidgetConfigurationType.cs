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
    public class NSXTDropdownFilterWidgetConfigurationType : NSXTFilterWidgetConfigurationType
    {
        /// <summary>
        /// Expression to specify default value of filter.
        /// </summary>
        [JsonProperty(PropertyName = "default_value")]
        public string? DefaultValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dropdown_filter_plot_config")]
        public NSXTDropdownFilterPlotConfigurationType DropdownFilterPlotConfig { get; set; }
        /// <summary>
        /// Placeholder message to be displayed in dropdown filter.
        /// </summary>
        [JsonProperty(PropertyName = "placeholder_msg")]
        public string? PlaceholderMsg { get; set; }
        /// <summary>
        /// Additional static items to be added in dropdown filter. Example can be 'ALL'.
        /// </summary>
        [JsonProperty(PropertyName = "static_filters")]
        public IList<NSXTStaticFilterType> StaticFilters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dropdown_item")]
        public NSXTDropdownItemType DropdownItem { get; set; }
        /// <summary>
        /// If the condition is met then the static filter will be added. If no condition is provided, then the static filters will
        /// be applied unconditionally.
        /// </summary>
        [JsonProperty(PropertyName = "static_filter_condition")]
        public string? StaticFilterCondition { get; set; }
    }
}
