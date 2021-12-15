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
    public class NSXTPolicyFirewallSessionTimerProfileBindingMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Sequence number is used to resolve conflicts when two profiles get applied
        /// to a single port. Lower value gets higher precedence. Two binding maps
        /// having the same profile path should have the same sequence number.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        [NSXTProperty(IsRequired: false, Description: @"Sequence number is used to resolve conflicts when two profiles get appliedto a single port. Lower value gets higher precedence. Two binding mapshaving the same profile path should have the same sequence number.")]
        public long? SequenceNumber { get; set; }
        /// <summary>
        /// PolicyPath of associated Firewall Timer Session Profile
        /// </summary>
        [JsonProperty(PropertyName = "firewall_session_timer_profile_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"PolicyPath of associated Firewall Timer Session Profile")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FirewallSessionTimerProfilePath { get; set; }
    }
}