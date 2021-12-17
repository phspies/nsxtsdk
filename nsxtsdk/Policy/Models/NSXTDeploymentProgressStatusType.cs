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
    /// Progress status of deployment.
    /// </summary>
    [NSXTProperty(Description: @"Progress status of deployment.")]
    public class NSXTDeploymentProgressStatusType 
    {
        public NSXTDeploymentProgressStatusType()
        {
        }
        /// <summary>
        /// More information about progress.
        /// </summary>
        [JsonProperty(PropertyName = "progress_message")]
        [NSXTProperty(IsRequired: false, Description: @"More information about progress.")]
        public string? ProgressMessage { get; set; }
        /// <summary>
        /// Progress status of deployment.
        /// DEPLOYMENT_IN_PROGRESS - Deployment in progress.
        /// UNDEPLOYMENT_IN_PROGRESS - Undeployment in progress.
        /// UPGRADE_IN_PROGRESS - Upgrade in progress.
        /// UPDATE_IN_PROGRESS - Update in progress.
        /// DEPLOYMENT_QUEUED - Deployment queued.
        /// UNDEPLOYMENT_QUEUED - Undeployment queued.
        /// UPDATE_QUEUED - Update queued.
        /// DEPLOYMENT_SUCCESSFUL - Deployment successful.
        /// UNDEPLOYMENT_SUCCESSFUL - Undeployment successful.
        /// UPGRADE_SUCCESSFUL - Upgrade successful.
        /// UPDATE_SUCCESSFUL - Update successful.
        /// DEPLOYMENT_FAILED - Deployment failed.
        /// UNDEPLOYMENT_FAILED - Undeployment failed.
        /// UPGRADE_FAILED - Upgrade failed.
        /// UPDATE_FAILED - Update failed.
        /// NOT_DEPLOYED - Deployment pending.
        /// </summary>
        [JsonProperty(PropertyName = "overall_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Progress status of deployment.DEPLOYMENT_IN_PROGRESS - Deployment in progress.UNDEPLOYMENT_IN_PROGRESS - Undeployment in progress.UPGRADE_IN_PROGRESS - Upgrade in progress.UPDATE_IN_PROGRESS - Update in progress.DEPLOYMENT_QUEUED - Deployment queued.UNDEPLOYMENT_QUEUED - Undeployment queued.UPDATE_QUEUED - Update queued.DEPLOYMENT_SUCCESSFUL - Deployment successful.UNDEPLOYMENT_SUCCESSFUL - Undeployment successful.UPGRADE_SUCCESSFUL - Upgrade successful.UPDATE_SUCCESSFUL - Update successful.DEPLOYMENT_FAILED - Deployment failed.UNDEPLOYMENT_FAILED - Undeployment failed.UPGRADE_FAILED - Upgrade failed.UPDATE_FAILED - Update failed.NOT_DEPLOYED - Deployment pending.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDeploymentProgressStatusOverallStatusEnumType OverallStatus { get; set; }
        /// <summary>
        /// Errors during deployment.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Errors during deployment.")]
        public IList<string> ErrorMessage { get; set; }
        /// <summary>
        /// Percentage completed for deployment.
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage completed for deployment.")]
        public long? Percentage { get; set; }
    }
}
