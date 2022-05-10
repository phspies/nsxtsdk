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
    public class NSXTEdgeConfigurationStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// Request identifier of the API which modified the entity.
        /// </summary>
        [JsonProperty(PropertyName = "pending_change_list")]
        public IList<string> PendingChangeList { get; set; }
    }
}
