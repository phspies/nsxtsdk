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
    public class NSXTIdsUserListType : NSXTListResultType
    {
        /// <summary>
        /// List of all affected users specific to a particular signature.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<string> Results { get; set; }
    }
}
