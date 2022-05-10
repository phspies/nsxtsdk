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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRealizationStateBarrierConfigType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// The interval in milliseconds used for auto incrementing the barrier number
        /// </summary>
        [JsonProperty(PropertyName = "interval", Required = Required.AllowNull)]
        public long Interval { get; set; }
    }
}
