using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSubPoolType 
    {
        /// <summary>
        /// Percentage utlization of sub-pool based on the number of services
        /// configured and the hard limits, if any.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// Credits remaining on the sub-pool that can be used to deploy services of
        /// corresponding sub-pool type.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_credit_number")]
        public int? RemainingCreditNumber { get; set; }
        /// <summary>
        /// Type of the sub-pool configured on edge node.
        /// </summary>
        [JsonProperty(PropertyName = "sub_pool_type")]
        public string? SubPoolType { get; set; }
    }
}
