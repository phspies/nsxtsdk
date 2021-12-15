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
        [NSXTProperty(IsRequired: false, Description: @"Whether access log is enabled")]
        public bool? AccessLogEnabled { get; set; }
        /// <summary>
        /// LBS could be instantiated (or created) on the Logical router, etc.
        /// Typically, it could be applied to Tier1 LogicalRouter. It can be
        /// attached to Tier0 LogicalRouter either in non-multi-tenant environments
        /// or to provide load balancing for infrastructure services offered by
        /// the provider.
        /// If size is set to DLB for distribution, the attachment is optional.
        /// The supported attachment is NSGroup consisting of VIFs of that load
        /// balancer's clients.
        /// If the attachment is not specified and size is DLB, the associated
        /// load balancer settings are applied to all supported transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        [NSXTProperty(IsRequired: false, Description: @"LBS could be instantiated (or created) on the Logical router, etc.Typically, it could be applied to Tier1 LogicalRouter. It can beattached to Tier0 LogicalRouter either in non-multi-tenant environmentsor to provide load balancing for infrastructure services offered bythe provider.If size is set to DLB for distribution, the attachment is optional.The supported attachment is NSGroup consisting of VIFs of that loadbalancer&apos;s clients.If the attachment is not specified and size is DLB, the associatedload balancer settings are applied to all supported transport nodes.")]
        public NSXTResourceReferenceType Attachment { get; set; }
        /// <summary>
        /// Load balancer engine writes information about encountered issues of
        /// different severity levels to the error log. This setting is used to
        /// define the severity level of the error log.
        /// </summary>
        [JsonProperty(PropertyName = "error_log_level")]
        [NSXTProperty(IsRequired: false, Description: @"Load balancer engine writes information about encountered issues ofdifferent severity levels to the error log. This setting is used todefine the severity level of the error log.")]
        [NSXTDefaultProperty(Default: "INFO")]
        public NSXTLbServiceErrorLogLevelEnumType? ErrorLogLevel { get; set; }
        /// <summary>
        /// virtual servers can be associated to LbService(which is
        /// similar to physical/virtual load balancer), Lb virtual servers,
        /// pools and other entities could be defined independently, the virtual
        /// server identifier list here would be used to maintain the relationship of
        /// LbService and other Lb entities.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_ids")]
        [NSXTProperty(IsRequired: false, Description: @"virtual servers can be associated to LbService(which issimilar to physical/virtual load balancer), Lb virtual servers,pools and other entities could be defined independently, the virtualserver identifier list here would be used to maintain the relationship ofLbService and other Lb entities.")]
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
        /// </summary>
        [JsonProperty(PropertyName = "relax_scale_validation")]
        [NSXTProperty(IsRequired: false, Description: @"If relax_scale_validation is true, the scale validations for virtualservers/pools/pool members/rules are relaxed for load balancer service.When load balancer service is deployed on edge nodes, the scale ofvirtual servers/pools/pool members for the load balancer service shouldnot exceed the scale number of the largest load balancer size whichcould be configured on a certain edge form factor. For example, thelargest load balancer size supported on a MEDIUM edge node is MEDIUM.So one SMALL load balancer deployed on MEDIUM edge nodes can supportthe scale number of MEDIUM load balancer. It is not recommended toenable active monitors if relax_scale_validation is true due toperformance consideration.If relax_scale_validation is false, scale numbers should be validatedfor load balancer service.")]
        public bool? RelaxScaleValidation { get; set; }
        /// <summary>
        /// Whether the load balancer service is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Whether the load balancer service is enabled")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The size of load balancer service
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        [NSXTProperty(IsRequired: false, Description: @"The size of load balancer service")]
        [NSXTDefaultProperty(Default: "SMALL")]
        public NSXTLbServiceSizeEnumType? Size { get; set; }
    }
}
