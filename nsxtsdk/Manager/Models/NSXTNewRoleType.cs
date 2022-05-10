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
    /// New Role
    /// </summary>
    [NSXTProperty(Description: @"New Role")]
    public class NSXTNewRoleType 
    {
        /// <summary>
        /// New role name
        /// </summary>
        [JsonProperty(PropertyName = "new_role_name", Required = Required.AllowNull)]
        public string NewRoleName { get; set; }
        /// <summary>
        /// New role description
        /// </summary>
        [JsonProperty(PropertyName = "new_role_description")]
        public string? NewRoleDescription { get; set; }
        /// <summary>
        /// New role id
        /// </summary>
        [JsonProperty(PropertyName = "new_role_id", Required = Required.AllowNull)]
        public string NewRoleId { get; set; }
    }
}
