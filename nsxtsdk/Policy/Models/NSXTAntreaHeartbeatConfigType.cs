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
    public class NSXTAntreaHeartbeatConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If exceeding 3*report_interval, there is still no heartbeat, cluster status will be UNKNOWN.
        /// </summary>
        [JsonProperty(PropertyName = "report_interval", Required = Required.AllowNull)]
        public int ReportInterval { get; set; }
    }
}
