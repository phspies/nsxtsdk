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
    public class NSXTResetNodeUserOwnPasswordPropertiesType 
    {
        public NSXTResetNodeUserOwnPasswordPropertiesType()
        {
        }
        /// <summary>
        /// The new password for user
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        [NSXTProperty(IsRequired: false, Description: @"The new password for user")]
        public string? Password { get; set; }
        /// <summary>
        /// If the old_password is not given, a 400 BAD REQUEST is returned with an error message.
        /// </summary>
        [JsonProperty(PropertyName = "old_password")]
        [NSXTProperty(IsRequired: false, Description: @"If the old_password is not given, a 400 BAD REQUEST is returned with an error message.")]
        public string? OldPassword { get; set; }
    }
}