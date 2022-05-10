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
    public class NSXTALBWafPolicyPSMGroupApiResponseType : NSXTListResultType
    {
        /// <summary>
        /// count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Array of WafPolicyPSMGroup
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTALBWafPolicyPSMGroupType> Results { get; set; }
    }
}
