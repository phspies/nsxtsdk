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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAggregateLBServiceStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// LBServiceStatusPerEP list results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"LBServiceStatusPerEP list results.")]
        public IList<NSXTLBServiceStatusPerEPType> Results { get; set; }
    }
}
