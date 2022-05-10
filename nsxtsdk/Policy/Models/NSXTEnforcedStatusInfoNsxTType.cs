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
    /// Information about the realized status of the intent object on an NSX-T type of enforcement point.
        /// Some very recent changes may be excluded when preparing this information, which is indicated by
        /// Pending Changes Info. In addition to the realized status across all scopes, this information holds
        /// details about enforced realized status per scope.
    /// </summary>
    [NSXTProperty(Description: @"Information about the realized status of the intent object on an NSX-T type of enforcement point.Some very recent changes may be excluded when preparing this information, which is indicated byPending Changes Info. In addition to the realized status across all scopes, this information holdsdetails about enforced realized status per scope.")]
    public class NSXTEnforcedStatusInfoNsxTType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "enforced_status")]
        public NSXTEnforcedStatusNsxTType EnforcedStatus { get; set; }
        /// <summary>
        /// List of Enforced Realized Status per Scope.
        /// </summary>
        [JsonProperty(PropertyName = "enforced_status_per_scope")]
        public IList<NSXTEnforcedStatusPerScopeNsxTType> EnforcedStatusPerScope { get; set; }
    }
}
