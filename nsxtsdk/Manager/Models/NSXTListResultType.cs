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
    public class NSXTListResultType : NSXTResourceType
    {
        /// <summary>
        /// Opaque cursor to be used for getting next page of records (supplied by current result page)
        /// </summary>
        [JsonProperty(PropertyName = "cursor")]
        public string? Cursor { get; set; }
        /// <summary>
        /// If true, results are sorted in ascending order
        /// </summary>
        [JsonProperty(PropertyName = "sort_ascending")]
        public bool? SortAscending { get; set; }
        /// <summary>
        /// Field by which records are sorted
        /// </summary>
        [JsonProperty(PropertyName = "sort_by")]
        public string? SortBy { get; set; }
        /// <summary>
        /// Count of results found (across all pages), set only on first page
        /// </summary>
        [JsonProperty(PropertyName = "result_count")]
        public long? ResultCount { get; set; }
    }
}
