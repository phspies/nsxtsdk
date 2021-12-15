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
    public class NSXTGroupDiscoveryProfileBindingMapType : NSXTProfileBindingMapType
    {
        /// <summary>
        /// Sequence number used to resolve conflicts betweeen two profiles applied on
        /// the same group. Lower sequence number takes higher precedence. Two binding
        /// maps applied to the same profile must have the same sequence number.
        /// User defined sequence numbers range from 1 through 100,000.
        /// System defined sequence numbers range from 100,001 through 200,000.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        [NSXTProperty(IsRequired: false, Description: @"Sequence number used to resolve conflicts betweeen two profiles applied onthe same group. Lower sequence number takes higher precedence. Two bindingmaps applied to the same profile must have the same sequence number.User defined sequence numbers range from 1 through 100,000.System defined sequence numbers range from 100,001 through 200,000.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(100000)]
        public long? SequenceNumber { get; set; }
    }
}
