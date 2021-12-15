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
    public class NSXTChildPolicyLabelType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual PolicyLabel object
        /// </summary>
        [JsonProperty(PropertyName = "PolicyLabel", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual PolicyLabel object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPolicyLabelType PolicyLabel { get; set; }
    }
}
