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
    public class NSXTChildPolicyLbPersistenceProfileType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual PolicyLbPersistenceProfile object
        /// </summary>
        [JsonProperty(PropertyName = "PolicyLbPersistenceProfile", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual PolicyLbPersistenceProfile object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPolicyLbPersistenceProfileType PolicyLbPersistenceProfile { get; set; }
    }
}