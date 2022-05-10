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
    /// BGP Graceful Restart configuration parameters
    /// </summary>
    [NSXTProperty(Description: @"BGP Graceful Restart configuration parameters")]
    public class NSXTGracefulRestartConfigType 
    {
        /// <summary>
        /// BGP Graceful Restart mode
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGracefulRestartConfigGracefulRestartModeEnumType? GracefulRestartMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_timer")]
        public NSXTGracefulRestartTimerType GracefulRestartTimer { get; set; }
    }
}
