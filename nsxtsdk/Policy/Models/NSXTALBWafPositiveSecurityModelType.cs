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
    /// Advanced load balancer WafPositiveSecurityModel object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPositiveSecurityModel object")]
    public class NSXTALBWafPositiveSecurityModelType 
    {
        /// <summary>
        /// These groups should be used to separate different levels of
        /// concern.
        /// The order of the groups matters, one group may mark parts
        /// of the request as valid, so that subsequent groups will not
        /// check these parts.
        /// It is a reference to an object of type WafPolicyPSMGroup.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "group_paths")]
        public IList<string> GroupPaths { get; set; }
    }
}
