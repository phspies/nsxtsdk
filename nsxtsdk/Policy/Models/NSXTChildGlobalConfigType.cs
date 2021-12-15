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
    public class NSXTChildGlobalConfigType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual GlobalConfig object.
        /// </summary>
        [JsonProperty(PropertyName = "GlobalConfig", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual GlobalConfig object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTGlobalConfigType GlobalConfig { get; set; }
    }
}
