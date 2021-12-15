// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"Allowed operation")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPathPermissionGroupOperationEnumType Operation { get; set; }
        /// <summary>
        /// Full Object Path
        /// </summary>
        [JsonProperty(PropertyName = "object_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Full Object Path")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ObjectPath { get; set; }
    }
}
