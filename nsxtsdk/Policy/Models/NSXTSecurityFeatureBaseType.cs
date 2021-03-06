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
    /// Security Feature feature entity
    /// </summary>
    [NSXTProperty(Description: @"Security Feature feature entity")]
    public class NSXTSecurityFeatureBaseType 
    {
        /// <summary>
        /// true - enable the feature, false - disable the feture
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        public bool Enable { get; set; }
    }
}
