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
    /// Advanced load balancer L4Policies object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4Policies object")]
    public class NSXTALBL4PoliciesType 
    {
        /// <summary>
        /// ID of the virtual service L4 policy set.
        /// It is a reference to an object of type L4PolicySet.
        /// </summary>
        [JsonProperty(PropertyName = "l4_policy_set_path", Required = Required.AllowNull)]
        public string L4PolicySetPath { get; set; }
        /// <summary>
        /// Index of the virtual service L4 policy set.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
    }
}
