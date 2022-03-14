// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTServiceDeploymentIssueType> DeploymentIssues { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Deployment status of NXGI Partner Service-VM on a compute collection. It shows the latest status during the process of
        /// deployment, redeploy, upgrade, and un-deployment on a compute collection such as VC cluster.
        /// </summary>
        public NSXTServiceDeploymentStatusDeploymentStatusEnumType? DeploymentStatus { get; set; }
        /// <summary>
        /// Currently deployed Service Virtual Appliance version.
        /// </summary>
        public string? SvaCurrentVersion { get; set; }
        /// <summary>
        /// Id of service deployment.
        /// </summary>
        public string? ServiceDeploymentId { get; set; }
        /// <summary>
        /// Max available SVA version for upgrade
        /// </summary>
        public string? SvaMaxAvailableVersion { get; set; }
    }
}
