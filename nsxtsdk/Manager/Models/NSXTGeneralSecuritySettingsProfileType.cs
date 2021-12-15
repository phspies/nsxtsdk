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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGeneralSecuritySettingsProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// The flag to indicate double flow check is enabled or not. This option applies only to EDGE components.
        /// </summary>
        [JsonProperty(PropertyName = "enable_double_flow")]
        [NSXTProperty(IsRequired: false, Description: @"The flag to indicate double flow check is enabled or not. This option applies only to EDGE components.")]
        public bool? EnableDoubleFlow { get; set; }
    }
}
