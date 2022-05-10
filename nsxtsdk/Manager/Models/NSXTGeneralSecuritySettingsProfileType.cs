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
    public class NSXTGeneralSecuritySettingsProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// The flag to indicate double flow check is enabled or not. This option applies only to EDGE components.
        /// </summary>
        [JsonProperty(PropertyName = "enable_double_flow")]
        public bool? EnableDoubleFlow { get; set; }
    }
}
