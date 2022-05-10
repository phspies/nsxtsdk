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
    public class NSXTServiceInstanceType : NSXTBaseServiceInstanceType
    {
        /// <summary>
        /// Name of the deployment spec to be used by this service instance.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec_name", Required = Required.AllowNull)]
        public string DeploymentSpecName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "instance_deployment_template", Required = Required.AllowNull)]
        public NSXTDeploymentTemplateType InstanceDeploymentTemplate { get; set; }
        /// <summary>
        /// Implementation to be used by this service instance for deploying the Service-VM.
        /// </summary>
        [JsonProperty(PropertyName = "implementation_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInstanceImplementationTypeEnumType ImplementationType { get; set; }
        /// <summary>
        /// Attachment point to be used by this service instance for deploying the Service-VM.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_point", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInstanceAttachmentPointEnumType AttachmentPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "instance_deployment_config")]
        public NSXTInstanceDeploymentConfigType InstanceDeploymentConfig { get; set; }
        /// <summary>
        /// Deployment mode specifies where the partner appliance will be deployed in HA or non-HA i.e standalone mode.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_mode", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInstanceDeploymentModeEnumType DeploymentMode { get; set; }
        /// <summary>
        /// List of resource references where service instance be deployed. Ex. Tier 0 Logical Router in case of N-S
        /// ServiceInsertion.
        /// </summary>
        [JsonProperty(PropertyName = "deployed_to", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> DeployedTo { get; set; }
        /// <summary>
        /// Id of the Service Deployment using which the instances were deployed. Its available only for instances that were
        /// deployed using service deployment API.
        /// </summary>
        [JsonProperty(PropertyName = "service_deployment_id")]
        public string? ServiceDeploymentId { get; set; }
    }
}
