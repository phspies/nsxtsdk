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
    public class NSXTAggregateLBVirtualServerStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        public NSXTAggregateLBVirtualServerStatusType()
        {
        }
        /// <summary>
        /// LBVirtualServerStatusPerEP list results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"LBVirtualServerStatusPerEP list results.")]
        public IList<NSXTLBVirtualServerStatusPerEPType> Results { get; set; }
    }
}
