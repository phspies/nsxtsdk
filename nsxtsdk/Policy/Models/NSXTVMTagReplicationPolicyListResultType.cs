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
    public class NSXTVMTagReplicationPolicyListResultType : NSXTListResultType
    {
        /// <summary>
        /// Collection of VM tag replication policies
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTVMTagReplicationPolicyType> Results { get; set; }
        /// <summary>
        /// Count of the VM tag replication policies in the results array
        /// </summary>
        [JsonProperty(PropertyName = "result_count")]
        public long? ResultCount { get; set; }
    }
}
