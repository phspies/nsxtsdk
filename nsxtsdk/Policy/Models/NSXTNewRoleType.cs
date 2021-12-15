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

namespace nsxtsdk.PolicyModels
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
        [NSXTProperty(IsRequired: true, Description: @"New role name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NewRoleName { get; set; }
        /// <summary>
        /// New role description
        /// </summary>
        [JsonProperty(PropertyName = "new_role_description")]
        [NSXTProperty(IsRequired: false, Description: @"New role description")]
        public string? NewRoleDescription { get; set; }
        /// <summary>
        /// New role id
        /// </summary>
        [JsonProperty(PropertyName = "new_role_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"New role id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NewRoleId { get; set; }
    }
}
