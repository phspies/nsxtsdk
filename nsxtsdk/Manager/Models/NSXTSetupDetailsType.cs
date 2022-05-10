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
    /// Contains Setup details of nsx appliance.
    /// </summary>
    [NSXTProperty(Description: @"Contains Setup details of nsx appliance.")]
    public class NSXTSetupDetailsType 
    {
        /// <summary>
        /// User principal.
        /// </summary>
        [JsonProperty(PropertyName = "principal_identity")]
        public string? PrincipalIdentity { get; set; }
    }
}
