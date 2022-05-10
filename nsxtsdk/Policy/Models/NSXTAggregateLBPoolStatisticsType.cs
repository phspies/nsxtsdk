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
    public class NSXTAggregateLBPoolStatisticsType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// LBPoolStatisticsPerEP list results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLBPoolStatisticsPerEPType> Results { get; set; }
    }
}
