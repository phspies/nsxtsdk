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
    public class NSXTChildIPFIXDFWProfileType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual IPFIXDFWProfile object
        /// </summary>
        [JsonProperty(PropertyName = "IPFIXDFWProfile", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual IPFIXDFWProfile object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIPFIXDFWProfileType IPFIXDFWProfile { get; set; }
    }
}
