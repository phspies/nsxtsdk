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
    /// Intrusion event with all the event and signature details, each event
        /// contains the signature id, name, severity, first and recent occurence,
        /// users and VMs affected and other signature metadata.
    /// </summary>
    [NSXTProperty(Description: @"Intrusion event with all the event and signature details, each eventcontains the signature id, name, severity, first and recent occurence,users and VMs affected and other signature metadata.")]
    public class NSXTPolicyIdsEventsSummaryType 
    {
        public NSXTPolicyIdsEventsSummaryType()
        {
        }
        /// <summary>
        /// First occurence of the intrusion, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "first_occurence")]
        [NSXTProperty(IsRequired: false, Description: @"First occurence of the intrusion, in epoch milliseconds.")]
        public long? FirstOccurence { get; set; }
        /// <summary>
        /// Count of workload IPs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "affected_ip_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of workload IPs on which a particular signature was detected.")]
        public long? AffectedIpCount { get; set; }
        /// <summary>
        /// Latest occurence of the intrusion, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "latest_occurence")]
        [NSXTProperty(IsRequired: false, Description: @"Latest occurence of the intrusion, in epoch milliseconds.")]
        public long? LatestOccurence { get; set; }
        /// <summary>
        /// Number of times this particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of times this particular signature was detected.")]
        public long? TotalCount { get; set; }
        /// <summary>
        /// List of users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "user_details")]
        [NSXTProperty(IsRequired: false, Description: @"List of users logged into VMs on which a particular signature was detected.")]
        public object? UserDetails { get; set; }
        /// <summary>
        /// IDS event flow data specific to each IDS event. The data includes source ip, source port, destination ip, destination
        /// port, and protocol.
        /// </summary>
        [JsonProperty(PropertyName = "ids_flow_details")]
        [NSXTProperty(IsRequired: false, Description: @"IDS event flow data specific to each IDS event. The data includes source ip, source port, destination ip, destination port, and protocol.")]
        public object? IdsFlowDetails { get; set; }
        /// <summary>
        /// Indicates if the rule id is valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "is_rule_valid")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates if the rule id is valid or not.")]
        public bool? IsRuleValid { get; set; }
        /// <summary>
        /// Metadata about the detected signature including name, id, severity, product affected, protocol etc.
        /// </summary>
        [JsonProperty(PropertyName = "signature_metadata")]
        [NSXTProperty(IsRequired: false, Description: @"Metadata about the detected signature including name, id, severity, product affected, protocol etc.")]
        public object? SignatureMetadata { get; set; }
        /// <summary>
        /// List of VMs on which a particular signature was detected with the count.
        /// </summary>
        [JsonProperty(PropertyName = "vm_details")]
        [NSXTProperty(IsRequired: false, Description: @"List of VMs on which a particular signature was detected with the count.")]
        public object? VmDetails { get; set; }
        /// <summary>
        /// Signature ID pertaining to the detected intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        [NSXTProperty(IsRequired: false, Description: @"Signature ID pertaining to the detected intrusion.")]
        public long? SignatureId { get; set; }
        /// <summary>
        /// The IDS Rule id that detected this particular intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"The IDS Rule id that detected this particular intrusion.")]
        public long? RuleId { get; set; }
        /// <summary>
        /// Flag indicating an ongoing intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "is_ongoing")]
        [NSXTProperty(IsRequired: false, Description: @"Flag indicating an ongoing intrusion.")]
        public bool? IsOngoing { get; set; }
        /// <summary>
        /// Count of VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "affected_vm_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of VMs on which a particular signature was detected.")]
        public long? AffectedVmCount { get; set; }
        /// <summary>
        /// IDSEvent resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        [NSXTProperty(IsRequired: false, Description: @"IDSEvent resource type.")]
        public string? ResourceType { get; set; }
    }
}
