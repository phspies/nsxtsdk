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
    /// The HostSwitchSpec is the base class for standard and preconfigured
        /// host switch specifications.
    /// </summary>
    [NSXTProperty(Description: @"The HostSwitchSpec is the base class for standard and preconfiguredhost switch specifications.")]
    public class NSXTHostSwitchSpecType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostSwitchSpecResourceTypeEnumType ResourceType { get; set; }
    }
}
