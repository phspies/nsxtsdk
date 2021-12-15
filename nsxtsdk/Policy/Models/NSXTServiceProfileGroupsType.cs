// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"List of Groups Used in ServiceInsertion Rules.")]
        public IList<NSXTGroupInfoType> Groups { get; set; }
    }
}
