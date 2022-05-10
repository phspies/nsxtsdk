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
    public class NSXTIdsProfileSeverityType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the id of signatures that will be ignored as part of the profile.
        /// This field is deprecated, please use ignore_signatures field under IdsProfile
        /// to ignore the signatures.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_signatures")]
        public IList<string> IgnoreSignatures { get; set; }
        /// <summary>
        /// Represents the severity of a profile.
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsProfileSeveritySeverityEnumType Severity { get; set; }
    }
}
