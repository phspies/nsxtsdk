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
    /// Abstract base type for specification of IPs to be used with host switch virtual tunnel endpoints
    /// </summary>
    [NSXTProperty(Description: @"Abstract base type for specification of IPs to be used with host switch virtual tunnel endpoints")]
    public class NSXTIpAssignmentSpecType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpAssignmentSpecResourceTypeEnumType ResourceType { get; set; }
    }
}
