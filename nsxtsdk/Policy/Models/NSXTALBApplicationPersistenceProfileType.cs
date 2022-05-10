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
    public class NSXTALBApplicationPersistenceProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie_persistence_profile")]
        public NSXTALBHttpCookiePersistenceProfileType HttpCookiePersistenceProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistence_profile")]
        public NSXTALBIPPersistenceProfileType IpPersistenceProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "app_cookie_persistence_profile")]
        public NSXTALBAppCookiePersistenceProfileType AppCookiePersistenceProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "hdr_persistence_profile")]
        public NSXTALBHdrPersistenceProfileType HdrPersistenceProfile { get; set; }
        /// <summary>
        /// Method used to persist clients to the same server for a
        /// duration of time or a session.
        /// Enum options - PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,
        /// PERSISTENCE_TYPE_HTTP_COOKIE, PERSISTENCE_TYPE_TLS,
        /// PERSISTENCE_TYPE_CLIENT_IPV6_ADDRESS,
        /// PERSISTENCE_TYPE_CUSTOM_HTTP_HEADER,
        /// PERSISTENCE_TYPE_APP_COOKIE, PERSISTENCE_TYPE_GSLB_SITE.
        /// Allowed in Basic(Allowed values-
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,PERSISTENCE_TYPE_HTTP_COOKIE)
        /// edition, Essentials(Allowed values-
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,PERSISTENCE_TYPE_HTTP_COOKIE)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbapplicationPersistenceProfilePersistenceTypeEnumType PersistenceType { get; set; }
        /// <summary>
        /// Specifies behavior when a persistent server has been marked
        /// down by a health monitor.
        /// Enum options - HM_DOWN_PICK_NEW_SERVER,
        /// HM_DOWN_ABORT_CONNECTION,
        /// HM_DOWN_CONTINUE_PERSISTENT_SERVER.
        /// Allowed in Basic(Allowed values- HM_DOWN_PICK_NEW_SERVER)
        /// edition, Essentials(Allowed values- HM_DOWN_PICK_NEW_SERVER)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as HM_DOWN_PICK_NEW_SERVER.
        /// </summary>
        [JsonProperty(PropertyName = "server_hm_down_recovery")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbapplicationPersistenceProfileServerHmDownRecoveryEnumType? ServerHmDownRecovery { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// This field describes the object's replication scope.
        /// If the field is set to false, then the object is visible
        /// within the controller-cluster and its associated
        /// service-engines.
        /// If the field is set to true, then the object is replicated
        /// across the federation.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
    }
}
