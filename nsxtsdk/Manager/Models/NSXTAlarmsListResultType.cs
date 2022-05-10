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
    public class NSXTAlarmsListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of alarms known to the system
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTAlarmType> Results { get; set; }
    }
}
