// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public bool? IdfwEnabled { get; set; }
        /// <summary>
        /// Enables event log scraping for Identity firewall.
        /// </summary>
        public bool? IdfwEventLogScraperEnabled { get; set; }
        /// <summary>
        /// If set to true, collection of login/logout events from
        /// Loginsight server is enabled.
        /// </summary>
        public bool? IdfwLoginsightEnabled { get; set; }
    }
}
