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
    /// Provides upgrade summary for a specific site.
    /// </summary>
    [NSXTProperty(Description: @"Provides upgrade summary for a specific site.")]
    public class NSXTFederationUpgradeSummaryType 
    {
        /// <summary>
        /// This is NSX target version for the site, if it is undergoing upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// Type of this site.
        /// </summary>
        [JsonProperty(PropertyName = "site_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationUpgradeSummarySiteTypeEnumType? SiteType { get; set; }
        /// <summary>
        /// Indicates the time when the site was upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "last_upgrade_timestamp")]
        public string? LastUpgradeTimestamp { get; set; }
        /// <summary>
        /// List of component statuses
        /// </summary>
        [JsonProperty(PropertyName = "component_status")]
        public IList<NSXTFederationComponentUpgradeStatusType> ComponentStatus { get; set; }
        /// <summary>
        /// This is the Site Manager generated UUID for every NSX deployment.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Status of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "overall_upgrade_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationUpgradeSummaryOverallUpgradeStatusEnumType? OverallUpgradeStatus { get; set; }
        /// <summary>
        /// Name of the global manager if present.
        /// </summary>
        [JsonProperty(PropertyName = "gpm_name")]
        public string? GpmName { get; set; }
        /// <summary>
        /// IP address of the site.
        /// </summary>
        [JsonProperty(PropertyName = "site_ip")]
        public string? SiteIp { get; set; }
        /// <summary>
        /// This is NSX version for the site.
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// Unique identifier of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the site.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
