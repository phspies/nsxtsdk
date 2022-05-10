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
    public class NSXTTnNodeAgentStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// Container agent status
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTTnNodeAgentstatusType> Results { get; set; }
    }
}
