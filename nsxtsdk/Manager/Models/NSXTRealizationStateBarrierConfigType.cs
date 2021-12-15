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
    public class NSXTRealizationStateBarrierConfigType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// The interval in milliseconds used for auto incrementing the barrier number
        /// </summary>
        [JsonProperty(PropertyName = "interval", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The interval in milliseconds used for auto incrementing the barrier number")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Interval { get; set; }
    }
}
