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
    /// Attribute specific to a partner. There attributes are passed on to the partner appliance and is opaque to the NSX
        /// Manager. The Attributes used by the partner applicance.
    /// </summary>
    [NSXTProperty(Description: @"Attribute specific to a partner. There attributes are passed on to the partner appliance and is opaque to the NSX Manager. The Attributes used by the partner applicance.")]
    public class NSXTAttributeType 
    {
        /// <summary>
        /// Read only Attribute cannot be overdidden by service instance/deployment.
        /// </summary>
        [JsonProperty(PropertyName = "read_only")]
        public bool? ReadOnly { get; set; }
        /// <summary>
        /// Attribute Type can be of any of the allowed enum type.
        /// </summary>
        [JsonProperty(PropertyName = "attribute_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAttributeAttributeTypeEnumType? AttributeType { get; set; }
        /// <summary>
        /// Attribute display name string value.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Attribute value string value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// Attribute key string value.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
