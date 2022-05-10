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
    public class NSXTALBPoolGroupType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// When setup autoscale manager will automatically promote new
        /// pools into production when deployment goals are met.
        /// It is a reference to an object of type
        /// PoolGroupDeploymentPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_policy_path")]
        public string? DeploymentPolicyPath { get; set; }
        /// <summary>
        /// Whether an implicit set of priority labels is generated.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "implicit_priority_labels")]
        public bool? ImplicitPriorityLabels { get; set; }
        /// <summary>
        /// The minimum number of servers to distribute traffic to.
        /// Allowed values are 1-65535.
        /// Special values are 0 - 'Disable'.
        /// Allowed in Basic(Allowed values- 0) edition,
        /// Essentials(Allowed values- 0) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "min_servers")]
        public long? MinServers { get; set; }
        /// <summary>
        /// Enable HTTP/2 for traffic from VirtualService to all the
        /// backend servers in all the pools configured under this
        /// PoolGroup.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for PoolGroup.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Deactivate primary pool for selection when down until it is
        /// activated by user via clear poolgroup command.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_primary_pool_on_down")]
        public bool? DeactivatePrimaryPoolOnDown { get; set; }
        /// <summary>
        /// List of pool group members object of type PoolGroupMember.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTALBPoolGroupMemberType> Members { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "fail_action")]
        public NSXTALBFailActionType FailAction { get; set; }
        /// <summary>
        /// Metadata pertaining to the service provided by this
        /// PoolGroup.
        /// In Openshift/Kubernetes environments, app metadata info is
        /// stored.
        /// Any user input to this field will be overwritten by Avi
        /// Vantage.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        public string? ServiceMetadata { get; set; }
        /// <summary>
        /// path of the priority labels.
        /// If not provided, pool group member priority label will be
        /// interpreted as a number with a larger number considered
        /// higher priority.
        /// It is a reference to an object of type PriorityLabels.
        /// </summary>
        [JsonProperty(PropertyName = "priority_labels_path")]
        public string? PriorityLabelsPath { get; set; }
        /// <summary>
        /// Name of the user who created the object.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
