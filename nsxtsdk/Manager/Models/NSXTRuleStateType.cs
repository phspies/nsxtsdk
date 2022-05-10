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
    public class NSXTRuleStateType : NSXTDSRuleStateType
    {
        /// <summary>
        /// Pending changes to be realized.
        /// </summary>
        [JsonProperty(PropertyName = "pending_change_list")]
        public IList<NSXTPendingChangeType> PendingChangeList { get; set; }
    }
}
