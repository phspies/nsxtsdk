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
    public class NSXTFirewallProfileListResultType : NSXTListResultType
    {
        public NSXTFirewallProfileListResultType()
        {
        }
        /// <summary>
        /// List of firewall profiles.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"List of firewall profiles.")]
        public IList<NSXTBaseFirewallProfileType> Results { get; set; }
    }
}
