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
    public class NSXTProfileBindingMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// PolicyPath of associated Profile
        /// </summary>
        [JsonProperty(PropertyName = "profile_path", Required = Required.AllowNull)]
        public string ProfilePath { get; set; }
    }
}
