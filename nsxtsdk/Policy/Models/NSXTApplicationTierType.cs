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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTApplicationTierType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This represents the subnet that is associated with tier.
        /// If this is specified, size property is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "ip_range")]
        [NSXTProperty(IsRequired: false, Description: @"This represents the subnet that is associated with tier.If this is specified, size property is ignored.")]
        public string? IpRange { get; set; }
        /// <summary>
        /// There are three kinds of Access Types supported for an Application.
        /// Public  - Tier is accessible from external networks and its IP is picked up from public IP
        /// addresses from VHC configuration unless specified explicitly by user.
        /// Private - Tier is accessbile only within the application and its IP is picked up from
        /// private IP addresses from VHC configuration unless specified explicitly by user.
        /// Shared  - Tier is accessible within the scope of VHC and its IP is picked up from private
        /// IP addresses from VHC configuration unless specified explicitly by user.
        /// </summary>
        [JsonProperty(PropertyName = "access_type")]
        [NSXTProperty(IsRequired: false, Description: @"There are three kinds of Access Types supported for an Application.Public  - Tier is accessible from external networks and its IP is picked up from public IP          addresses from VHC configuration unless specified explicitly by user.Private - Tier is accessbile only within the application and its IP is picked up from          private IP addresses from VHC configuration unless specified explicitly by user.Shared  - Tier is accessible within the scope of VHC and its IP is picked up from private          IP addresses from VHC configuration unless specified explicitly by user.")]
        [NSXTDefaultProperty(Default: "Shared")]
        public NSXTApplicationTierAccessTypeEnumType? AccessType { get; set; }
        /// <summary>
        /// ONE  - 1       XXS - 8
        /// XS   - 16        S - 32
        /// M    - 64        L - 128
        /// XL   - 256     XXL - 512
        /// XXXL - 1024
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        [NSXTProperty(IsRequired: false, Description: @"ONE  - 1       XXS - 8XS   - 16        S - 32M    - 64        L - 128XL   - 256     XXL - 512XXXL - 1024")]
        [NSXTDefaultProperty(Default: "XXS")]
        public NSXTApplicationTierSizeEnumType? Size { get; set; }
    }
}
