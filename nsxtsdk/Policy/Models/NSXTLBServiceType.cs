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
    public class NSXTLBServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to enable access log
        /// </summary>
        [JsonProperty(PropertyName = "access_log_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable access log")]
        public bool? AccessLogEnabled { get; set; }
        /// <summary>
        /// LBS could be instantiated (or created) on the Tier-1, etc.
        /// For now, only the Tier-1 object is supported.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_path")]
        [NSXTProperty(IsRequired: false, Description: @"LBS could be instantiated (or created) on the Tier-1, etc.For now, only the Tier-1 object is supported.")]
        public string? ConnectivityPath { get; set; }
        /// <summary>
        /// Load balancer engine writes information about encountered issues of
        /// different severity levels to the error log. This setting is used to
        /// define the severity level of the error log.
        /// </summary>
        [JsonProperty(PropertyName = "error_log_level")]
        [NSXTProperty(IsRequired: false, Description: @"Load balancer engine writes information about encountered issues ofdifferent severity levels to the error log. This setting is used todefine the severity level of the error log.")]
        [NSXTDefaultProperty(Default: "INFO")]
        public NSXTLbserviceErrorLogLevelEnumType? ErrorLogLevel { get; set; }
        /// <summary>
        /// If relax_scale_validation is true, the scale validations for virtual
        /// servers/pools/pool members/rules are relaxed for load balancer service.
        /// When load balancer service is deployed on edge nodes, the scale of
        /// virtual servers/pools/pool members for the load balancer service should
        /// not exceed the scale number of the largest load balancer size which
        /// could be configured on a certain edge form factor. For example, the
        /// largest load balancer size supported on a MEDIUM edge node is MEDIUM.
        /// So one SMALL load balancer deployed on MEDIUM edge nodes can support
        /// the scale number of MEDIUM load balancer. It is not recommended to
        /// enable active monitors if relax_scale_validation is true due to
        /// performance consideration.
        /// If relax_scale_validation is false, scale numbers should be validated
        /// for load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "relax_scale_validation")]
        [NSXTProperty(IsRequired: false, Description: @"If relax_scale_validation is true, the scale validations for virtualservers/pools/pool members/rules are relaxed for load balancer service.When load balancer service is deployed on edge nodes, the scale ofvirtual servers/pools/pool members for the load balancer service shouldnot exceed the scale number of the largest load balancer size whichcould be configured on a certain edge form factor. For example, thelargest load balancer size supported on a MEDIUM edge node is MEDIUM.So one SMALL load balancer deployed on MEDIUM edge nodes can supportthe scale number of MEDIUM load balancer. It is not recommended toenable active monitors if relax_scale_validation is true due toperformance consideration.If relax_scale_validation is false, scale numbers should be validatedfor load balancer service.")]
        public bool? RelaxScaleValidation { get; set; }
        /// <summary>
        /// Flag to enable the load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable the load balancer service.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Load balancer service size.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        [NSXTProperty(IsRequired: false, Description: @"Load balancer service size.")]
        [NSXTDefaultProperty(Default: "SMALL")]
        public NSXTLbserviceSizeEnumType? Size { get; set; }
    }
}
