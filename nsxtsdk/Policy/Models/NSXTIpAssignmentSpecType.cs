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
    /// Abstract base type for specification of IPs to be used with host switch virtual tunnel endpoints
    /// </summary>
    [NSXTProperty(Description: @"Abstract base type for specification of IPs to be used with host switch virtual tunnel endpoints")]
    public class NSXTIpAssignmentSpecType 
    {
        public NSXTIpAssignmentSpecType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIpAssignmentSpecResourceTypeEnumType ResourceType { get; set; }
    }
}