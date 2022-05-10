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
    /// Advanced load balancer WafApplicationSignatures object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafApplicationSignatures object")]
    public class NSXTALBWafApplicationSignaturesType 
    {
        /// <summary>
        /// The version in use of the provided ruleset.
        /// </summary>
        [JsonProperty(PropertyName = "ruleset_version")]
        public string? RulesetVersion { get; set; }
        /// <summary>
        /// List of applications for which we use the rules from the
        /// WafApplicationSignatureProvider.
        /// Maximum of 8 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "selected_applications")]
        public IList<string> SelectedApplications { get; set; }
        /// <summary>
        /// Override attributes of application signature rules.
        /// </summary>
        [JsonProperty(PropertyName = "rule_overrides")]
        public IList<NSXTALBWafRuleOverridesType> RuleOverrides { get; set; }
    }
}
