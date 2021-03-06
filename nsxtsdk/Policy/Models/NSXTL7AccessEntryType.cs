using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTL7AccessEntryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The action to be applied to all the services.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL7AccessEntryActionEnumType Action { get; set; }
        /// <summary>
        /// Property containing attributes/sub-attributes for Policy L7 Access Profile.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        public IList<NSXTL7AccessAttributesType> Attributes { get; set; }
        /// <summary>
        /// Flag to disable the entry. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Determines the order of the entry in this profile. If no sequence number is
        /// specified in the payload, a value of 0 is assigned by default. If there are
        /// multiple rules with the same sequence number then their order is not deterministic.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
    }
}
