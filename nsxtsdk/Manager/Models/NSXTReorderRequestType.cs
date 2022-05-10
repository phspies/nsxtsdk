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
    public class NSXTReorderRequestType 
    {
        /// <summary>
        /// flag indicating whether the upgrade unit group/upgrade unit is to be placed before or after the specified upgrade unit
        /// group/upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "is_before")]
        public bool? IsBefore { get; set; }
        /// <summary>
        /// id of the upgrade unit group/upgrade unit before/after which the upgrade unit group/upgrade unit is to be placed
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
    }
}
