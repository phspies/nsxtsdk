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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBServerAutoScalePolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// No scale-in happens once number of operationally up servers
        /// reach min_servers.
        /// Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "min_size")]
        [NSXTProperty(IsRequired: false, Description: @"No scale-in happens once number of operationally up serversreach min_servers.Allowed values are 0-400.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(400)]
        public long? MinSize { get; set; }
        /// <summary>
        /// Use predicted load rather than current load.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_predicted_load")]
        [NSXTProperty(IsRequired: false, Description: @"Use predicted load rather than current load.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? UsePredictedLoad { get; set; }
        /// <summary>
        /// Use Avi intelligent autoscale algorithm where autoscale is
        /// performed by comparing load on the pool against estimated
        /// capacity of all the servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "intelligent_autoscale")]
        [NSXTProperty(IsRequired: false, Description: @"Use Avi intelligent autoscale algorithm where autoscale isperformed by comparing load on the pool against estimatedcapacity of all the servers.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
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
        [NSXTProperty(IsRequired: false, Description: @"Maximum extra capacity as percentage of load used by theintelligent scheme.Scalein is triggered when available capacity is more thanthis margin.Allowed values are 1-99.Default value when not specified in API or module isinterpreted by ALB Controller as 40.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(99)]
        [NSXTDefaultProperty(Default: "")]
        public long? IntelligentScaleinMargin { get; set; }
        /// <summary>
        /// Maximum number of servers to scalein simultaneously.
        /// The actual number of servers to scalein is chosen such that
        /// target number of servers is always more than or equal to the
        /// min_size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "max_scalein_adjustment_step")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum number of servers to scalein simultaneously.The actual number of servers to scalein is chosen such thattarget number of servers is always more than or equal to themin_size.Default value when not specified in API or module isinterpreted by ALB Controller as 1.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxScaleinAdjustmentStep { get; set; }
        /// <summary>
        /// Maximum number of servers to scaleout simultaneously.
        /// The actual number of servers to scaleout is chosen such
        /// that target number of servers is always less than or equal
        /// to the max_size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "max_scaleout_adjustment_step")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum number of servers to scaleout simultaneously.The actual number of servers to scaleout is chosen suchthat target number of servers is always less than or equalto the max_size.Default value when not specified in API or module isinterpreted by ALB Controller as 1.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxScaleoutAdjustmentStep { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"Minimum extra capacity as percentage of load used by theintelligent scheme.Scaleout is triggered when available capacity is less thanthis margin.Allowed values are 1-99.Default value when not specified in API or module isinterpreted by ALB Controller as 20.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(99)]
        [NSXTDefaultProperty(Default: "")]
        public long? IntelligentScaleoutMargin { get; set; }
        /// <summary>
        /// Cooldown period during which no new scaleout is triggered
        /// to allow previous scaleout to successfully complete.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_cooldown")]
        [NSXTProperty(IsRequired: false, Description: @"Cooldown period during which no new scaleout is triggeredto allow previous scaleout to successfully complete.Unit is SEC.Default value when not specified in API or module isinterpreted by ALB Controller as 300.")]
        [NSXTDefaultProperty(Default: "")]
        public long? ScaleoutCooldown { get; set; }
        /// <summary>
        /// Maximum number of servers after scaleout.
        /// Allowed values are 0-400.
        /// </summary>
        [JsonProperty(PropertyName = "max_size")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum number of servers after scaleout.Allowed values are 0-400.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(400)]
        public long? MaxSize { get; set; }
        /// <summary>
        /// Cooldown period during which no new scalein is triggered to
        /// allow previous scalein to successfully complete.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 300.
        /// </summary>
        [JsonProperty(PropertyName = "scalein_cooldown")]
        [NSXTProperty(IsRequired: false, Description: @"Cooldown period during which no new scalein is triggered toallow previous scalein to successfully complete.Unit is SEC.Default value when not specified in API or module isinterpreted by ALB Controller as 300.")]
        [NSXTDefaultProperty(Default: "")]
        public long? ScaleinCooldown { get; set; }
    }
}
