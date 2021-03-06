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
    public class NSXTPolicyTransportZoneProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Policy Transport Zone Type.
        /// </summary>
        [JsonProperty(PropertyName = "tz_profile_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyTransportZoneProfileTzProfileTypeEnumType TzProfileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_config", Required = Required.AllowNull)]
        public NSXTBfdHealthMonitoringConfigType BfdConfig { get; set; }
    }
}
