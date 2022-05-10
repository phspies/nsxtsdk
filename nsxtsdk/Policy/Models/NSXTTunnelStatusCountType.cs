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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTunnelStatusCountType : NSXTStatusCountType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_diagnostic")]
        public NSXTBFDDiagnosticCountType BfdDiagnostic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_status")]
        public NSXTBFDStatusCountType BfdStatus { get; set; }
    }
}
