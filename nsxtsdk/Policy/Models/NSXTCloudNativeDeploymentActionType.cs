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
    /// Action to be perform on deployment.
    /// </summary>
    [NSXTProperty(Description: @"Action to be perform on deployment.")]
    public class NSXTCloudNativeDeploymentActionType 
    {
        /// <summary>
        /// Action can be deploy or undeploy.
        /// DEPLOY - Deploy NSX Application Platform charts.
        /// UNDEPLOY - Undeploy NSX Application Platform charts.
        /// REDEPLOY - Redeploy NSX Application Platform charts.
        /// UPDATE_FORMFACTOR - Upgrade NSX Application Platform charts.
        /// REDEPLOY_UPDATE_FORMFACTOR - Retry update NSX Application Platform charts.
        /// FORCE_UNDEPLOY - Undeploy forcefully.
        /// RESTART - Restart deployment.
        /// RESET - Reset deployment.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCloudNativeDeploymentActionActionEnumType Action { get; set; }
    }
}
