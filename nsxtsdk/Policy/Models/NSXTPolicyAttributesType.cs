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
    /// Policy Attributes data holder
    /// </summary>
    [NSXTProperty(Description: @"Policy Attributes data holder")]
    public class NSXTPolicyAttributesType 
    {
        /// <summary>
        /// Reference to sub attributes for the attribute
        /// </summary>
        [JsonProperty(PropertyName = "sub_attributes")]
        public IList<NSXTPolicySubAttributesType> SubAttributes { get; set; }
        /// <summary>
        /// Source of attribute value i.e whether system defined or custom value
        /// </summary>
        [JsonProperty(PropertyName = "attribute_source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyAttributesAttributeSourceEnumType? AttributeSource { get; set; }
        /// <summary>
        /// Description for attribute value
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// URL_Reputation is currently not available. Please do not use it in Attribute Key while creating context profile
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyAttributesKeyEnumType Key { get; set; }
        /// <summary>
        /// Datatype for attribute
        /// </summary>
        [JsonProperty(PropertyName = "datatype", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyAttributesDatatypeEnumType Datatype { get; set; }
        /// <summary>
        /// Describes whether the APP_ID value is ALG type or not.
        /// </summary>
        [JsonProperty(PropertyName = "isALGType")]
        public bool? IsALGType { get; set; }
        /// <summary>
        /// Multiple attribute values can be specified as elements of array.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public IList<string> Value { get; set; }
        /// <summary>
        /// This is optional part that can hold additional data about the attribute key/values.
        /// Example - For URL CATEGORY key , it specified super category for url category value.
        /// This is generic array and can hold multiple meta information about key/values in future
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTContextProfileAttributesMetadataType> Metadata { get; set; }
    }
}
