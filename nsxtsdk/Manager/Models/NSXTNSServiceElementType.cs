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
    /// An NSService element that describes traffic corresponding to an NSService
    /// </summary>
    [NSXTProperty(Description: @"An NSService element that describes traffic corresponding to an NSService")]
    public class NSXTNSServiceElementType 
    {
        /// <summary>
        /// The specific type of NSServiceElement
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsserviceElementResourceTypeEnumType ResourceType { get; set; }
    }
}
