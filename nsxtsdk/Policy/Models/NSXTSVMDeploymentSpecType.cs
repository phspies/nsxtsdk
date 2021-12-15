// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Deployment Specs holds information required to deploy the Service-VMs.i.e. OVF url where the partner Service-VM OVF is
        /// hosted. The host type on which the OVF(Open Virtualization Format) can be deployed, Form factor to name a few.
    /// </summary>
    [NSXTProperty(Description: @"Deployment Specs holds information required to deploy the Service-VMs.i.e. OVF url where the partner Service-VM OVF is hosted. The host type on which the OVF(Open Virtualization Format) can be deployed, Form factor to name a few.")]
    public class NSXTSVMDeploymentSpecType 
    {
        /// <summary>
        /// Location of the partner VM OVF to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "ovf_url", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Location of the partner VM OVF to be deployed.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OvfUrl { get; set; }
        /// <summary>
        /// Deployment Spec name for ease of use, since multiple DeploymentSpec can be specified.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Deployment Spec name for ease of use, since multiple DeploymentSpec can be specified.")]
        public string? Name { get; set; }
        /// <summary>
        /// Minimum host version supported by this ovf. If a host in the deployment cluster is having version less than this, then
        /// service deployment will not happen on that host.
        /// </summary>
        [JsonProperty(PropertyName = "min_host_version")]
        [NSXTProperty(IsRequired: false, Description: @"Minimum host version supported by this ovf. If a host in the deployment cluster is having version less than this, then service deployment will not happen on that host.")]
        [NSXTDefaultProperty(Default: "6.5")]
        public string? MinHostVersion { get; set; }
        /// <summary>
        /// Supported ServiceInsertion Form Factor for the OVF deployment. The default FormFactor is Medium.
        /// </summary>
        [JsonProperty(PropertyName = "service_form_factor")]
        [NSXTProperty(IsRequired: false, Description: @"Supported ServiceInsertion Form Factor for the OVF deployment. The default FormFactor is Medium.")]
        [NSXTDefaultProperty(Default: "MEDIUM")]
        public NSXTSvmdeploymentSpecServiceFormFactorEnumType? ServiceFormFactor { get; set; }
        /// <summary>
        /// Host Type on which the specified OVF can be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "host_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Host Type on which the specified OVF can be deployed.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSvmdeploymentSpecHostTypeEnumType HostType { get; set; }
        /// <summary>
        /// Partner needs to specify the Service VM version which will get deployed.
        /// </summary>
        [JsonProperty(PropertyName = "svm_version")]
        [NSXTProperty(IsRequired: false, Description: @"Partner needs to specify the Service VM version which will get deployed.")]
        [NSXTDefaultProperty(Default: "1.0")]
        public string? SvmVersion { get; set; }
    }
}
