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
    public class NSXTChildSessionTimerProfileBindingMapType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual SessionTimerProfileBindingMap object
        /// </summary>
        [JsonProperty(PropertyName = "SessionTimerProfileBindingMap", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual SessionTimerProfileBindingMap object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap { get; set; }
    }
}