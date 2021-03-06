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
    public class NSXTALBVSDataScriptSetType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The Rate Limit definitions needed for this DataScript.
        /// The name is composed of the Virtual Service name and the
        /// DataScript name.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiters")]
        public IList<NSXTALBRateLimiterType> RateLimiters { get; set; }
        /// <summary>
        /// List of protocol parsers that could be referred by
        /// VSDataScriptSet objects.
        /// It is a reference to an object of type ProtocolParser.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "protocol_parser_paths")]
        public IList<string> ProtocolParserPaths { get; set; }
        /// <summary>
        /// DataScripts to execute.
        /// </summary>
        [JsonProperty(PropertyName = "datascript")]
        public IList<NSXTALBVSDataScriptType> Datascript { get; set; }
        /// <summary>
        /// path of String Groups that could be referred by
        /// VSDataScriptSet objects.
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_paths")]
        public IList<string> StringGroupPaths { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// path of IP Groups that could be referred by VSDataScriptSet
        /// objects.
        /// It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ipgroup_paths")]
        public IList<string> IpgroupPaths { get; set; }
        /// <summary>
        /// path of pool groups that could be referred by
        /// VSDataScriptSet objects.
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_paths")]
        public IList<string> PoolGroupPaths { get; set; }
        /// <summary>
        /// path of pools that could be referred by VSDataScriptSet
        /// objects.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_paths")]
        public IList<string> PoolPaths { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
