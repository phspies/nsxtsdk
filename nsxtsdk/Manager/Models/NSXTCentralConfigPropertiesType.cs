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
    /// Central Config properties
    /// </summary>
    [NSXTProperty(Description: @"Central Config properties")]
    public class NSXTCentralConfigPropertiesType 
    {
        /// <summary>
        /// Override Central Config
        /// </summary>
        [JsonProperty(PropertyName = "local_override", Required = Required.AllowNull)]
        public bool LocalOverride { get; set; }
    }
}
