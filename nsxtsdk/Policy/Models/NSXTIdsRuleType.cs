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
    public class NSXTIdsRuleType : NSXTBaseRuleType
    {
        /// <summary>
        /// The action to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"The action to be applied.")]
        public NSXTIdsRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// collections of IDS profiles.
        /// </summary>
        [JsonProperty(PropertyName = "ids_profiles")]
        [NSXTProperty(IsRequired: false, Description: @"collections of IDS profiles.")]
        public IList<string> IdsProfiles { get; set; }
    }
}