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
    public class NSXTServiceDefinitionType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_deployment_spec")]
        public NSXTServiceDeploymentSpecType ServiceDeploymentSpec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_capability")]
        public NSXTServiceCapabilityType ServiceCapability { get; set; }
        /// <summary>
        /// The capabilities provided by the services. Needs to be one or more of the following | NG_FW - Next Generation Firewall |
        /// IDS_IPS - Intrusion Detection System / Intrusion Prevention System | NET_MON - Network Monitoring | HCX - Hybrid Cloud
        /// Exchange | BYOD - Bring Your Own Device | TLB -  Transparent Load Balancer | EPP - Endpoint Protection.(Third party
        /// AntiVirus partners using NXGI should use this functionality for the service) | MPS - Malware Prevention Solution
        /// </summary>
        [JsonProperty(PropertyName = "functionalities", Required = Required.AllowNull)]
        public IList<string> Functionalities { get; set; }
        /// <summary>
        /// The point at which the service is deployed/attached for redirecting the traffic to the the partner appliance. Attachment
        /// Point is required if Service caters to any functionality other than EPP and MPS.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_point")]
        public IList<string> AttachmentPoint { get; set; }
        /// <summary>
        /// ID of the service manager to which this service is attached with.
        /// This field is not set during creation of service. This field will
        /// be set explicitly when Service Manager is created successfully using this service.
        /// </summary>
        [JsonProperty(PropertyName = "service_manager_id")]
        public string? ServiceManagerId { get; set; }
        /// <summary>
        /// Id which is unique to a vendor or partner for which the service is created.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_id", Required = Required.AllowNull)]
        public string VendorId { get; set; }
        /// <summary>
        /// Failure policy for the service tells datapath, the action to take i.e to Allow or Block traffic during failure
        /// scenarios. For north-south ServiceInsertion, failure policy in the service instance takes precedence. For east-west
        /// ServiceInsertion, failure policy in the service chain takes precedence. BLOCK is not supported for Endpoint protection
        /// (EPP) and MPS functionality.
        /// </summary>
        [JsonProperty(PropertyName = "on_failure_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceDefinitionOnFailurePolicyEnumType? OnFailurePolicy { get; set; }
        /// <summary>
        /// Transport Type of the service, which is the mechanism of redirecting the traffic to the the partner appliance. Transport
        /// type is required if Service caters to any functionality other than EPP and MPS.
        /// </summary>
        [JsonProperty(PropertyName = "transports")]
        public IList<string> Transports { get; set; }
        /// <summary>
        /// This indicates the insertion point of the service i.e whether the service will be used to protect North-South or
        /// East-West traffic in the datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "implementations", Required = Required.AllowNull)]
        public IList<string> Implementations { get; set; }
    }
}
