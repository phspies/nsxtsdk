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
    /// Resource metadata.
    /// </summary>
    [NSXTProperty(Description: @"Resource metadata.")]
    public class NSXTMPResourceMetadataType 
    {
        /// <summary>
        /// Resource metadata value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// It has to be one of the attribute of targeted policy intent.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
