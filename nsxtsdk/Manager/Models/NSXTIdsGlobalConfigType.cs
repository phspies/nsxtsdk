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
    public class NSXTIdsGlobalConfigType : NSXTGlobalConfigsType
    {
        /// <summary>
        /// When this flag is set to true, IDS events would be sent to syslog.
        /// </summary>
        [JsonProperty(PropertyName = "global_idsevents_to_syslog_enabled")]
        public bool? GlobalIdseventsToSyslogEnabled { get; set; }
    }
}
