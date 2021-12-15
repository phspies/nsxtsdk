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
    /// Advanced load balancer HttpCookiePersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HttpCookiePersistenceProfile object")]
    public class NSXTALBHttpCookiePersistenceProfileType 
    {
        /// <summary>
        /// HTTP cookie name for cookie persistence.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP cookie name for cookie persistence.")]
        public string? CookieName { get; set; }
        /// <summary>
        /// If no persistence cookie was received from the client,
        /// always send it.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "always_send_cookie")]
        [NSXTProperty(IsRequired: false, Description: @"If no persistence cookie was received from the client,always send it.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? AlwaysSendCookie { get; set; }
        /// <summary>
        /// Placeholder for description of property key of obj type
        /// HttpCookiePersistenceProfile field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property key of obj typeHttpCookiePersistenceProfile field type str  type array.")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// The maximum lifetime of any session cookie.
        /// No value or 'zero' indicates no timeout.
        /// Allowed values are 1-14400.
        /// Special values are 0- 'No Timeout'.
        /// Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        [NSXTProperty(IsRequired: false, Description: @"The maximum lifetime of any session cookie.No value or &apos;zero&apos; indicates no timeout.Allowed values are 1-14400.Special values are 0- &apos;No Timeout&apos;.Unit is MIN.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(14400)]
        public long? Timeout { get; set; }
        /// <summary>
        /// Key name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        [NSXTProperty(IsRequired: false, Description: @"Key name to use for cookie encryption.")]
        public string? EncryptionKey { get; set; }
    }
}