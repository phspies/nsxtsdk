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
    public class NSXTInstanceRuntimeType : NSXTManagedResourceType
    {
        /// <summary>
        /// Service-VM/SVM id of deployed virtual-machine.
        /// </summary>
        [JsonProperty(PropertyName = "service_vm_id")]
        public string? ServiceVmId { get; set; }
        /// <summary>
        /// Service-Instance Runtime deployment status of the Service-VM. It shows the latest status during the process of
        /// deployment, redeploy, upgrade, and un-deployment of VM.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInstanceRuntimeDeploymentStatusEnumType? DeploymentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vm_nic_info")]
        public NSXTVmNicInfoType VmNicInfo { get; set; }
        /// <summary>
        /// The maintenance mode indicates whether the corresponding service VM
        /// is in maintenance mode. The service VM will not be used to service
        /// new requests if it is in maintenance mode.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInstanceRuntimeMaintenanceModeEnumType? MaintenanceMode { get; set; }
        /// <summary>
        /// Service-Instance Runtime status of the deployed Service-VM.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInstanceRuntimeRuntimeStatusEnumType? RuntimeStatus { get; set; }
        /// <summary>
        /// Error message for the Service Instance Runtime if any.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Id of an instantiation of a registered service.
        /// </summary>
        [JsonProperty(PropertyName = "service_instance_id")]
        public string? ServiceInstanceId { get; set; }
        /// <summary>
        /// Service-Instance runtime health status set by partner to indicate
        /// whether the service is running properly or not.
        /// </summary>
        [JsonProperty(PropertyName = "runtime_health_status_by_partner")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInstanceRuntimeRuntimeHealthStatusByPartnerEnumType? RuntimeHealthStatusByPartner { get; set; }
        /// <summary>
        /// Reason provided by partner for the service being unhealthy. This could be due
        /// to various reasons such as connectivity lost as an example.
        /// </summary>
        [JsonProperty(PropertyName = "unhealthy_reason")]
        public string? UnhealthyReason { get; set; }
    }
}
