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
    public class NSXTRealizedEnforcementPointType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "realized_firewalls")]
        public NSXTRealizedFirewallsType RealizedFirewalls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "realized_services")]
        public NSXTRealizedServicesType RealizedServices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "realized_groups")]
        public NSXTRealizedGroupsType RealizedGroups { get; set; }
    }
}
