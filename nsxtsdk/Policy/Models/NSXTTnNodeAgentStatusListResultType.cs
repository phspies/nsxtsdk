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
    public class NSXTTnNodeAgentStatusListResultType : NSXTListResultType
    {
        public NSXTTnNodeAgentStatusListResultType()
        {
        }
        /// <summary>
        /// Container agent status
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Container agent status")]
        public IList<NSXTTnNodeAgentstatusType> Results { get; set; }
    }
}
