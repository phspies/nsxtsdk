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
    public class NSXTALBPoolGroupDeploymentPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Target traffic ratio before pool is made production.
        /// Allowed values are 1-100.
        /// Unit is RATIO.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "target_test_traffic_ratio")]
        public long? TargetTestTrafficRatio { get; set; }
        /// <summary>
        /// Duration of evaluation period for automatic deployment.
        /// Allowed values are 60-86400.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "evaluation_duration")]
        public long? EvaluationDuration { get; set; }
        /// <summary>
        /// Ratio of the traffic that is sent to the pool under test.
        /// test ratio of 100 means blue green.
        /// Allowed values are 1-100.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "test_traffic_ratio_rampup")]
        public long? TestTrafficRatioRampup { get; set; }
        /// <summary>
        /// Placeholder for description of property rules of obj type
        /// PoolGroupDeploymentPolicy field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBPGDeploymentRuleType> Rules { get; set; }
        /// <summary>
        /// It will automatically disable old production pools once
        /// there is a new production candidate.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "auto_disable_old_prod_pools")]
        public bool? AutoDisableOldProdPools { get; set; }
        /// <summary>
        /// deployment scheme.
        /// Enum options - BLUE_GREEN, CANARY.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as BLUE_GREEN.
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbpoolGroupDeploymentPolicySchemeEnumType? Scheme { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Webhook configured with URL that Avi controller will pass
        /// back information about pool group, old and new pool
        /// information and current deployment rule results.
        /// It is a reference to an object of type Webhook.
        /// </summary>
        [JsonProperty(PropertyName = "webhook_path")]
        public string? WebhookPath { get; set; }
    }
}
