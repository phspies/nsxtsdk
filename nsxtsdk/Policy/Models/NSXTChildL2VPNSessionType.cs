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
    public class NSXTChildL2VPNSessionType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual L2VPNSession object.
        /// </summary>
        [JsonProperty(PropertyName = "L2VPNSession", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual L2VPNSession object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTL2VPNSessionType L2VPNSession { get; set; }
    }
}
