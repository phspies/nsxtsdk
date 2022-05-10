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
    public class NSXTPolicyServiceInstanceType : NSXTBasePolicyServiceInstanceType
    {
        /// <summary>
        /// Management IP Address of primary interface of the Service
        /// </summary>
        [JsonProperty(PropertyName = "primary_interface_mgmt_ip", Required = Required.AllowNull)]
        public string PrimaryInterfaceMgmtIp { get; set; }
        /// <summary>
        /// Id of the standard or ditsributed port group for secondary management console.
        /// Please note that only 1 of the 2 values from
        /// 1. secondary_interface_network
        /// 2. secondary_portgroup_id
        /// are allowed to be passed. Both can't be passed in the same request.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_portgroup_id")]
        public string? SecondaryPortgroupId { get; set; }
        /// <summary>
        /// UUID of VCenter/Compute Manager as seen on NSX Manager, to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "context_id")]
        public string? ContextId { get; set; }
        /// <summary>
        /// Id of the standard or ditsributed port group for primary management console.
        /// Please note that only 1 of the 2 values from
        /// 1. primary_interface_network
        /// 2. primary_portgroup_id
        /// are allowed to be passed. Both can't be passed in the same request.
        /// </summary>
        [JsonProperty(PropertyName = "primary_portgroup_id")]
        public string? PrimaryPortgroupId { get; set; }
        /// <summary>
        /// Management IP Address of secondary interface of the Service
        /// </summary>
        [JsonProperty(PropertyName = "secondary_interface_mgmt_ip")]
        public string? SecondaryInterfaceMgmtIp { get; set; }
        /// <summary>
        /// Id of the compute(ResourcePool) to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        public string ComputeId { get; set; }
        /// <summary>
        /// Form factor for the deployment of partner service.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec_name", Required = Required.AllowNull)]
        public string DeploymentSpecName { get; set; }
        /// <summary>
        /// Template for the deployment of partnet service.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_template_name", Required = Required.AllowNull)]
        public string DeploymentTemplateName { get; set; }
        /// <summary>
        /// Gateway address for secondary management console.
        /// If the provided segment already has gateway, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have gateway, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_gateway_address")]
        public string? SecondaryGatewayAddress { get; set; }
        /// <summary>
        /// Id of the storage(Datastore). VC moref of Datastore to which this service needs to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        public string StorageId { get; set; }
        /// <summary>
        /// Subnet for secondary management console IP.
        /// If the provided segment already has subnet, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have subnet, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "secondary_subnet_mask")]
        public string? SecondarySubnetMask { get; set; }
        /// <summary>
        /// List of attributes specific to a partner for which the service is created. There attributes are passed on to the partner
        /// appliance.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// Subnet for primary management console IP.
        /// If the provided segment already has subnet, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have subnet, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "primary_subnet_mask")]
        public string? PrimarySubnetMask { get; set; }
        /// <summary>
        /// Gateway address for primary management console.
        /// If the provided segment already has gateway, this field can be omitted.
        /// But if it is provided, it takes precedence always.
        /// However, if provided segment does not have gateway, this field must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "primary_gateway_address")]
        public string? PrimaryGatewayAddress { get; set; }
        /// <summary>
        /// Path of the segment to which primary interface of the Service VM needs to be connected
        /// </summary>
        [JsonProperty(PropertyName = "primary_interface_network")]
        public string? PrimaryInterfaceNetwork { get; set; }
        /// <summary>
        /// Path of segment to which secondary interface of the Service VM needs to be connected
        /// </summary>
        [JsonProperty(PropertyName = "secondary_interface_network")]
        public string? SecondaryInterfaceNetwork { get; set; }
        /// <summary>
        /// Failure policy for the Service VM. If this values is not provided, it will be defaulted to FAIL_CLOSE.
        /// </summary>
        [JsonProperty(PropertyName = "failure_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyServiceInstanceFailurePolicyEnumType? FailurePolicy { get; set; }
    }
}
