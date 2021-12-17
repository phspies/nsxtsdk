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
    /// Advanced load balancer L4RulePortMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RulePortMatch object")]
    public class NSXTALBL4RulePortMatchType 
    {
        public NSXTALBL4RulePortMatchType()
        {
        }
        /// <summary>
        /// Range of TCP/UDP port numbers of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "port_ranges")]
        [NSXTProperty(IsRequired: false, Description: @"Range of TCP/UDP port numbers of the Virtual Service.")]
        public IList<NSXTALBPortRangeType> PortRanges { get; set; }
        /// <summary>
        /// Virtual Service's listening port(s).
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        [NSXTProperty(IsRequired: false, Description: @"Virtual Service&apos;s listening port(s).Allowed values are 1-65535.")]
        public long? Ports { get; set; }
        /// <summary>
        /// Criterion to use for Virtual Service port matching.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Criterion to use for Virtual Service port matching.Enum options - IS_IN, IS_NOT_IN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBL4RulePortMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
