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
    public class NSXTVrniGlobalCollectorType : NSXTGlobalCollectorConfigType
    {
        /// <summary>
        /// Report interval for operation data in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "report_interval", Required = Required.AllowNull)]
        public int ReportInterval { get; set; }
    }
}
