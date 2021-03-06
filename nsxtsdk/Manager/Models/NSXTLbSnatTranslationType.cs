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
    public class NSXTLbSnatTranslationType 
    {
        /// <summary>
        /// Load balancers may need to perform SNAT to ensure reverse traffic from
        /// the server can be received and processed by them.
        /// There are two modes:
        /// LbSnatAutoMap uses the load balancer interface IP and an
        /// ephemeral port as the source IP and port of the server side connection.
        /// LbSnatIpPool allows user to specify one or more IP addresses
        /// along with their subnet masks that should be used for SNAT while
        /// connecting to any of the servers in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbSnatTranslationTypeEnumType Type { get; set; }
        /// <summary>
        /// Both SNAT automap and SNAT IP list modes support port overloading
        /// which allows the same SNAT IP and port to be used for multiple
        /// backend connections as long as the tuple (source IP, source port,
        /// destination IP, destination port, IP protocol) after SNAT is
        /// performed is unique.
        /// The valid number is 1, 2, 4, 8, 16, 32.
        /// This is a deprecated property. The port overload factor is fixed
        /// to 32 in load balancer engine. If it is upgraded from an old version,
        /// the value would be changed to 32 automatically.
        /// </summary>
        [JsonProperty(PropertyName = "port_overload")]
        public long? PortOverload { get; set; }
    }
}
