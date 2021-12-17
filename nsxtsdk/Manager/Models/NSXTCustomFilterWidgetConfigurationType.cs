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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCustomFilterWidgetConfigurationType : NSXTFilterWidgetConfigurationType
    {
        public NSXTCustomFilterWidgetConfigurationType()
        {
        }
        /// <summary>
        /// User defined filter component selector to be rendered inside view/container.
        /// </summary>
        [JsonProperty(PropertyName = "ui_component_identifier", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"User defined filter component selector to be rendered inside view/container.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string UiComponentIdentifier { get; set; }
    }
}