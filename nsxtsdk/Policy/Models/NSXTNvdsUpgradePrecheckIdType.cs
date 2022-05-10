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
    /// Nvds upgrade precheck ID
    /// </summary>
    [NSXTProperty(Description: @"Nvds upgrade precheck ID")]
    public class NSXTNvdsUpgradePrecheckIdType 
    {
        /// <summary>
        /// Tracking ID of nvds upgrade precheck
        /// </summary>
        [JsonProperty(PropertyName = "precheck_id")]
        public string? PrecheckId { get; set; }
    }
}
