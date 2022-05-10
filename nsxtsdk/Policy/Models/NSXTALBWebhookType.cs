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
    public class NSXTALBWebhookType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Verification token sent back with the callback asquery
        /// parameters.
        /// </summary>
        [JsonProperty(PropertyName = "verification_token")]
        public string? VerificationToken { get; set; }
        /// <summary>
        /// Callback URL for the Webhook.
        /// </summary>
        [JsonProperty(PropertyName = "callback_url")]
        public string? CallbackUrl { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
