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
    /// Advanced load balancer HealthMonitorSmtp object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorSmtp object")]
    public class NSXTALBHealthMonitorSmtpType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
        /// <summary>
        /// Mail recipients.
        /// </summary>
        [JsonProperty(PropertyName = "recipients_ids")]
        public IList<string> RecipientsIds { get; set; }
        /// <summary>
        /// Mail sender.
        /// </summary>
        [JsonProperty(PropertyName = "sender_id")]
        public string? SenderId { get; set; }
        /// <summary>
        /// Mail data.
        /// </summary>
        [JsonProperty(PropertyName = "mail_data")]
        public string? MailData { get; set; }
        /// <summary>
        /// Sender domain name.
        /// </summary>
        [JsonProperty(PropertyName = "domainname")]
        public string? Domainname { get; set; }
    }
}
