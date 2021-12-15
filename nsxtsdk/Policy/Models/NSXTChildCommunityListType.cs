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
    public class NSXTChildCommunityListType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual CommunityList object
        /// </summary>
        [JsonProperty(PropertyName = "CommunityList", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual CommunityList object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTCommunityListType CommunityList { get; set; }
    }
}