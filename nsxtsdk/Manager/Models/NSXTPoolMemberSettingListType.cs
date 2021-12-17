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
    /// List of PoolMemberSetting
    /// </summary>
    [NSXTProperty(Description: @"List of PoolMemberSetting")]
    public class NSXTPoolMemberSettingListType 
    {
        public NSXTPoolMemberSettingListType()
        {
        }
        /// <summary>
        /// List of pool member settings to be passed to add, update and remove APIs
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of pool member settings to be passed to add, update and remove APIs")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPoolMemberSettingType> Members { get; set; }
    }
}
