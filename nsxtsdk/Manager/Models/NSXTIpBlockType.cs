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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpBlockType : NSXTManagedResourceType
    {
        /// <summary>
        /// Represents network address and the prefix length which will be associated with a layer-2 broadcast domain
        /// </summary>
        [JsonProperty(PropertyName = "cidr", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Represents network address and the prefix length which will be associated with a layer-2 broadcast domain")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cidr { get; set; }
    }
}