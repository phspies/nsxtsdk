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
    public class NSXTNodeUserPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// User login name (must be "root" if userid is 0)
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Status of the user. This value can be ACTIVE indicating authentication attempts will be successful if the correct
        /// credentials are specified. The value can also be PASSWORD_EXPIRED indicating authentication attempts will fail because
        /// the user's password has expired and must be changed. Or, this value can be NOT_ACTIVATED indicating the user's password
        /// has not yet been set and must be set before the user can authenticate.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeUserPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of days since password was last changed
        /// </summary>
        [JsonProperty(PropertyName = "last_password_change")]
        public long? LastPasswordChange { get; set; }
        /// <summary>
        /// Full name for the user
        /// </summary>
        [JsonProperty(PropertyName = "full_name")]
        public string? FullName { get; set; }
        /// <summary>
        /// Number of days password is valid before it must be changed. This can be set to 0 to indicate no password change is
        /// required or a positive integer up to 9999. By default local user passwords must be changed every 90 days.
        /// </summary>
        [JsonProperty(PropertyName = "password_change_frequency")]
        public long? PasswordChangeFrequency { get; set; }
        /// <summary>
        /// Boolean value that states if a password reset is required
        /// </summary>
        [JsonProperty(PropertyName = "password_reset_required")]
        public bool? PasswordResetRequired { get; set; }
        /// <summary>
        /// Password for the user (optionally specified on PUT, unspecified on GET)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Numeric id for the user
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public long? Userid { get; set; }
        /// <summary>
        /// Old password for the user (required on PUT if password specified)
        /// </summary>
        [JsonProperty(PropertyName = "old_password")]
        public string? OldPassword { get; set; }
    }
}
