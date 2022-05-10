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
    public class NSXTALBServerAutoScalePolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Use predicted load rather than current load.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_predicted_load")]
        public bool? UsePredictedLoad { get; set; }
        /// <summary>
        /// Use Avi intelligent autoscale algorithm where autoscale is
        /// performed by comparing load on the pool against estimated
        /// capacity of all the servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_autoscale")]
        public bool? IntelligentAutoscale { get; set; }
        /// <summary>
        /// Maximum extra capacity as percentage of load used by the
        /// intelligent scheme.
        /// Scalein is triggered when available capacity is more than
        /// this margin.
        /// Allowed values are 1-99.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 40.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_scalein_margin")]
        public long? IntelligentScaleinMargin { get; set; }
        /// <summary>
        /// Minimum extra capacity as percentage of load used by the
        /// intelligent scheme.
        /// Scaleout is triggered when available capacity is less than
        /// this margin.
        /// Allowed values are 1-99.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 20.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_scaleout_margin")]
        public long? IntelligentScaleoutMargin { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// No scale-in happens once number of operationally up servers
        /// reach min_servers.
        /// Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "min_size")]
        public long? MinSize { get; set; }
        /// <summary>
        /// Maximum number of servers to scalein simultaneously.
        /// The actual number of servers to scalein is chosen such that
        /// target number of servers is always more than or equal to the
        /// min_size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "max_scalein_adjustment_step")]
        public long? MaxScaleinAdjustmentStep { get; set; }
        /// <summary>
        /// Delay in minutes after which a down server will be removed
        /// from Pool.
        /// Value 0 disables this functionality.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "delay_for_server_garbage_collection")]
        public long? DelayForServerGarbageCollection { get; set; }
        /// <summary>
        /// Maximum number of servers to scaleout simultaneously.
        /// The actual number of servers to scaleout is chosen such
        /// that target number of servers is always less than or equal
        /// to the max_size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "max_scaleout_adjustment_step")]
        public long? MaxScaleoutAdjustmentStep { get; set; }
        /// <summary>
        /// Cooldown period during which no new scaleout is triggered
        /// to allow previous scaleout to successfully complete.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_cooldown")]
        public long? ScaleoutCooldown { get; set; }
        /// <summary>
        /// Maximum number of servers after scaleout.
        /// Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "max_size")]
        public long? MaxSize { get; set; }
        /// <summary>
        /// Cooldown period during which no new scalein is triggered to
        /// allow previous scalein to successfully complete.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_cooldown")]
        public long? ScaleinCooldown { get; set; }
    }
}
