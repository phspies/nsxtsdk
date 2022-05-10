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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMigrationDataInfoType 
    {
        /// <summary>
        /// Type of the Migration data file for which info is requested.
        /// </summary>
        [JsonProperty(PropertyName = "file_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationDataInfoFileTypeEnumType? FileType { get; set; }
        /// <summary>
        /// Absolute location of the file.
        /// </summary>
        [JsonProperty(PropertyName = "file_location")]
        public string? FileLocation { get; set; }
        /// <summary>
        /// Id of the site in NSX-T Federation
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id")]
        public string? FederationSiteId { get; set; }
        /// <summary>
        /// Indicates if the file is present.
        /// </summary>
        [JsonProperty(PropertyName = "is_present")]
        public bool? IsPresent { get; set; }
    }
}
