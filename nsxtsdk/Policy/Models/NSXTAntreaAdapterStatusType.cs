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
    /// Antrea adapter status
    /// </summary>
    [NSXTProperty(Description: @"Antrea adapter status")]
    public class NSXTAntreaAdapterStatusType 
    {
        public NSXTAntreaAdapterStatusType()
        {
        }
        /// <summary>
        /// Indicate overall healthy status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Indicate overall healthy status.")]
        public NSXTAntreaAdapterStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Collection of adapter conditions.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        [NSXTProperty(IsRequired: false, Description: @"Collection of adapter conditions.")]
        public IList<NSXTComponentConditionItemType> Conditions { get; set; }
    }
}