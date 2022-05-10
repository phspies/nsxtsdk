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
    public class NSXTPnicBondStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of pNIC statuses belonging to the transport node
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTPnicBondStatusType> Results { get; set; }
    }
}
