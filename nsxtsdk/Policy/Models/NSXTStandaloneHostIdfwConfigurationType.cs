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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTStandaloneHostIdfwConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If set to true, Idfw is enabled for standalone hosts
        /// </summary>
        [JsonProperty(PropertyName = "idfw_enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If set to true, Idfw is enabled for standalone hosts")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IdfwEnabled { get; set; }
    }
}
