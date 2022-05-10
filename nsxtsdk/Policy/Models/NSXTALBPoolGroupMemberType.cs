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
    /// Advanced load balancer PoolGroupMember object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PoolGroupMember object")]
    public class NSXTALBPoolGroupMemberType 
    {
        /// <summary>
        /// All pools with same label are treated similarly in a pool
        /// group.
        /// A pool with a higher priority is selected, as long as the
        /// pool is eligible or an explicit policy chooses a different
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "priority_label")]
        public string? PriorityLabel { get; set; }
        /// <summary>
        /// Ratio of selecting eligible pools in the pool group.
        /// Allowed values are 1-1000.
        /// Special values are 0 - 'Do not select this pool for new
        /// connections'.
        /// Allowed in Basic(Allowed values- 1) edition,
        /// Essentials(Allowed values- 1) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "ratio")]
        public long? Ratio { get; set; }
        /// <summary>
        /// path of the pool.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path", Required = Required.AllowNull)]
        public string PoolPath { get; set; }
        /// <summary>
        /// Pool deployment state used with the PG deployment policy.
        /// Enum options - EVALUATION_IN_PROGRESS, IN_SERVICE,
        /// OUT_OF_SERVICE, EVALUATION_FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbpoolGroupMemberDeploymentStateEnumType? DeploymentState { get; set; }
    }
}
