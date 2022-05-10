using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Role
    /// </summary>
    [NSXTProperty(Description: @"Role")]
    public class NSXTNsxRoleType 
    {
        /// <summary>
        /// This field represents the identifier of the role. With the introduction of custom roles, this field is no longer an
        /// enum.
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        public string Role { get; set; }
        /// <summary>
        /// Please use the /user-info/permissions api to get the permission that the user has on each feature.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public IList<string> Permissions { get; set; }
    }
}
