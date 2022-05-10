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
    /// Advanced load balancer SidebandProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SidebandProfile object")]
    public class NSXTALBSidebandProfileType 
    {
        /// <summary>
        /// IP Address of the sideband server.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public IList<NSXTALBIpAddrType> Ip { get; set; }
        /// <summary>
        /// Maximum size of the request body that will be sent on the
        /// sideband.
        /// Allowed values are 0-16384.
        /// Unit is BYTES.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1024.
        /// </summary>
        [JsonProperty(PropertyName = "sideband_max_request_body_size")]
        public long? SidebandMaxRequestBodySize { get; set; }
    }
}
