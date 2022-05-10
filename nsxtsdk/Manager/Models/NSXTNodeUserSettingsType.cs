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
    public class NSXTNodeUserSettingsType 
    {
        /// <summary>
        /// To configure username, you must provide this property together with
        /// <b>cli_password</b>. Username must contain ASCII characters only.
        /// </summary>
        [JsonProperty(PropertyName = "cli_username")]
        public string? CliUsername { get; set; }
        /// <summary>
        /// The default username is "audit". To configure username, you must provide
        /// this property together with <b>audit_password</b>. Username must contain
        /// ASCII characters only.
        /// </summary>
        [JsonProperty(PropertyName = "audit_username")]
        public string? AuditUsername { get; set; }
        /// <summary>
        /// Password for the node root user. For deployment,
        /// this property is required. After deployment, this property is ignored, and
        /// the node cli must be used to change the password.
        /// The password specified must be at least 12 characters in length and must
        /// contain at least one lowercase, one uppercase, one numeric character and
        /// one special character (except quotes). Passwords based on dictionary words
        /// and palindromes are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "root_password")]
        public string? RootPassword { get; set; }
        /// <summary>
        /// Password for the node cli user. For deployment,
        /// this property is required. After deployment, this property is ignored, and
        /// the node cli must be used to change the password.
        /// The password specified must be at least 12 characters in length and must
        /// contain at least one lowercase, one uppercase, one numeric character and
        /// one special character (except quotes). Passwords based on dictionary words
        /// and palindromes are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "cli_password")]
        public string? CliPassword { get; set; }
        /// <summary>
        /// Password for the node audit user. For deployment,
        /// this property is required. After deployment, this property is ignored, and
        /// the node cli must be used to change the password.
        /// The password specified must be at least 12 characters in length and must
        /// contain at least one lowercase, one uppercase, one numeric character and
        /// one special character (except quotes). Passwords based on dictionary words
        /// and palindromes are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "audit_password")]
        public string? AuditPassword { get; set; }
    }
}
