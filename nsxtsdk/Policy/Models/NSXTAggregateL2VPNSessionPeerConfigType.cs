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
    public class NSXTAggregateL2VPNSessionPeerConfigType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// List of L2VPN Session peer config per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTL2VPNSessionPeerConfigPerEPType> Results { get; set; }
    }
}
