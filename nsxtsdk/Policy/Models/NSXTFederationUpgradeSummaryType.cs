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
    /// Provides upgrade summary for a specific site.
    /// </summary>
    [NSXTProperty(Description: @"Provides upgrade summary for a specific site.")]
    public class NSXTFederationUpgradeSummaryType 
    {
        /// <summary>
        /// This is NSX target version for the site, if it is undergoing upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        [NSXTProperty(IsRequired: false, Description: @"This is NSX target version for the site, if it is undergoing upgrade.")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// Type of this site.
        /// </summary>
        [JsonProperty(PropertyName = "site_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of this site.")]
        public NSXTFederationUpgradeSummarySiteTypeEnumType? SiteType { get; set; }
        /// <summary>
        /// Indicates the time when the site was upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "last_upgrade_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates the time when the site was upgraded.")]
        public string? LastUpgradeTimestamp { get; set; }
        /// <summary>
        /// List of component statuses
        /// </summary>
        [JsonProperty(PropertyName = "component_status")]
        [NSXTProperty(IsRequired: false, Description: @"List of component statuses")]
        public IList<NSXTFederationComponentUpgradeStatusType> ComponentStatus { get; set; }
        /// <summary>
        /// This is the Site Manager generated UUID for every NSX deployment.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        [NSXTProperty(IsRequired: false, Description: @"This is the Site Manager generated UUID for every NSX deployment.")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Status of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "overall_upgrade_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of upgrade")]
        public NSXTFederationUpgradeSummaryOverallUpgradeStatusEnumType? OverallUpgradeStatus { get; set; }
        /// <summary>
        /// Name of the global manager if present.
        /// </summary>
        [JsonProperty(PropertyName = "gpm_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the global manager if present.")]
        public string? GpmName { get; set; }
        /// <summary>
        /// IP address of the site.
        /// </summary>
        [JsonProperty(PropertyName = "site_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of the site.")]
        public string? SiteIp { get; set; }
        /// <summary>
        /// This is NSX version for the site.
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        [NSXTProperty(IsRequired: false, Description: @"This is NSX version for the site.")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// Unique identifier of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of this resource.")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the site.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the site.")]
        public string? Name { get; set; }
    }
}
