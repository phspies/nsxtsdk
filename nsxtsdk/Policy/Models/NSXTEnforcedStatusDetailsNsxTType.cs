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
    /// Detailed Realized Status of an intent object on an NSX-T type of enforcement point. This is
        /// a detailed view of the Realized Status of an intent object from an NSX-T enforcement point
        /// perspective.
    /// </summary>
    [NSXTProperty(Description: @"Detailed Realized Status of an intent object on an NSX-T type of enforcement point. This isa detailed view of the Realized Status of an intent object from an NSX-T enforcement pointperspective.")]
    public class NSXTEnforcedStatusDetailsNsxTType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pending_changes_info")]
        public NSXTPendingChangesInfoNsxTType PendingChangesInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "enforced_status_info")]
        public NSXTEnforcedStatusInfoNsxTType EnforcedStatusInfo { get; set; }
    }
}
