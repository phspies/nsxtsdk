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
    public class NSXTIdsProfileFilterCriteriaType : NSXTIdsProfileCriteriaType
    {
        /// <summary>
        /// Represents the value of selected filter name.
        /// Note : The supported values for filter name CVSS are
        /// NONE, LOW, MEDIUM, HIGH, CRITICAL.
        /// NONE     means CVSS score as 0.0
        /// LOW      means CVSS score as 0.1-3.9
        /// MEDIUM   means CVSS score as 4.0-6.9
        /// HIGH     means CVSS score as 7.0-8.9
        /// CRITICAL means CVSS score as 9.0-10.0
        /// </summary>
        [JsonProperty(PropertyName = "filter_value", Required = Required.AllowNull)]
        public IList<string> FilterValue { get; set; }
        /// <summary>
        /// Represents the filter for IDS Profile.
        /// </summary>
        [JsonProperty(PropertyName = "filter_name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsProfileFilterCriteriaFilterNameEnumType FilterName { get; set; }
    }
}
