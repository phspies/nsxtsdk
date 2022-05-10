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
    /// Represents the Site resource information for a Span entity
        /// including both the internal id as well as the site path.
    /// </summary>
    [NSXTProperty(Description: @"Represents the Site resource information for a Span entityincluding both the internal id as well as the site path.")]
    public class NSXTSpanSiteInfoType 
    {
        /// <summary>
        /// Path of the Site resource
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Site UUID representing the Site resource
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
    }
}
