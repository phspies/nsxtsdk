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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIdsSignatureVersionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This flag tells the status of the signatures under a version.
        /// OUTDATED: It means the signatures under this version are outdated and new version is available.
        /// LATEST: It means the signatures of this version are up to date.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsSignatureVersionStatusEnumType? Status { get; set; }
        /// <summary>
        /// Represents the version's change log.
        /// </summary>
        [JsonProperty(PropertyName = "change_log")]
        public string? ChangeLog { get; set; }
        /// <summary>
        /// Time when this version was downloaded and saved.
        /// </summary>
        [JsonProperty(PropertyName = "update_time")]
        public long? UpdateTime { get; set; }
        /// <summary>
        /// Flag which tells whether the Signature version is uploaded by user or not.
        /// </summary>
        [JsonProperty(PropertyName = "user_uploaded")]
        public bool? UserUploaded { get; set; }
        /// <summary>
        /// This flag tells which Version is currently active.
        /// ACTIVE: It means the signatures under this version is currently been used
        /// under IDS Profiles.
        /// NOTACTIVE: It means signatures of this version are available but not
        /// being used in IDS Profiles.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsSignatureVersionStateEnumType? State { get; set; }
        /// <summary>
        /// Represents the version id.
        /// </summary>
        [JsonProperty(PropertyName = "version_id")]
        public string? VersionId { get; set; }
    }
}
