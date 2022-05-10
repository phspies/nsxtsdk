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
    public class NSXTDfwFirewallConfigurationType : NSXTFirewallConfigurationType
    {
        /// <summary>
        /// If set to true, identity firewall is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "idfw_enabled")]
        public bool? IdfwEnabled { get; set; }
        /// <summary>
        /// Enables event log scraping for Identity firewall.
        /// </summary>
        [JsonProperty(PropertyName = "idfw_event_log_scraper_enabled")]
        public bool? IdfwEventLogScraperEnabled { get; set; }
        /// <summary>
        /// If set to true, collection of login/logout events from
        /// Loginsight server is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "idfw_loginsight_enabled")]
        public bool? IdfwLoginsightEnabled { get; set; }
    }
}
