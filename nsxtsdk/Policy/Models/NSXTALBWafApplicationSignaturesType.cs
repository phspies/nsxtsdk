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
    /// Advanced load balancer WafApplicationSignatures object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafApplicationSignatures object")]
    public class NSXTALBWafApplicationSignaturesType 
    {
        /// <summary>
        /// The active application specific rules.
        /// You can change attributes like enabled, waf mode and
        /// exclusions, but not the rules itself.
        /// To change the rules, you can change the tags or the rule
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        [NSXTProperty(IsRequired: false, Description: @"The active application specific rules.You can change attributes like enabled, waf mode andexclusions, but not the rules itself.To change the rules, you can change the tags or the ruleprovider.")]
        public IList<NSXTALBWafRuleType> Rules { get; set; }
        /// <summary>
        /// The version in use of the provided ruleset.
        /// </summary>
        [JsonProperty(PropertyName = "ruleset_version")]
        [NSXTProperty(IsRequired: false, Description: @"The version in use of the provided ruleset.")]
        public string? RulesetVersion { get; set; }
        /// <summary>
        /// List of applications for which we use the rules from the
        /// WafApplicationSignatureProvider.
        /// Maximum of 8 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "selected_applications")]
        [NSXTProperty(IsRequired: false, Description: @"List of applications for which we use the rules from theWafApplicationSignatureProvider.Maximum of 8 items allowed.")]
        public IList<string> SelectedApplications { get; set; }
    }
}
