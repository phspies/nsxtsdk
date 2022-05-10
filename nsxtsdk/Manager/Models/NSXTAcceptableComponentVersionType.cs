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
    public class NSXTAcceptableComponentVersionType : NSXTVersionListType
    {
        /// <summary>
        /// Node type
        /// </summary>
        [JsonProperty(PropertyName = "component_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAcceptableComponentVersionComponentTypeEnumType ComponentType { get; set; }
    }
}
