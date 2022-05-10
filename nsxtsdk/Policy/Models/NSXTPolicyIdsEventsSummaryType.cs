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
    /// Intrusion event with all the event and signature details, each event
        /// contains the signature id, name, severity, first and recent occurence,
        /// users and VMs affected and other signature metadata.
    /// </summary>
    [NSXTProperty(Description: @"Intrusion event with all the event and signature details, each eventcontains the signature id, name, severity, first and recent occurence,users and VMs affected and other signature metadata.")]
    public class NSXTPolicyIdsEventsSummaryType 
    {
        /// <summary>
        /// First occurence of the intrusion, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "first_occurence")]
        public long? FirstOccurence { get; set; }
        /// <summary>
        /// Count of workload IPs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "affected_ip_count")]
        public long? AffectedIpCount { get; set; }
        /// <summary>
        /// Latest occurence of the intrusion, in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "latest_occurence")]
        public long? LatestOccurence { get; set; }
        /// <summary>
        /// Number of times this particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public long? TotalCount { get; set; }
        /// <summary>
        /// List of users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "user_details")]
        public object? UserDetails { get; set; }
        /// <summary>
        /// IDS event flow data specific to each IDS event. The data includes source ip, source port, destination ip, destination
        /// port, and protocol.
        /// </summary>
        [JsonProperty(PropertyName = "ids_flow_details")]
        public object? IdsFlowDetails { get; set; }
        /// <summary>
        /// Indicates if the rule id is valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "is_rule_valid")]
        public bool? IsRuleValid { get; set; }
        /// <summary>
        /// Metadata about the detected signature including name, id, severity, product affected, protocol etc.
        /// </summary>
        [JsonProperty(PropertyName = "signature_metadata")]
        public object? SignatureMetadata { get; set; }
        /// <summary>
        /// List of VMs on which a particular signature was detected with the count.
        /// </summary>
        [JsonProperty(PropertyName = "vm_details")]
        public object? VmDetails { get; set; }
        /// <summary>
        /// Signature ID pertaining to the detected intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        public long? SignatureId { get; set; }
        /// <summary>
        /// The IDS Rule id that detected this particular intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public long? RuleId { get; set; }
        /// <summary>
        /// Flag indicating an ongoing intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "is_ongoing")]
        public bool? IsOngoing { get; set; }
        /// <summary>
        /// Count of VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "affected_vm_count")]
        public long? AffectedVmCount { get; set; }
        /// <summary>
        /// IDSEvent resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
    }
}
