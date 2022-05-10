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
    /// Footer of a widget that provides additional information or allows an action such as clickable url for navigation. An
        /// example usage of footer is provided under 'example_request' section of 'CreateWidgetConfiguration' API.
    /// </summary>
    [NSXTProperty(Description: @"Footer of a widget that provides additional information or allows an action such as clickable url for navigation. An example usage of footer is provided under &apos;example_request&apos; section of &apos;CreateWidgetConfiguration&apos; API.")]
    public class NSXTFooterType 
    {
        /// <summary>
        /// If the condition is met then the footer will be applied. Examples of expression syntax are provided under
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string? Condition { get; set; }
        /// <summary>
        /// Action to be performed at the footer of a widget. An action at the footer can be simple text description or a hyperlink
        /// to a UI page. Action allows a clickable url for navigation. An example usage of footer action is provided under
        /// 'example_request' section of 'CreateWidgetConfiguration' API.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<NSXTFooterActionType> Actions { get; set; }
    }
}
