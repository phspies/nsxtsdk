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
    public class NSXTTransportZoneProfileListResultType : NSXTListResultType
    {
        /// <summary>
        /// Transport zone profile results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTTransportZoneProfileType> Results { get; set; }
    }
}
