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
    /// Role
    /// </summary>
    [NSXTProperty(Description: @"Role")]
    public class NSXTNsxRoleType 
    {
        public NSXTNsxRoleType()
        {
        }
        /// <summary>
        /// This field represents the identifier of the role. With the introduction of custom roles, this field is no longer an
        /// enum.
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This field represents the identifier of the role. With the introduction of custom roles, this field is no longer an enum.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Role { get; set; }
        /// <summary>
        /// Please use the /user-info/permissions api to get the permission that the user has on each feature.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        [NSXTProperty(IsRequired: false, Description: @"Please use the /user-info/permissions api to get the permission that the user has on each feature.")]
        public IList<string> Permissions { get; set; }
    }
}
