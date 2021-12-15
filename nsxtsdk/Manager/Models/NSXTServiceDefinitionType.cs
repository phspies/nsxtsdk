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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTServiceDefinitionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Service Deployment Specification defines takes in information required to deploy and configure a partner
        /// appliance/service-vm.
        /// </summary>
        [JsonProperty(PropertyName = "service_deployment_spec")]
        [NSXTProperty(IsRequired: false, Description: @"Service Deployment Specification defines takes in information required to deploy and configure a partner appliance/service-vm.")]
        public NSXTServiceDeploymentSpecType ServiceDeploymentSpec { get; set; }
        /// <summary>
        /// Service capability.
        /// </summary>
        [JsonProperty(PropertyName = "service_capability")]
        [NSXTProperty(IsRequired: false, Description: @"Service capability.")]
        public NSXTServiceCapabilityType ServiceCapability { get; set; }
        /// <summary>
        /// The capabilities provided by the services. Needs to be one or more of the following | NG_FW - Next Generation Firewall |
        /// IDS_IPS - Intrusion Detection System / Intrusion Prevention System | NET_MON - Network Monitoring | HCX - Hybrid Cloud
        /// Exchange | BYOD - Bring Your Own Device | TLB -  Transparent Load Balancer | EPP - Endpoint Protection.(Third party
        /// AntiVirus partners using NXGI should use this functionality for the service)
        /// </summary>
        [JsonProperty(PropertyName = "functionalities", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The capabilities provided by the services. Needs to be one or more of the following | NG_FW - Next Generation Firewall | IDS_IPS - Intrusion Detection System / Intrusion Prevention System | NET_MON - Network Monitoring | HCX - Hybrid Cloud Exchange | BYOD - Bring Your Own Device | TLB -  Transparent Load Balancer | EPP - Endpoint Protection.(Third party AntiVirus partners using NXGI should use this functionality for the service)")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Functionalities { get; set; }
        /// <summary>
        /// The point at which the service is deployed/attached for redirecting the traffic to the the partner appliance. Attachment
        /// Point is required if Service caters to any functionality other than EPP.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_point")]
        [NSXTProperty(IsRequired: false, Description: @"The point at which the service is deployed/attached for redirecting the traffic to the the partner appliance. Attachment Point is required if Service caters to any functionality other than EPP.")]
        public IList<string> AttachmentPoint { get; set; }
        /// <summary>
        /// ID of the service manager to which this service is attached with.
        /// This field is not set during creation of service. This field will
        /// be set explicitly when Service Manager is created successfully using this service.
        /// </summary>
        [JsonProperty(PropertyName = "service_manager_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID of the service manager to which this service is attached with.This field is not set during creation of service. This field willbe set explicitly when Service Manager is created successfully using this service.")]
        public string? ServiceManagerId { get; set; }
        /// <summary>
        /// Id which is unique to a vendor or partner for which the service is created.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Id which is unique to a vendor or partner for which the service is created.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VendorId { get; set; }
        /// <summary>
        /// Failure policy for the service tells datapath, the action to take i.e to Allow or Block traffic during failure
        /// scenarios. For north-south ServiceInsertion, failure policy in the service instance takes precedence. For east-west
        /// ServiceInsertion, failure policy in the service chain takes precedence. BLOCK is not supported for Endpoint protection
        /// (EPP) functionality.
        /// </summary>
        [JsonProperty(PropertyName = "on_failure_policy")]
        [NSXTProperty(IsRequired: false, Description: @"Failure policy for the service tells datapath, the action to take i.e to Allow or Block traffic during failure scenarios. For north-south ServiceInsertion, failure policy in the service instance takes precedence. For east-west ServiceInsertion, failure policy in the service chain takes precedence. BLOCK is not supported for Endpoint protection (EPP) functionality.")]
        [NSXTDefaultProperty(Default: "ALLOW")]
        public NSXTServiceDefinitionOnFailurePolicyEnumType? OnFailurePolicy { get; set; }
        /// <summary>
        /// Transport Type of the service, which is the mechanism of redirecting the traffic to the the partner appliance. Transport
        /// type is required if Service caters to any functionality other than EPP.
        /// </summary>
        [JsonProperty(PropertyName = "transports")]
        [NSXTProperty(IsRequired: false, Description: @"Transport Type of the service, which is the mechanism of redirecting the traffic to the the partner appliance. Transport type is required if Service caters to any functionality other than EPP.")]
        public IList<string> Transports { get; set; }
        /// <summary>
        /// This indicates the insertion point of the service i.e whether the service will be used to protect North-South or
        /// East-West traffic in the datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "implementations", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This indicates the insertion point of the service i.e whether the service will be used to protect North-South or East-West traffic in the datacenter.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Implementations { get; set; }
    }
}
