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
    /// NSX-T Enforced Status.
    /// </summary>
    [NSXTProperty(Description: @"NSX-T Enforced Status.")]
    public class NSXTEnforcedStatusNsxTType 
    {
        /// <summary>
        /// Enforced Realized Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Enforced Realized Status.")]
        public NSXTEnforcedStatusNsxTStatusEnumType? Status { get; set; }
        /// <summary>
        /// Status Message conveying hints depending on the status value.
        /// </summary>
        [JsonProperty(PropertyName = "status_message")]
        [NSXTProperty(IsRequired: false, Description: @"Status Message conveying hints depending on the status value.")]
        public string? StatusMessage { get; set; }
    }
}