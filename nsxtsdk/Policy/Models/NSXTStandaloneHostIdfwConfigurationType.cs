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
    public class NSXTStandaloneHostIdfwConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If set to true, Idfw is enabled for standalone hosts
        /// </summary>
        [JsonProperty(PropertyName = "idfw_enabled", Required = Required.AllowNull)]
        public bool IdfwEnabled { get; set; }
    }
}
