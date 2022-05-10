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
    public class NSXTGatewayFloodProtectionProfileType : NSXTFloodProtectionProfileType
    {
        /// <summary>
        /// The maximum limit of active NAT connections. This limit only apply to EDGE components (such as, gateway). If this
        /// property is omitted, or set to null, then there is no limit on the specific component. Meanwhile there is an implicit
        /// limit which depends on the underlying hardware resource.
        /// </summary>
        [JsonProperty(PropertyName = "nat_active_conn_limit")]
        public long? NatActiveConnLimit { get; set; }
    }
}
