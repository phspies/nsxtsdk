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
    /// Configuration field to hold BGP restart mode and timer.
    /// </summary>
    [NSXTProperty(Description: @"Configuration field to hold BGP restart mode and timer.")]
    public class NSXTBgpGracefulRestartConfigType 
    {
        /// <summary>
        /// If mode is DISABLE, then graceful restart and helper modes are disabled.
        /// If mode is GR_AND_HELPER, then both graceful restart and helper modes are enabled.
        /// If mode is HELPER_ONLY, then helper mode is enabled.
        /// HELPER_ONLY mode is the ability for a BGP speaker to indicate its ability
        /// to preserve forwarding state during BGP restart.
        /// GRACEFUL_RESTART mode is the ability of a BGP speaker to advertise its restart
        /// to its peers.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpGracefulRestartConfigModeEnumType? Mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "timer")]
        public NSXTBgpGracefulRestartTimerType Timer { get; set; }
    }
}
