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
        [NSXTProperty(IsRequired: false, Description: @"If mode is DISABLE, then graceful restart and helper modes are disabled.If mode is GR_AND_HELPER, then both graceful restart and helper modes are enabled.If mode is HELPER_ONLY, then helper mode is enabled.HELPER_ONLY mode is the ability for a BGP speaker to indicate its abilityto preserve forwarding state during BGP restart.GRACEFUL_RESTART mode is the ability of a BGP speaker to advertise its restartto its peers.")]
        [NSXTDefaultProperty(Default: "HELPER_ONLY")]
        public NSXTBgpGracefulRestartConfigModeEnumType? Mode { get; set; }
        /// <summary>
        /// Configuration field to hold BGP restart timers.
        /// </summary>
        [JsonProperty(PropertyName = "timer")]
        [NSXTProperty(IsRequired: false, Description: @"Configuration field to hold BGP restart timers.")]
        public NSXTBgpGracefulRestartTimerType Timer { get; set; }
    }
}
