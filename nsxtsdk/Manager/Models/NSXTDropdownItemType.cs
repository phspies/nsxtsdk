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
    /// Dropdown item definition
    /// </summary>
    [NSXTProperty(Description: @"Dropdown item definition")]
    public class NSXTDropdownItemType 
    {
        /// <summary>
        /// An expression that represents the items of the dropdown filter.
        /// </summary>
        [JsonProperty(PropertyName = "field", Required = Required.AllowNull)]
        public string Field { get; set; }
        /// <summary>
        /// Property value is shown in the drop down input box for a filter. If the value is not provided 'display_name' property
        /// value is used.
        /// </summary>
        [JsonProperty(PropertyName = "short_display_name")]
        public string? ShortDisplayName { get; set; }
        /// <summary>
        /// expression to extract display name to be shown in the drop down.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// An additional key-value pair for item to be display in dropdown.
        /// </summary>
        [JsonProperty(PropertyName = "additional_value")]
        public object? AdditionalValue { get; set; }
        /// <summary>
        /// Value of filter inside dropdown filter.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
    }
}
