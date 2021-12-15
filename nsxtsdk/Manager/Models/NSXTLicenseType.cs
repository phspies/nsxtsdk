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
    public class NSXTLicenseType : NSXTResourceType
    {
        /// <summary>
        /// semicolon delimited feature list
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        [NSXTProperty(IsRequired: false, Description: @"semicolon delimited feature list")]
        public string? Features { get; set; }
        /// <summary>
        /// license edition
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"license edition")]
        public string? Description { get; set; }
        /// <summary>
        /// product version
        /// </summary>
        [JsonProperty(PropertyName = "product_version")]
        [NSXTProperty(IsRequired: false, Description: @"product version")]
        public string? ProductVersion { get; set; }
        /// <summary>
        /// date that license expires
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        [NSXTProperty(IsRequired: false, Description: @"date that license expires")]
        public long? Expiry { get; set; }
        /// <summary>
        /// true for evalution license
        /// </summary>
        [JsonProperty(PropertyName = "is_eval")]
        [NSXTProperty(IsRequired: false, Description: @"true for evalution license")]
        public bool? IsEval { get; set; }
        /// <summary>
        /// multi-hypervisor support
        /// </summary>
        [JsonProperty(PropertyName = "is_mh")]
        [NSXTProperty(IsRequired: false, Description: @"multi-hypervisor support")]
        public bool? IsMh { get; set; }
        /// <summary>
        /// license key
        /// </summary>
        [JsonProperty(PropertyName = "license_key")]
        [NSXTProperty(IsRequired: false, Description: @"license key")]
        public string? LicenseKey { get; set; }
        /// <summary>
        /// whether the license has expired
        /// </summary>
        [JsonProperty(PropertyName = "is_expired")]
        [NSXTProperty(IsRequired: false, Description: @"whether the license has expired")]
        public bool? IsExpired { get; set; }
        /// <summary>
        /// product name
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        [NSXTProperty(IsRequired: false, Description: @"product name")]
        public string? ProductName { get; set; }
        /// <summary>
        /// License metrics specifying the capacity type of license key.
        /// Types are:
        /// - VM
        /// - CPU
        /// - USER(Concurrent User)
        /// - CORE
        /// - HOST
        /// </summary>
        [JsonProperty(PropertyName = "capacity_type")]
        [NSXTProperty(IsRequired: false, Description: @"License metrics specifying the capacity type of license key.Types are:- VM- CPU- USER(Concurrent User)- CORE- HOST")]
        public NSXTLicenseCapacityTypeEnumType? CapacityType { get; set; }
        /// <summary>
        /// license capacity; 0 for unlimited
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        [NSXTProperty(IsRequired: false, Description: @"license capacity; 0 for unlimited")]
        public long? Quantity { get; set; }
    }
}
