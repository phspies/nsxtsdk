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
    public class NSXTLbServiceType : NSXTManagedResourceType
    {
        /// <summary>
        /// Whether access log is enabled
        /// </summary>
        [JsonProperty(PropertyName = "access_log_enabled")]
        public bool? AccessLogEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        public NSXTResourceReferenceType Attachment { get; set; }
        /// <summary>
        /// Load balancer engine writes information about encountered issues of
        /// different severity levels to the error log. This setting is used to
        /// define the severity level of the error log.
        /// </summary>
        [JsonProperty(PropertyName = "error_log_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbServiceErrorLogLevelEnumType? ErrorLogLevel { get; set; }
        /// <summary>
        /// virtual servers can be associated to LbService(which is
        /// similar to physical/virtual load balancer), Lb virtual servers,
        /// pools and other entities could be defined independently, the virtual
        /// server identifier list here would be used to maintain the relationship of
        /// LbService and other Lb entities.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_ids")]
        public IList<string> VirtualServerIds { get; set; }
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
        /// Whether the load balancer service is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The size of load balancer service
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbServiceSizeEnumType? Size { get; set; }
    }
}
