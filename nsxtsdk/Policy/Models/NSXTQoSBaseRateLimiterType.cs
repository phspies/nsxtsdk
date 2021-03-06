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
    /// A Limiter configuration entry that specifies type and metrics
    /// </summary>
    [NSXTProperty(Description: @"A Limiter configuration entry that specifies type and metrics")]
    public class NSXTQoSBaseRateLimiterType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Type rate limiter
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTQoSbaseRateLimiterResourceTypeEnumType ResourceType { get; set; }
    }
}
