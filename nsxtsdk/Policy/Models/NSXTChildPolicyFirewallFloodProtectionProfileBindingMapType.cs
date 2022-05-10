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
    public class NSXTChildPolicyFirewallFloodProtectionProfileBindingMapType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "PolicyFirewallFloodProtectionProfileBindingMap", Required = Required.AllowNull)]
        public NSXTPolicyFirewallFloodProtectionProfileBindingMapType PolicyFirewallFloodProtectionProfileBindingMap { get; set; }
    }
}
