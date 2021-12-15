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
    /// Advanced load balancer AuthenticationAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthenticationAction object")]
    public class NSXTALBAuthenticationActionType 
    {
        /// <summary>
        /// Authentication Action to be taken for a matched Rule.
        /// Enum options - SKIP_AUTHENTICATION,
        /// USE_DEFAULT_AUTHENTICATION.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as USE_DEFAULT_AUTHENTICATION.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Authentication Action to be taken for a matched Rule.Enum options - SKIP_AUTHENTICATION,USE_DEFAULT_AUTHENTICATION.Default value when not specified in API or module isinterpreted by ALB Controller as USE_DEFAULT_AUTHENTICATION.")]
        [NSXTDefaultProperty(Default: "USE_DEFAULT_AUTHENTICATION")]
        public NSXTAlbauthenticationActionTypeEnumType? Type { get; set; }
    }
}
