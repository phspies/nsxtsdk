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
    public class NSXTInventoryConfigType 
    {
        /// <summary>
        /// Soft limit on number of compute managers, which can be added, beyond which,
        /// addition of compute managers will result in warning getting logged
        /// </summary>
        [JsonProperty(PropertyName = "compute_managers_soft_limit", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Soft limit on number of compute managers, which can be added, beyond which,addition of compute managers will result in warning getting logged")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ComputeManagersSoftLimit { get; set; }
    }
}