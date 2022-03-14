// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTIdsProfileCriteriaType> Criteria { get; set; }
        /// <summary>
        /// Represents the severities of signatures which are part of this profile.
        /// </summary>
        public IList<string> ProfileSeverity { get; set; }
        /// <summary>
        /// Represents the severities of signatures which are part of this profile.
        /// </summary>
        public IList<NSXTIdsProfileSeverityType> Severities { get; set; }
        /// <summary>
        /// Represents the signatures that has been  overridden for this Profile.
        /// </summary>
        public IList<NSXTIdsProfileLocalSignatureType> OverriddenSignatures { get; set; }
    }
}
