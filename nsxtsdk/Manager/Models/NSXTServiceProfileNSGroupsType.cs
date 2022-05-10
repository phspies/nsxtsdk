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
    public class NSXTServiceProfileNSGroupsType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of NSGroups Used in ServiceInsertion Rules.
        /// </summary>
        [JsonProperty(PropertyName = "nsroups")]
        public IList<NSXTNSGroupInfoType> Nsroups { get; set; }
    }
}
