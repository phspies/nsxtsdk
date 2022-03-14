// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Upload status of upgrade bundle uploaded from url
    /// </summary>
    [NSXTProperty(Description: @"Upload status of upgrade bundle uploaded from url")]
    public class NSXTUpgradeBundleUploadStatusType 
    {
        /// <summary>
        /// URL for uploading upgrade bundle
        /// </summary>
        public string? Url { get; set; }
        /// <summary>
        /// Current status of upgrade bundle upload
        /// </summary>
        public NSXTUpgradeBundleUploadStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Detailed status of upgrade bundle upload
        /// </summary>
        public string? DetailedStatus { get; set; }
        /// <summary>
        /// Percent of bundle uploaded from URL
        /// </summary>
        public double? Percent { get; set; }
    }
}
