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
    public class NSXTAuthenticationPolicyPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// In order to trigger an account lockout, all authentication failures must occur in this time window. If the reset period
        /// expires, the failed login count is reset to zero. Only applies to NSX Manager nodes. Ignored on other node types.
        /// </summary>
        [JsonProperty(PropertyName = "api_failed_auth_reset_period")]
        public long? ApiFailedAuthResetPeriod { get; set; }
        /// <summary>
        /// Minimum number of characters required in account passwords
        /// </summary>
        [JsonProperty(PropertyName = "minimum_password_length")]
        public long? MinimumPasswordLength { get; set; }
        /// <summary>
        /// Once a lockout occurs, the account remains locked out of the CLI for this time period. While the lockout period is in
        /// effect, additional authentication attempts restart the lockout period, even if a valid password is specified.
        /// </summary>
        [JsonProperty(PropertyName = "cli_failed_auth_lockout_period")]
        public long? CliFailedAuthLockoutPeriod { get; set; }
        /// <summary>
        /// Only applies to NSX Manager nodes. Ignored on other node types.
        /// </summary>
        [JsonProperty(PropertyName = "api_max_auth_failures")]
        public long? ApiMaxAuthFailures { get; set; }
        /// <summary>
        /// Once a lockout occurs, the account remains locked out of the API for this time period. Only applies to NSX Manager
        /// nodes. Ignored on other node types.
        /// </summary>
        [JsonProperty(PropertyName = "api_failed_auth_lockout_period")]
        public long? ApiFailedAuthLockoutPeriod { get; set; }
        /// <summary>
        /// Number of authentication failures that trigger CLI lockout
        /// </summary>
        [JsonProperty(PropertyName = "cli_max_auth_failures")]
        public long? CliMaxAuthFailures { get; set; }
    }
}
