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
    /// RBAC Objects qualifier
    /// </summary>
    [NSXTProperty(Description: @"RBAC Objects qualifier")]
    public class NSXTPathPermissionGroupType 
    {
        /// <summary>
        /// Allowed operation
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPathPermissionGroupOperationEnumType Operation { get; set; }
        /// <summary>
        /// Full Object Path
        /// </summary>
        [JsonProperty(PropertyName = "object_path", Required = Required.AllowNull)]
        public string ObjectPath { get; set; }
    }
}
