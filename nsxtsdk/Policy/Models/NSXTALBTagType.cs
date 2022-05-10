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
    /// Advanced load balancer Tag object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer Tag object")]
    public class NSXTALBTagType 
    {
        /// <summary>
        /// Enum options - AVI_DEFINED, USER_DEFINED, VCENTER_DEFINED.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as USER_DEFINED.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtagTypeEnumType? Type { get; set; }
        /// <summary>
        /// value of Tag.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
    }
}
