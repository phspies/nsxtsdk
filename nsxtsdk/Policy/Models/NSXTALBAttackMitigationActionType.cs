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
    /// Advanced load balancer AttackMitigationAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AttackMitigationAction object")]
    public class NSXTALBAttackMitigationActionType 
    {
        /// <summary>
        /// Deny the attack packets further processing and drop them.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "deny")]
        public bool? Deny { get; set; }
    }
}
