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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyServiceInstanceType : NSXTBasePolicyServiceInstanceType
    {
        public NSXTPolicyServiceInstanceType()
        {
            FailurePolicy = test
        }
        /// <summary>
        /// Management IP Address of primary interface of the Service
        /// </summary>
        [JsonProperty(PropertyName = "primary_interface_mgmt_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Management IP Address of primary interface of the Service")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PrimaryInterfaceMgmtIp { get; set; }
        /// <summary>
        /// Id of the standard or ditsributed port group for secondary management console.
        /// Please note that only 1 of the 2 values from
        /// 1. secondary_interface_network
        /// 2. secondary_portgroup_id
        /// are allowed to be passed. Both can't be passed in the same request.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_portgroup_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of the standard or ditsributed port group for secondary management console.Please note that only 1 of the 2 values from1. secondary_interface_network2. secondary_portgroup_idare allowed to be passed. Both can&apos;t be passed in the same request.")]
        public string? SecondaryPortgroupId { get; set; }
        /// <summary>
        /// UUID of VCenter/Compute Manager as seen on NSX Manager, to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "context_id")]
        [NSXTProperty(IsRequired: false, Description: @"UUID of VCenter/Compute Manager as seen on NSX Manager, to which this service needs to be deployed.")]
        public string? ContextId { get; set; }
        /// <summary>
        /// Id of the standard or ditsributed port group for primary management console.
        /// Please note that only 1 of the 2 values from
        /// 1. primary_interface_network
        /// 2. primary_portgroup_id
        /// are allowed to be passed. Both can't be passed in the same request.
        /// </summary>
        [JsonProperty(PropertyName = "primary_portgroup_id")]
        [NSXTProperty(IsRequired: false, Description: @"Id of the standard or ditsributed port group for primary management console.Please note that only 1 of the 2 values from1. primary_interface_network2. primary_portgroup_idare allowed to be passed. Both can&apos;t be passed in the same request.")]
        public string? PrimaryPortgroupId { get; set; }
        /// <summary>
        /// Management IP Address of secondary interface of the Service
        /// </summary>
        [JsonProperty(PropertyName = "secondary_interface_mgmt_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Management IP Address of secondary interface of the Service")]
        public string? SecondaryInterfaceMgmtIp { get; set; }
        /// <summary>
        /// Id of the compute(ResourcePool) to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id of the compute(ResourcePool) to which this service needs to be deployed.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeId { get; set; }
        /// <summary>
        /// Form factor for the deployment of partner service.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Form factor for the deployment of partner service.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DeploymentSpecName { get; set; }
        /// <summary>
        /// Template for the deployment of partnet service.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_template_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Template for the deployment of partnet service.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DeploymentTemplateName { get; set; }
        /// <summary>
        /// Gateway address for secondary management console.
        /// If the provided segment already has gateway, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have gateway, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_gateway_address")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway address for secondary management console.If the provided segment already has gateway, this field can be omitted.But if it is provided, it takes precedence always.However, if provided segment does not have gateway, this field must be provided.")]
        public string? SecondaryGatewayAddress { get; set; }
        /// <summary>
        /// Id of the storage(Datastore). VC moref of Datastore to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id of the storage(Datastore). VC moref of Datastore to which this service needs to be deployed.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string StorageId { get; set; }
        /// <summary>
        /// Subnet for secondary management console IP.
        /// If the provided segment already has subnet, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have subnet, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_subnet_mask")]
        [NSXTProperty(IsRequired: false, Description: @"Subnet for secondary management console IP.If the provided segment already has subnet, this field can be omitted.But if it is provided, it takes precedence always.However, if provided segment does not have subnet, this field must be provided.")]
        public string? SecondarySubnetMask { get; set; }
        /// <summary>
        /// List of attributes specific to a partner for which the service is created. There attributes are passed on to the partner
        /// appliance.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of attributes specific to a partner for which the service is created. There attributes are passed on to the partner appliance.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// Subnet for primary management console IP.
        /// If the provided segment already has subnet, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have subnet, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "primary_subnet_mask")]
        [NSXTProperty(IsRequired: false, Description: @"Subnet for primary management console IP.If the provided segment already has subnet, this field can be omitted.But if it is provided, it takes precedence always.However, if provided segment does not have subnet, this field must be provided.")]
        public string? PrimarySubnetMask { get; set; }
        /// <summary>
        /// Gateway address for primary management console.
        /// If the provided segment already has gateway, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have gateway, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "primary_gateway_address")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway address for primary management console.If the provided segment already has gateway, this field can be omitted.But if it is provided, it takes precedence always.However, if provided segment does not have gateway, this field must be provided.")]
        public string? PrimaryGatewayAddress { get; set; }
        /// <summary>
        /// Path of the segment to which primary interface of the Service VM needs to be connected
        /// </summary>
        [JsonProperty(PropertyName = "primary_interface_network")]
        [NSXTProperty(IsRequired: false, Description: @"Path of the segment to which primary interface of the Service VM needs to be connected")]
        public string? PrimaryInterfaceNetwork { get; set; }
        /// <summary>
        /// Path of segment to which secondary interface of the Service VM needs to be connected
        /// </summary>
        [JsonProperty(PropertyName = "secondary_interface_network")]
        [NSXTProperty(IsRequired: false, Description: @"Path of segment to which secondary interface of the Service VM needs to be connected")]
        public string? SecondaryInterfaceNetwork { get; set; }
        /// <summary>
        /// Failure policy for the Service VM. If this values is not provided, it will be defaulted to FAIL_CLOSE.
        /// </summary>
        [JsonProperty(PropertyName = "failure_policy")]
        [NSXTProperty(IsRequired: false, Description: @"Failure policy for the Service VM. If this values is not provided, it will be defaulted to FAIL_CLOSE.")]
        public NSXTPolicyServiceInstanceFailurePolicyEnumType? FailurePolicy { get; set; }
    }
}
