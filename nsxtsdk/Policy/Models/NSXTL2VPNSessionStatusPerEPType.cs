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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("L2VPNSessionStatusNsxT", typeof(NSXTL2VPNSessionStatusNsxTType))]
    [NSXTProperty(Description: @"")]
    public class NSXTL2VPNSessionStatusPerEPType : NSXTPolicyRuntimeInfoPerEPType
    {
        public NSXTL2VPNSessionStatusPerEPType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTL2VpnsessionStatusPerEPResourceTypeEnumType ResourceType { get; set; }
    }
}
