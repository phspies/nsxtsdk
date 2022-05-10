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
    public class NSXTBGPCommunityListListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paginated list of bgp community lists
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTBGPCommunityListType> Results { get; set; }
    }
}
