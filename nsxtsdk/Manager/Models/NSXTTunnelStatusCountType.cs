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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTunnelStatusCountType : NSXTStatusCountType
    {
        /// <summary>
        /// BFD Diagnostic
        /// </summary>
        [JsonProperty(PropertyName = "bfd_diagnostic")]
        [NSXTProperty(IsRequired: false, Description: @"BFD Diagnostic")]
        public NSXTBFDDiagnosticCountType BfdDiagnostic { get; set; }
        /// <summary>
        /// BFD Status
        /// </summary>
        [JsonProperty(PropertyName = "bfd_status")]
        [NSXTProperty(IsRequired: false, Description: @"BFD Status")]
        public NSXTBFDStatusCountType BfdStatus { get; set; }
    }
}
