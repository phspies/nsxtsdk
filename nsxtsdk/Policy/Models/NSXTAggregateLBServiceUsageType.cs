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
    public class NSXTAggregateLBServiceUsageType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// LBServiceUsagePerEP list results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLBServiceUsagePerEPType> Results { get; set; }
    }
}
