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
    /// Appliance registration access token
    /// </summary>
    [NSXTProperty(Description: @"Appliance registration access token")]
    public class NSXTRegistrationTokenType 
    {
        public NSXTRegistrationTokenType()
        {
        }
        /// <summary>
        /// Access token
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        [NSXTProperty(IsRequired: false, Description: @"Access token")]
        public string? Token { get; set; }
        /// <summary>
        /// User delegated by token
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        [NSXTProperty(IsRequired: false, Description: @"User delegated by token")]
        public string? User { get; set; }
        /// <summary>
        /// List results
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Roles { get; set; }
    }
}
