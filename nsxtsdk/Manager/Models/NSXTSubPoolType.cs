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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSubPoolType 
    {
        public NSXTSubPoolType()
        {
        }
        /// <summary>
        /// Percentage utlization of sub-pool based on the number of services
        /// configured and the hard limits, if any.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        [NSXTProperty(IsRequired: false, Description: @"Percentage utlization of sub-pool based on the number of servicesconfigured and the hard limits, if any.")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// Credits remaining on the sub-pool that can be used to deploy services of
        /// corresponding sub-pool type.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_credit_number")]
        [NSXTProperty(IsRequired: false, Description: @"Credits remaining on the sub-pool that can be used to deploy services ofcorresponding sub-pool type.")]
        public int? RemainingCreditNumber { get; set; }
        /// <summary>
        /// Type of the sub-pool configured on edge node.
        /// </summary>
        [JsonProperty(PropertyName = "sub_pool_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of the sub-pool configured on edge node.")]
        public string? SubPoolType { get; set; }
    }
}
