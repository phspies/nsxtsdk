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
    public class NSXTChildALBL4PolicySetType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual ALBL4PolicySet object.
        /// </summary>
        [JsonProperty(PropertyName = "ALBL4PolicySet", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual ALBL4PolicySet object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBL4PolicySetType ALBL4PolicySet { get; set; }
    }
}
