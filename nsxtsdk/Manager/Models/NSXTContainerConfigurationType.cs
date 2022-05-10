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
    public class NSXTContainerConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// If not specified, creates an empty container.
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public IList<NSXTWidgetItemType> Widgets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "layout")]
        public NSXTLayoutType Layout { get; set; }
        /// <summary>
        /// Labels for the container.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTLabelType> Labels { get; set; }
        /// <summary>
        /// Hyperlink of the specified UI page that provides details.
        /// </summary>
        [JsonProperty(PropertyName = "navigation")]
        public string? Navigation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        public NSXTHeaderType Header { get; set; }
    }
}
