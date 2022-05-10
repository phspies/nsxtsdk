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
    public class NSXTPolicyResourceReferenceType : NSXTResourceReferenceType
    {
        /// <summary>
        /// Absolute path of this object.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
    }
}
