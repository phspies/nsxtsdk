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
    public class NSXTLBServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to enable access log
        /// </summary>
        [JsonProperty(PropertyName = "access_log_enabled")]
        public bool? AccessLogEnabled { get; set; }
        /// <summary>
        /// LBS could be instantiated (or created) on the Tier-1, etc.
        /// For now, only the Tier-1 object is supported.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_path")]
        public string? ConnectivityPath { get; set; }
        /// <summary>
        /// Load balancer engine writes information about encountered issues of
        /// different severity levels to the error log. This setting is used to
        /// define the severity level of the error log.
        /// </summary>
        [JsonProperty(PropertyName = "error_log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
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
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "relax_scale_validation")]
        public bool? RelaxScaleValidation { get; set; }
        /// <summary>
        /// Flag to enable the load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Load balancer service size.
        /// The load balancer service sizes, SMALL, MEDIUM, LARGE and XLARGE are
        /// all deprecated. Customers who are using this set of features are
        /// advised to migrate to NSX Advanced Load Balancer (Avi) which provides
        /// a superset of the NSX-T load balancing functionality.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceSizeEnumType? Size { get; set; }
    }
}
