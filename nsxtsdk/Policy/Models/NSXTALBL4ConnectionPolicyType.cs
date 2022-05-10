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
    /// Advanced load balancer L4ConnectionPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4ConnectionPolicy object")]
    public class NSXTALBL4ConnectionPolicyType 
    {
        /// <summary>
        /// Rules to apply when a new transport connection is setup.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBL4RuleType> Rules { get; set; }
    }
}
