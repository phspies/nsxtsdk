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
    /// List of PoolMemberSetting
    /// </summary>
    [NSXTProperty(Description: @"List of PoolMemberSetting")]
    public class NSXTPoolMemberSettingListType 
    {
        /// <summary>
        /// List of pool member settings to be passed to add, update and remove APIs
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<NSXTPoolMemberSettingType> Members { get; set; }
    }
}
