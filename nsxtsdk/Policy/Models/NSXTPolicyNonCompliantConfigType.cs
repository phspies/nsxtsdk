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
    public class NSXTPolicyNonCompliantConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reported_by")]
        public NSXTPolicyResourceReferenceType ReportedBy { get; set; }
        /// <summary>
        /// Resources/Services impacted by non compliant configuration
        /// </summary>
        [JsonProperty(PropertyName = "affected_resources")]
        public IList<NSXTPolicyResourceReferenceType> AffectedResources { get; set; }
        /// <summary>
        /// Code for non compliant configuration
        /// </summary>
        [JsonProperty(PropertyName = "non_compliance_code")]
        public long? NonComplianceCode { get; set; }
        /// <summary>
        /// Detail description of non compliant configuration with suggestive action
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
