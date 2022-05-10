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
    /// Contains up-to-date information relating to an auto-deployed VM, including
        /// its status and (potentially) an error message.
    /// </summary>
    [NSXTProperty(Description: @"Contains up-to-date information relating to an auto-deployed VM, includingits status and (potentially) an error message.")]
    public class NSXTClusterNodeVMDeploymentStatusReportType 
    {
        /// <summary>
        /// Status of the addition or deletion of an auto-deployed cluster node VM.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeVmdeploymentStatusReportStatusEnumType Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_progress_state")]
        public NSXTVMDeploymentProgressStateType DeploymentProgressState { get; set; }
        /// <summary>
        /// In case of auto-deployment-related failure, an error message will be
        /// stored here.
        /// </summary>
        [JsonProperty(PropertyName = "failure_message")]
        public string? FailureMessage { get; set; }
        /// <summary>
        /// In case of auto-deployment-related failure, the code for the error will
        /// be stored here.
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        public long? FailureCode { get; set; }
    }
}
