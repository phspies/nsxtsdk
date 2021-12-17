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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// To filter the routes advertised by the TIER1 LR to TIER0 LR. Filtering will be based on the type of route and the prefix
        /// operator configured.
    /// </summary>
    [NSXTProperty(Description: @"To filter the routes advertised by the TIER1 LR to TIER0 LR. Filtering will be based on the type of route and the prefix operator configured.")]
    public class NSXTAdvertisementRuleFilterType 
    {
        public NSXTAdvertisementRuleFilterType()
        {
            PrefixOperator = test
        }
        /// <summary>
        /// GE prefix operator filters all the routes having network subset of any of the networks configured in Advertise rule. EQ
        /// prefix operator filter all the routes having network equal to any of the network configured in Advertise rule.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_operator", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"GE prefix operator filters all the routes having network subset of any of the networks configured in Advertise rule. EQ prefix operator filter all the routes having network equal to any of the network configured in Advertise rule.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAdvertisementRuleFilterPrefixOperatorEnumType PrefixOperator { get; set; }
        /// <summary>
        /// Array of route types to filter routes
        /// </summary>
        [JsonProperty(PropertyName = "match_route_types", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of route types to filter routes")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> MatchRouteTypes { get; set; }
    }
}
