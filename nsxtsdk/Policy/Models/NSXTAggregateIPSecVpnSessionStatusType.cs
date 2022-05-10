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
    public class NSXTAggregateIPSecVpnSessionStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// List of IPSec VPN Session Status per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIPSecVpnSessionStatusPerEPType> Results { get; set; }
    }
}
