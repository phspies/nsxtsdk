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
    /// ServiceDeployment Spec consists of information required to deploy and configure the partner appliances. viz. Deployment
        /// template, deployment spec and NIC metatdata.
    /// </summary>
    [NSXTProperty(Description: @"ServiceDeployment Spec consists of information required to deploy and configure the partner appliances. viz. Deployment template, deployment spec and NIC metatdata.")]
    public class NSXTServiceDeploymentSpecType 
    {
        /// <summary>
        /// Deployment Specs holds information required to deploy the Service-VMs. i.e. OVF url where the partner Service-VM OVF is
        /// hosted. The host type on which the OVF can be deployed, Form factor to name a few.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_specs")]
        public IList<NSXTSVMDeploymentSpecType> DeploymentSpecs { get; set; }
        /// <summary>
        /// NIC metadata associated with the deployment spec.
        /// </summary>
        [JsonProperty(PropertyName = "nic_metadata_list")]
        public IList<NSXTNicMetadataType> NicMetadataList { get; set; }
        /// <summary>
        /// Deployment Template holds the attributes specific to partner for which the service is created. These attributes are
        /// opaque to NSX Manager.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_template", Required = Required.AllowNull)]
        public IList<NSXTDeploymentTemplateType> DeploymentTemplate { get; set; }
        /// <summary>
        /// Partner needs to specify the Service VM version which will get deployed.
        /// </summary>
        [JsonProperty(PropertyName = "svm_version")]
        public string? SvmVersion { get; set; }
    }
}
