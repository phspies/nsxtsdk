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
    public class NSXTPolicyNatType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Represents a NAT section under tier-0/tier-1.
        /// </summary>
        [JsonProperty(PropertyName = "nat_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyNatNatTypeEnumType? NatType { get; set; }
    }
}
