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
    public class NSXTPolicyFirewallFloodProtectionProfileBindingMapType : NSXTProfileBindingMapType
    {
        public NSXTPolicyFirewallFloodProtectionProfileBindingMapType()
        {
        }
        /// <summary>
        /// Sequence number is used to resolve conflicts when two profiles get
        /// applied to a single port. Lower value gets higher precedence. Two
        /// binding maps having the same profile path should have the same sequence
        /// number.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Sequence number is used to resolve conflicts when two profiles getapplied to a single port. Lower value gets higher precedence. Twobinding maps having the same profile path should have the same sequencenumber.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long SequenceNumber { get; set; }
    }
}
