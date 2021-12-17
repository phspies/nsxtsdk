// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Represents a list of widget configurations.
    /// </summary>
    [NSXTProperty(Description: @"Represents a list of widget configurations.")]
    public class NSXTWidgetConfigurationListType 
    {
        public NSXTWidgetConfigurationListType()
        {
        }
        /// <summary>
        /// Array of widget configurations
        /// </summary>
        [JsonProperty(PropertyName = "widgetconfigurations")]
        [NSXTProperty(IsRequired: false, Description: @"Array of widget configurations")]
        public IList<NSXTWidgetConfigurationType> Widgetconfigurations { get; set; }
    }
}
