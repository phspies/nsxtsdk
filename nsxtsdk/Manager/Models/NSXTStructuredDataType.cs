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
    /// Structured data entry in RFC5424 log format
    /// </summary>
    [NSXTProperty(Description: @"Structured data entry in RFC5424 log format")]
    public class NSXTStructuredDataType 
    {
        /// <summary>
        /// Audit flag of the log
        /// </summary>
        [JsonProperty(PropertyName = "audit", Required = Required.AllowNull)]
        public string Audit { get; set; }
        /// <summary>
        /// Username value of the log
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// External request Id value of the log
        /// </summary>
        [JsonProperty(PropertyName = "ereq_id")]
        public string? EreqId { get; set; }
        /// <summary>
        /// Level value of the log
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string? Level { get; set; }
        /// <summary>
        /// Component value of the log
        /// </summary>
        [JsonProperty(PropertyName = "comp", Required = Required.AllowNull)]
        public string Comp { get; set; }
        /// <summary>
        /// Error Code value of the log
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Sub-subcomponent value of the log
        /// </summary>
        [JsonProperty(PropertyName = "s2comp")]
        public string? S2comp { get; set; }
        /// <summary>
        /// Request Id value of the log
        /// </summary>
        [JsonProperty(PropertyName = "req_id")]
        public string? ReqId { get; set; }
        /// <summary>
        /// Entity Id value of the log
        /// </summary>
        [JsonProperty(PropertyName = "ent_id")]
        public string? EntId { get; set; }
        /// <summary>
        /// Security flag of the log
        /// </summary>
        [JsonProperty(PropertyName = "security")]
        public string? Security { get; set; }
        /// <summary>
        /// Subcomponent value of the log
        /// </summary>
        [JsonProperty(PropertyName = "subcomp", Required = Required.AllowNull)]
        public string Subcomp { get; set; }
    }
}
