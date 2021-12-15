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
    public class NSXTRealizedGroupsType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// list of realized groups
        /// </summary>
        [JsonProperty(PropertyName = "realized_groups")]
        [NSXTProperty(IsRequired: false, Description: @"list of realized groups")]
        public IList<NSXTRealizedGroupType> RealizedGroups { get; set; }
    }
}
