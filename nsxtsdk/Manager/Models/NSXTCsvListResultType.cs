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
    /// Base type for CSV result.
    /// </summary>
    [NSXTProperty(Description: @"Base type for CSV result.")]
    public class NSXTCsvListResultType 
    {
        /// <summary>
        /// File name set by HTTP server if API  returns CSV result as a file.
        /// </summary>
        [JsonProperty(PropertyName = "file_name")]
        public string? FileName { get; set; }
    }
}
