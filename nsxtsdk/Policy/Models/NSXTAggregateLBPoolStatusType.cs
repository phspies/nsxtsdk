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
    public class NSXTAggregateLBPoolStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// LBPoolStatusPerEP list results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"LBPoolStatusPerEP list results.")]
        public IList<NSXTLBPoolStatusPerEPType> Results { get; set; }
    }
}
