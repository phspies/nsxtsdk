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
    public class NSXTFirewallSectionStateType : NSXTDSSectionStateType
    {
        /// <summary>
        /// Pending changes to be realized.
        /// </summary>
        [JsonProperty(PropertyName = "pending_change_list", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Pending changes to be realized.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPendingChangeType> PendingChangeList { get; set; }
    }
}