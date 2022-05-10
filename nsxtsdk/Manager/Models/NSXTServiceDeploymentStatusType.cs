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
    public class NSXTServiceDeploymentStatusType 
    {
        /// <summary>
        /// List of issue and detailed description of the issue in case of deployment failure.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_issues")]
        public IList<NSXTServiceDeploymentIssueType> DeploymentIssues { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Deployment status of NXGI Partner Service-VM on a compute collection. It shows the latest status during the process of
        /// deployment, redeploy, upgrade, and un-deployment on a compute collection such as VC cluster.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceDeploymentStatusDeploymentStatusEnumType? DeploymentStatus { get; set; }
        /// <summary>
        /// Currently deployed Service Virtual Appliance version.
        /// </summary>
        [JsonProperty(PropertyName = "sva_current_version")]
        public string? SvaCurrentVersion { get; set; }
        /// <summary>
        /// Id of service deployment.
        /// </summary>
        [JsonProperty(PropertyName = "service_deployment_id")]
        public string? ServiceDeploymentId { get; set; }
        /// <summary>
        /// Max available SVA version for upgrade
        /// </summary>
        [JsonProperty(PropertyName = "sva_max_available_version")]
        public string? SvaMaxAvailableVersion { get; set; }
    }
}
