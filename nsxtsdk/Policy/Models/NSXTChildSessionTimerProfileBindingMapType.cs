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
        public NSXTChildSessionTimerProfileBindingMapType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "SessionTimerProfileBindingMap", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap { get; set; }
    }
}
