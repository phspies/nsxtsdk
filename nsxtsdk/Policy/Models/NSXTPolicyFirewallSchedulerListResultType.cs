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
    public class NSXTPolicyFirewallSchedulerListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of PolicyFirewallSchedulers
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTPolicyFirewallSchedulerType> Results { get; set; }
    }
}
