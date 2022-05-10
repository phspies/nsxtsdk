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
    public class NSXTLogicalSwitchListResultType : NSXTListResultType
    {
        /// <summary>
        /// Logical Switch Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLogicalSwitchType> Results { get; set; }
    }
}
