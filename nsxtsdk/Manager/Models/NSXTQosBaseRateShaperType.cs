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
    /// A shaper configuration entry that specifies type and metrics
    /// </summary>
    [NSXTProperty(Description: @"A shaper configuration entry that specifies type and metrics")]
    public class NSXTQosBaseRateShaperType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTQosBaseRateShaperResourceTypeEnumType ResourceType { get; set; }
    }
}
