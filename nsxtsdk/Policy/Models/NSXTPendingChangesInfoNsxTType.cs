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
    /// Information about recent changes, if any, that are not reflected in the Enforced Realized Status.
    /// </summary>
    [NSXTProperty(Description: @"Information about recent changes, if any, that are not reflected in the Enforced Realized Status.")]
    public class NSXTPendingChangesInfoNsxTType 
    {
        /// <summary>
        /// Flag describing whether there are any pending changes that are not reflected in the status.
        /// </summary>
        [JsonProperty(PropertyName = "pending_changes_flag")]
        public bool? PendingChangesFlag { get; set; }
    }
}
