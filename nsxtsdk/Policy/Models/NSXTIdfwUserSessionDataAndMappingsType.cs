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
    /// Identity Firewall user session data list and Directory Group to user mappings.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall user session data list and Directory Group to user mappings.")]
    public class NSXTIdfwUserSessionDataAndMappingsType 
    {
        /// <summary>
        /// Archived user session data list
        /// </summary>
        [JsonProperty(PropertyName = "archived_user_sessions", Required = Required.AllowNull)]
        public IList<NSXTIdfwUserSessionDataType> ArchivedUserSessions { get; set; }
        /// <summary>
        /// Active user session data list
        /// </summary>
        [JsonProperty(PropertyName = "active_user_sessions", Required = Required.AllowNull)]
        public IList<NSXTIdfwUserSessionDataType> ActiveUserSessions { get; set; }
        /// <summary>
        /// Directory Group to user session data mappings
        /// </summary>
        [JsonProperty(PropertyName = "dir_group_to_user_session_data_mappings", Required = Required.AllowNull)]
        public IList<NSXTIdfwDirGroupUserSessionMappingType> DirGroupToUserSessionDataMappings { get; set; }
    }
}
