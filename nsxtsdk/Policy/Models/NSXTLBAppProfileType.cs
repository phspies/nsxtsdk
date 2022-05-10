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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("LBHttpProfile", typeof(NSXTLBHttpProfileType))]
    [JsonInheritanceAttribute("LBFastUdpProfile", typeof(NSXTLBFastUdpProfileType))]
    [JsonInheritanceAttribute("LBFastTcpProfile", typeof(NSXTLBFastTcpProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTLBAppProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// An application profile can be bound to a virtual server
        /// to specify the application protocol characteristics. It is used to
        /// influence how load balancing is performed. Currently, three types of
        /// application profiles are supported: LBFastTCPProfile,
        /// LBFastUDPProfile and LBHttpProfile.
        /// LBFastTCPProfile or LBFastUDPProfile is typically
        /// used when the application is using a custom protocol or a standard protocol
        /// not supported by the load balancer. It is also used in cases where the user
        /// only wants L4 load balancing mainly because L4 load balancing has much
        /// higher performance and scalability, and/or supports connection mirroring.
        /// LBHttpProfile is used for both HTTP and HTTPS applications.
        /// Though application rules, if bound to the virtual server, can be used
        /// to accomplish the same goal, LBHttpProfile is intended to
        /// simplify enabling certain common use cases.
        /// LBHttpProfile is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbappProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
