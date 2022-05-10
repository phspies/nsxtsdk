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
    /// Snat Translation.
    /// </summary>
    [NSXTProperty(Description: @"Snat Translation.")]
    public class NSXTLBSnatTranslationType 
    {
        /// <summary>
        /// Snat translation type.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbsnatTranslationTypeEnumType Type { get; set; }
    }
}
