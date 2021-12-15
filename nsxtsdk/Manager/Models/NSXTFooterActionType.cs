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
    /// Action specified at the footer of a widget to provide additional information or to provide a clickable url for
        /// navigation. An example usage of footer action is provided under the 'example_request' section of
        /// 'CreateWidgetConfiguration' API.
    /// </summary>
    [NSXTProperty(Description: @"Action specified at the footer of a widget to provide additional information or to provide a clickable url for navigation. An example usage of footer action is provided under the &apos;example_request&apos; section of &apos;CreateWidgetConfiguration&apos; API.")]
    public class NSXTFooterActionType 
    {
        /// <summary>
        /// Hyperlink to the UI page that provides details of action.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        [NSXTProperty(IsRequired: false, Description: @"Hyperlink to the UI page that provides details of action.")]
        public string? Url { get; set; }
        /// <summary>
        /// If true, the footer will appear in the underlying container that holds the widget.
        /// </summary>
        [JsonProperty(PropertyName = "dock_to_container_footer")]
        [NSXTProperty(IsRequired: false, Description: @"If true, the footer will appear in the underlying container that holds the widget.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DockToContainerFooter { get; set; }
        /// <summary>
        /// Label to be displayed against the footer action.
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Label to be displayed against the footer action.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLabelType Label { get; set; }
    }
}
