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
    /// User Login/Logout event Map
    /// </summary>
    [NSXTProperty(Description: @"User Login/Logout event Map")]
    public class NSXTLoginLogoutEventMapType 
    {
        public NSXTLoginLogoutEventMapType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "event_source", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLoginLogoutEventMapEventSourceEnumType EventSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "event_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLoginLogoutEventMapEventTypeEnumType EventType { get; set; }
        /// <summary>
        /// Timestamp in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "event_time", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Timestamp in milliseconds since epoch")]
        [System.ComponentModel.DataAnnotations.Required]
        public long EventTime { get; set; }
        /// <summary>
        /// IP Address of user
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP Address of user")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpAddress { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"User name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string UserName { get; set; }
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Domain name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DomainName { get; set; }
    }
}