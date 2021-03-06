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
    /// Advanced load balancer SipServiceApplicationProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SipServiceApplicationProfile object")]
    public class NSXTALBSipServiceApplicationProfileType 
    {
        /// <summary>
        /// SIP transaction timeout in seconds.
        /// Allowed values are 2-512.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 32.
        /// </summary>
        [JsonProperty(PropertyName = "transaction_timeout")]
        public long? TransactionTimeout { get; set; }
    }
}
