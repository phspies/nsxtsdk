using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTOperationCollectorGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// Report interval for operation data in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "report_interval")]
        public int? ReportInterval { get; set; }
        /// <summary>
        /// Operation Collector Config.
        /// </summary>
        [JsonProperty(PropertyName = "collectors")]
        public IList<NSXTOperationCollectorType> Collectors { get; set; }
    }
}
