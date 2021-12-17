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
    public class NSXTL7AccessEntryType : NSXTPolicyConfigResourceType
    {
        public NSXTL7AccessEntryType()
        {
        }
        /// <summary>
        /// The action to be applied to all the services.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The action to be applied to all the services.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTL7AccessEntryActionEnumType Action { get; set; }
        /// <summary>
        /// Property containing attributes/sub-attributes for Policy L7 Access Profile.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Property containing attributes/sub-attributes for Policy L7 Access Profile.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTL7AccessAttributesType> Attributes { get; set; }
        /// <summary>
        /// Flag to disable the entry. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to disable the entry. Default is enabled.")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable packet logging. Default is disabled.")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Determines the order of the entry in this profile. If no sequence number is
        /// specified in the payload, a value of 0 is assigned by default. If there are
        /// multiple rules with the same sequence number then their order is not deterministic.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        [NSXTProperty(IsRequired: false, Description: @"Determines the order of the entry in this profile. If no sequence number isspecified in the payload, a value of 0 is assigned by default. If there aremultiple rules with the same sequence number then their order is not deterministic.")]
        public int? SequenceNumber { get; set; }
    }
}