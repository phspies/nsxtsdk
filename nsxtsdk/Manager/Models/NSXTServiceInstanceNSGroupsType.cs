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
    /// ServiceInstanceNSGroups contains list of NS Groups referenced in North-South Service Insertion Rules for a particular
        /// Service Instance.
    /// </summary>
    [NSXTProperty(Description: @"ServiceInstanceNSGroups contains list of NS Groups referenced in North-South Service Insertion Rules for a particular Service Instance.")]
    public class NSXTServiceInstanceNSGroupsType 
    {
        /// <summary>
        /// List of NSGroups Used in ServiceInsertion Rules.
        /// </summary>
        [JsonProperty(PropertyName = "nsroups")]
        public IList<NSXTNSGroupInfoType> Nsroups { get; set; }
    }
}
