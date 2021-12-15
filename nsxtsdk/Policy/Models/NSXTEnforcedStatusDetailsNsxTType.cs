// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        /// Information about pending changes, if any, that aren't reflected in the Enforced Realized
        /// Status.
        /// </summary>
        [JsonProperty(PropertyName = "pending_changes_info")]
        [NSXTProperty(IsRequired: false, Description: @"Information about pending changes, if any, that aren&apos;t reflected in the Enforced RealizedStatus.")]
        public NSXTPendingChangesInfoNsxTType PendingChangesInfo { get; set; }
        /// <summary>
        /// Information about the realized status of the intent on this enforcement point. Some very
        /// recent changes may be excluded when preparing this information, which is indicated by
        /// Pending Changes Info.
        /// </summary>
        [JsonProperty(PropertyName = "enforced_status_info")]
        [NSXTProperty(IsRequired: false, Description: @"Information about the realized status of the intent on this enforcement point. Some veryrecent changes may be excluded when preparing this information, which is indicated byPending Changes Info.")]
        public NSXTEnforcedStatusInfoNsxTType EnforcedStatusInfo { get; set; }
    }
}
