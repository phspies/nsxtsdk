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
    public class NSXTChildPrefixListType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual PrefixList object.
        /// </summary>
        [JsonProperty(PropertyName = "PrefixList", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual PrefixList object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPrefixListType PrefixList { get; set; }
    }
}
