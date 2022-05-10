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
    /// Advanced load balancer WafRuleGroup object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafRuleGroup object")]
    public class NSXTALBWafRuleGroupType 
    {
        /// <summary>
        /// Rules as per Modsec language.
        /// Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafRuleType> Rules { get; set; }
        /// <summary>
        /// Exclude list for the WAF rule group.
        /// The fields in the exclude list entry are logically and'ed
        /// to deduce the exclusion criteria.
        /// If there are multiple excludelist entries, it will be
        /// 'logical or' of them.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Enable or disable WAF Rule Group.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
    }
}
