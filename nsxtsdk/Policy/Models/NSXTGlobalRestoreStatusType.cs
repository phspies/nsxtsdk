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
    /// Overall restore process status
    /// </summary>
    [NSXTProperty(Description: @"Overall restore process status")]
    public class NSXTGlobalRestoreStatusType 
    {
        /// <summary>
        /// A description of the restore status
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"A description of the restore status")]
        public string? Description { get; set; }
        /// <summary>
        /// Global rolled-up restore status value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [NSXTProperty(IsRequired: false, Description: @"Global rolled-up restore status value")]
        public NSXTGlobalRestoreStatusValueEnumType? Value { get; set; }
    }
}
