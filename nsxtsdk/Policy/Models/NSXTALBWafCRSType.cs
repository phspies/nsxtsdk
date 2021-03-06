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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBWafCRSType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The release date of this version in RFC 3339 / ISO 8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public string ReleaseDate { get; set; }
        /// <summary>
        /// The version of this ruleset object.
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Integrity protection value.
        /// </summary>
        [JsonProperty(PropertyName = "integrity", Required = Required.AllowNull)]
        public string Integrity { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// WAF Rules are sorted in groups based on their
        /// characterization.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTALBWafRuleGroupType> Groups { get; set; }
    }
}
