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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Nvds upgrade precheck ID
    /// </summary>
    [NSXTProperty(Description: @"Nvds upgrade precheck ID")]
    public class NSXTNvdsUpgradePrecheckIdType 
    {
        public NSXTNvdsUpgradePrecheckIdType()
        {
        }
        /// <summary>
        /// Tracking ID of nvds upgrade precheck
        /// </summary>
        [JsonProperty(PropertyName = "precheck_id")]
        [NSXTProperty(IsRequired: false, Description: @"Tracking ID of nvds upgrade precheck")]
        public string? PrecheckId { get; set; }
    }
}
