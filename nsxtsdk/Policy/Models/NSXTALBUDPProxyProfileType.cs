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
    /// Advanced load balancer UDPProxyProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer UDPProxyProfile object")]
    public class NSXTALBUDPProxyProfileType 
    {
        /// <summary>
        /// The amount of time (in sec) for which a flow needs to be
        /// idle before it is deleted.
        /// Allowed values are 2-3600.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public long? SessionIdleTimeout { get; set; }
    }
}
