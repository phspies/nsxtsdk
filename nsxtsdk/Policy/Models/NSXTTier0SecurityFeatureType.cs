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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTier0SecurityFeatureType : NSXTSecurityFeatureBaseType
    {
        /// <summary>
        /// Feature to be enabled/disabled.
        /// IDFW - Identity Firewall
        /// Use any one of this to enable/disabe it.
        /// </summary>
        [JsonProperty(PropertyName = "feature", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTier0SecurityFeatureFeatureEnumType Feature { get; set; }
    }
}
