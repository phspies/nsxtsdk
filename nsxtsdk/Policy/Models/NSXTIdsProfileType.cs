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
    public class NSXTIdsProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Represents the filtering criteria for the IDS Profile.
        /// 1. A non-empty criteria list, must be of odd size. In a list, with
        /// indices starting from 0, all IdsProfileFilterCriteria must be at even indices,
        /// separated by the IdsProfileConjunctionOperator AND at odd indices.
        /// 2. There may be at most 7 IdsProfileCriteria objects inside a list.
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public IList<NSXTIdsProfileCriteriaType> Criteria { get; set; }
        /// <summary>
        /// Represents the severities of signatures which are part of this profile.
        /// </summary>
        [JsonProperty(PropertyName = "profile_severity")]
        public IList<string> ProfileSeverity { get; set; }
        /// <summary>
        /// Represents the severities of signatures which are part of this profile.
        /// </summary>
        [JsonProperty(PropertyName = "severities")]
        public IList<NSXTIdsProfileSeverityType> Severities { get; set; }
        /// <summary>
        /// Represents the signatures that has been  overridden for this Profile.
        /// </summary>
        [JsonProperty(PropertyName = "overridden_signatures")]
        public IList<NSXTIdsProfileLocalSignatureType> OverriddenSignatures { get; set; }
    }
}
