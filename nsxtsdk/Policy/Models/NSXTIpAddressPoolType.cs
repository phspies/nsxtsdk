// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpAddressPoolType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If an existing IpAddressPool is found that overlaps with the given IpAddressPool,
        /// then a validation error would be thrown while realization.
        /// It is false by default.
        /// </summary>
        public bool? CheckOverlapWithExistingPools { get; set; }
        /// <summary>
        /// Delay in milliseconds, while releasing allocated IP address from IP pool (Default is 2 mins).
        /// </summary>
        public long? IpReleaseDelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTPolicyPoolUsageType PoolUsage { get; set; }
    }
}
