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
    public class NSXTDropdownFilterPlotConfigurationType : NSXTWidgetPlotConfigurationType
    {
        /// <summary>
        /// Allow search on drop down filter.
        /// </summary>
        [JsonProperty(PropertyName = "allow_search")]
        public bool? AllowSearch { get; set; }
    }
}
