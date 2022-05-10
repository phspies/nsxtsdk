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
    /// Policy expression for NSGroup membership
    /// </summary>
    [NSXTProperty(Description: @"Policy expression for NSGroup membership")]
    public class NSXTNSGroupExpressionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupExpressionResourceTypeEnumType ResourceType { get; set; }
    }
}
