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
    public class NSXTAggregateIPSecVpnSessionStatisticsType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// List of IPSec VPN Session Statistics per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIPSecVpnSessionStatisticsPerEPType> Results { get; set; }
    }
}
