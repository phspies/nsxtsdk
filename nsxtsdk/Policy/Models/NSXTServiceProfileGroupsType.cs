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
    public class NSXTServiceProfileGroupsType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of Groups Used in ServiceInsertion Rules.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTGroupInfoType> Groups { get; set; }
    }
}
