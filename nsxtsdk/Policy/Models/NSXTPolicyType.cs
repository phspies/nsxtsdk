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
    public class NSXTPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// - Distributed Firewall -
        /// Policy framework provides five pre-defined categories for classifying
        /// a security policy. They are "Ethernet","Emergency", "Infrastructure"
        /// "Environment" and "Application". There is a pre-determined order in
        /// which the policy framework manages the priority of these security
        /// policies. Ethernet category is for supporting layer 2 firewall rules.
        /// The other four categories are applicable for layer 3 rules. Amongst
        /// them, the Emergency category has the highest priority followed by
        /// Infrastructure, Environment and then Application rules. Administrator
        /// can choose to categorize a security policy into the above categories
        /// or can choose to leave it empty. If empty it will have the least
        /// precedence w.r.t the above four categories.
        /// - Edge Firewall -
        /// Policy Framework for Edge Firewall provides six pre-defined categories
        /// "Emergency", "SystemRules", "SharedPreRules", "LocalGatewayRules",
        /// "AutoServiceRules" and "Default", in order of priority of rules.
        /// All categories are allowed for Gatetway Policies that belong
        /// to 'default' Domain. However, for user created domains, category is
        /// restricted to "SharedPreRules" or "LocalGatewayRules" only. Also, the
        /// users can add/modify/delete rules from only the "SharedPreRules" and
        /// "LocalGatewayRules" categories. If user doesn't specify the category
        /// then defaulted to "Rules". System generated category is used by NSX
        /// created rules, for example BFD rules. Autoplumbed category used by
        /// NSX verticals to autoplumb data path rules. Finally, "Default" category
        /// is the placeholder default rules with lowest in the order of priority.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string? Category { get; set; }
        /// <summary>
        /// A flag to indicate whether policy is a default policy.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Indicates whether a security policy should be locked. If the
        /// security policy is locked by a user, then no other user would
        /// be able to modify this security policy. Once the user releases
        /// the lock, other users can update this security policy.
        /// </summary>
        [JsonProperty(PropertyName = "locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// ID of the user who last modified the lock for the secruity policy.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_by")]
        public string? LockModifiedBy { get; set; }
        /// <summary>
        /// SecurityPolicy locked/unlocked time in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_time")]
        public long? LockModifiedTime { get; set; }
        /// <summary>
        /// The count of rules in the policy.
        /// </summary>
        [JsonProperty(PropertyName = "rule_count")]
        public int? RuleCount { get; set; }
        /// <summary>
        /// Comments for security policy lock/unlock.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string? Comments { get; set; }
        /// <summary>
        /// This field is to indicate the internal sequence number of a policy
        /// with respect to the policies across categories.
        /// </summary>
        [JsonProperty(PropertyName = "internal_sequence_number")]
        public int? InternalSequenceNumber { get; set; }
        /// <summary>
        /// Stateful or Stateless nature of security policy is enforced on all
        /// rules in this security policy. When it is stateful, the state of
        /// the network connects are tracked and a stateful packet inspection is
        /// performed.
        /// Layer3 security policies can be stateful or stateless. By default, they are stateful.
        /// Layer2 security policies can only be stateless.
        /// </summary>
        [JsonProperty(PropertyName = "stateful")]
        public bool? Stateful { get; set; }
        /// <summary>
        /// Provides a mechanism to apply the rules in this policy for a specified
        /// time duration.
        /// </summary>
        [JsonProperty(PropertyName = "scheduler_path")]
        public string? SchedulerPath { get; set; }
        /// <summary>
        /// Ensures that a 3 way TCP handshake is done before the data packets
        /// are sent.
        /// tcp_strict=true is supported only for stateful security policies.
        /// If the tcp_strict flag is not specified and the security policy
        /// is stateful, then tcp_strict will be set to true.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_strict")]
        public bool? TcpStrict { get; set; }
        /// <summary>
        /// The list of group paths where the rules in this policy will get
        /// applied. This scope will take precedence over rule level scope.
        /// Supported only for security and redirection policies. In case of
        /// RedirectionPolicy, it is expected only when the policy is NS and
        /// redirecting to service chain.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between security policies
        /// across domains. In order to change the sequence number of a policy
        /// one can fire a POST request on the policy entity with
        /// a query parameter action=revise
        /// The sequence number field will reflect the value of the computed
        /// sequence number upon execution of the above mentioned POST request.
        /// For scenarios where the administrator is using a template to update
        /// several security policies, the only way to set the sequence number is
        /// to explicitly specify the sequence number for each security policy.
        /// If no sequence number is specified in the payload, a value of 0 is
        /// assigned by default. If there are multiple policies with the same
        /// sequence number then their order is not deterministic. If a specific
        /// order of policies is desired, then one has to specify unique sequence
        /// numbers or use the POST request on the policy entity with
        /// a query parameter action=revise to let the framework assign a
        /// sequence number.
        /// The value of sequence number must be between 0 and 999,999.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
    }
}
