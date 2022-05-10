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
    /// Realization state of attaching or detaching Transport node profile on compute collection.
    /// </summary>
    [NSXTProperty(Description: @"Realization state of attaching or detaching Transport node profile on compute collection.")]
    public class NSXTTransportNodeCollectionStateType 
    {
        /// <summary>
        /// Transport node profile(TNP) will not be applied to a discovered node(DN) if some validations are not passed. In this
        /// case transport node is not created or existing transport node is not updated with TNP configurations.
        /// </summary>
        [JsonProperty(PropertyName = "validation_errors")]
        public IList<NSXTValidationErrorType> ValidationErrors { get; set; }
        /// <summary>
        /// Errors while applying transport node profile which need cluster level action to resolve
        /// </summary>
        [JsonProperty(PropertyName = "cluster_level_error")]
        public string? ClusterLevelError { get; set; }
        /// <summary>
        /// If the host preparation or transport node creation is going on for
        /// any host then state will be "IN_PROGRESS".
        /// 
        /// If setting desired state of the transport node failed for any of
        /// the host then state will be "FAILED_TO_CREATE"
        /// 
        /// If realization of transport node failed for any of
        /// the host then state will be "FAILED_TO_REALIZE"
        /// 
        /// If Transport node is successfully created for all of the hosts in
        /// compute collection then state will be "SUCCESS"
        /// 
        /// You can override the configuration for one or more hosts in the
        /// compute collection by update TN(transport node) request on individual
        /// TN. If TN is successfully created for all hosts in compute collection
        /// and one or more hosts have overridden configuration then transport node
        /// collection state will be "PROFILE_MISMATCH".
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeCollectionStateStateEnumType? State { get; set; }
        /// <summary>
        /// Average of all transport node deployment progress in a cluster. Applicable only if transport node profile is applied on
        /// a cluster.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_progress_percentage")]
        public long? AggregateProgressPercentage { get; set; }
        /// <summary>
        /// When vLCM is enabled on a compute collection in vSphere the transition workflow is triggered. This field indicates error
        /// in this special case.
        /// </summary>
        [JsonProperty(PropertyName = "vlcm_transition_error")]
        public string? VlcmTransitionError { get; set; }
    }
}
