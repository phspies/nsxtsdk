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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTunnelStatusCountType : NSXTStatusCountType
    {
        public NSXTTunnelStatusCountType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_diagnostic")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTBFDDiagnosticCountType BfdDiagnostic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTBFDStatusCountType BfdStatus { get; set; }
    }
}