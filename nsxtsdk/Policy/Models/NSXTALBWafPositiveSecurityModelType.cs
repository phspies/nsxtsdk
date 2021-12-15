// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"These groups should be used to separate different levels ofconcern.The order of the groups matters, one group may mark partsof the request as valid, so that subsequent groups will notcheck these parts.It is a reference to an object of type WafPolicyPSMGroup.Maximum of 64 items allowed.")]
        public IList<string> GroupPaths { get; set; }
    }
}