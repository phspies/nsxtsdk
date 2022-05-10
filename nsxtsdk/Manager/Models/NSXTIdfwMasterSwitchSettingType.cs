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
    /// Identity Firewall master switch setting.  This setting enables or disables
        /// Identity Firewall feature across the system.  It affects compute collections,
        /// hypervisor and virtual machines.  This operation is expensive and also has big
        /// impact and implication on system perforamce.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall master switch setting.  This setting enables or disablesIdentity Firewall feature across the system.  It affects compute collections,hypervisor and virtual machines.  This operation is expensive and also has bigimpact and implication on system perforamce.")]
    public class NSXTIdfwMasterSwitchSettingType 
    {
        /// <summary>
        /// IDFW master switch (true=Enabled / false=Disabled).
        /// </summary>
        [JsonProperty(PropertyName = "idfw_master_switch_enabled", Required = Required.AllowNull)]
        public bool IdfwMasterSwitchEnabled { get; set; }
    }
}
