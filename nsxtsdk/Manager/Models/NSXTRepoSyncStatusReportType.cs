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
    public class NSXTRepoSyncStatusReportType 
    {
        /// <summary>
        /// Status of the repo sync operation on the single nsx-manager
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRepoSyncStatusReportStatusEnumType Status { get; set; }
        /// <summary>
        /// Describes the steps which repo sync operation is performing currently.
        /// </summary>
        [JsonProperty(PropertyName = "status_message")]
        public string? StatusMessage { get; set; }
        /// <summary>
        /// In case if repo sync fails due to some issue, an error message will be
        /// stored here.
        /// </summary>
        [JsonProperty(PropertyName = "failure_message")]
        public string? FailureMessage { get; set; }
        /// <summary>
        /// In case of repo sync related failure, the code for the error will
        /// be stored here.
        /// </summary>
        [JsonProperty(PropertyName = "failure_code")]
        public long? FailureCode { get; set; }
    }
}
