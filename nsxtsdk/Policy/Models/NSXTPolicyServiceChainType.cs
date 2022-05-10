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
    public class NSXTPolicyServiceChainType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Reverse path service profiles are applied to egress traffic and is optional. 2 different set of profiles can be defined
        /// for forward and reverse path. If not defined, the reverse of the forward path service profile is applied.
        /// </summary>
        [JsonProperty(PropertyName = "reverse_path_service_profiles")]
        public IList<string> ReversePathServiceProfiles { get; set; }
        /// <summary>
        /// Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load
        /// balancing considerations or flow pinning. LOCAL - Preference to be given to local service insances. REMOTE - Preference
        /// to be given to the SVM co-located on the same host. ROUND_ROBIN - All active service paths are hit with equal
        /// probability.
        /// </summary>
        [JsonProperty(PropertyName = "path_selection_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyServiceChainPathSelectionPolicyEnumType? PathSelectionPolicy { get; set; }
        /// <summary>
        /// Path to service segment using which the traffic needs to be redirected.
        /// </summary>
        [JsonProperty(PropertyName = "service_segment_path", Required = Required.AllowNull)]
        public IList<string> ServiceSegmentPath { get; set; }
        /// <summary>
        /// Forward path service profiles are applied to ingress traffic.
        /// </summary>
        [JsonProperty(PropertyName = "forward_path_service_profiles", Required = Required.AllowNull)]
        public IList<string> ForwardPathServiceProfiles { get; set; }
        /// <summary>
        /// Failure policy for the service defines the action to be taken i.e to allow or to block the traffic during failure
        /// scenarios.
        /// </summary>
        [JsonProperty(PropertyName = "failure_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyServiceChainFailurePolicyEnumType? FailurePolicy { get; set; }
    }
}
