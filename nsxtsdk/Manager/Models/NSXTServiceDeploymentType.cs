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
    public class NSXTServiceDeploymentType : NSXTManagedResourceType
    {
        /// <summary>
        /// This indicates the deployment perimeter, such as a VC cluster or a host.
        /// </summary>
        [JsonProperty(PropertyName = "perimeter")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceDeploymentPerimeterEnumType? Perimeter { get; set; }
        /// <summary>
        /// Name of the deployment spec to be used for deployment, which specifies the OVF provided by the partner and the form
        /// factor.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec_name", Required = Required.AllowNull)]
        public string DeploymentSpecName { get; set; }
        /// <summary>
        /// Mode of deployment. Currently, only stand alone deployment is supported. It is a single VM deployed through this
        /// deployment spec. In future, HA configurations will be supported here.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceDeploymentDeploymentModeEnumType? DeploymentMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "instance_deployment_template", Required = Required.AllowNull)]
        public NSXTDeploymentTemplateType InstanceDeploymentTemplate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_deployment_config", Required = Required.AllowNull)]
        public NSXTServiceDeploymentConfigType ServiceDeploymentConfig { get; set; }
        /// <summary>
        /// The Service to which the service deployment is associated.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// Number of instances in case of clustered deployment.
        /// </summary>
        [JsonProperty(PropertyName = "clustered_deployment_count")]
        public long? ClusteredDeploymentCount { get; set; }
        /// <summary>
        /// List of resource references where service instance be deployed. Ex. Tier 0 Logical Router in case of N-S
        /// ServiceInsertion. Service Attachment in case of E-W ServiceInsertion.
        /// </summary>
        [JsonProperty(PropertyName = "deployed_to")]
        public IList<NSXTResourceReferenceType> DeployedTo { get; set; }
        /// <summary>
        /// Specifies whether the service VM should be deployed on each host such that it provides partner service locally on the
        /// host, or whether the service VMs can be deployed as a cluster. If deployment_type is CLUSTERED, then the
        /// clustered_deployment_count should be provided.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceDeploymentDeploymentTypeEnumType? DeploymentType { get; set; }
    }
}
