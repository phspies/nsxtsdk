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
    public class NSXTEdgeConfigurationStateType : NSXTConfigurationStateType
    {
        public NSXTEdgeConfigurationStateType()
        {
        }
        /// <summary>
        /// Request identifier of the API which modified the entity.
        /// </summary>
        [JsonProperty(PropertyName = "pending_change_list")]
        [NSXTProperty(IsRequired: false, Description: @"Request identifier of the API which modified the entity.")]
        public IList<string> PendingChangeList { get; set; }
    }
}
