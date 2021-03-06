using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTServiceChainType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of ServiceInsertionServiceProfiles id. Reverse path service profiles are applied to egress traffic and is optional.
        /// 2 different set of profiles can be defined for forward and reverse path. If not defined, the reverse of the forward path
        /// service profile is applied.
        /// </summary>
        [JsonProperty(PropertyName = "reverse_path_service_profiles")]
        public IList<NSXTResourceReferenceType> ReversePathServiceProfiles { get; set; }
        /// <summary>
        /// Service attachment specifies the scope i.e Service plane at which the SVMs are deployed.
        /// </summary>
        [JsonProperty(PropertyName = "service_attachments", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> ServiceAttachments { get; set; }
        /// <summary>
        /// List of ServiceInsertionServiceProfiles that constitutes the the service chain. The forward path service profiles are
        /// applied to ingress traffic.
        /// </summary>
        [JsonProperty(PropertyName = "forward_path_service_profiles", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> ForwardPathServiceProfiles { get; set; }
        /// <summary>
        /// A unique id generated for every service chain. This is not a uuid.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_id")]
        public string? ServiceChainId { get; set; }
        /// <summary>
        /// Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load
        /// balancing considerations or flow pinning. LOCAL - means to prefer local service insances. REMOTE - preference is to
        /// redirect to the SVM co-located on the same host.
        /// </summary>
        [JsonProperty(PropertyName = "path_selection_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceChainPathSelectionPolicyEnumType? PathSelectionPolicy { get; set; }
        /// <summary>
        /// Failure policy for the service tells datapath, the action to take i.e to allow or block traffic during failure
        /// scenarios.
        /// </summary>
        [JsonProperty(PropertyName = "on_failure_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceChainOnFailurePolicyEnumType? OnFailurePolicy { get; set; }
    }
}
