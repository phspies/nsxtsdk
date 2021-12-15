// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBApplicationPersistenceProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specifies the HTTP Cookie Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie_persistence_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the HTTP Cookie Persistence profile parameters.")]
        public NSXTALBHttpCookiePersistenceProfileType HttpCookiePersistenceProfile { get; set; }
        /// <summary>
        /// Specifies the Client IP Persistence profile parameters.
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistence_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the Client IP Persistence profile parameters.")]
        public NSXTALBIPPersistenceProfileType IpPersistenceProfile { get; set; }
        /// <summary>
        /// Specifies the Application Cookie Persistence profile
        /// parameters.
        /// </summary>
        [JsonProperty(PropertyName = "app_cookie_persistence_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the Application Cookie Persistence profileparameters.")]
        public NSXTALBAppCookiePersistenceProfileType AppCookiePersistenceProfile { get; set; }
        /// <summary>
        /// Specifies the custom HTTP Header Persistence profile
        /// parameters.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_persistence_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the custom HTTP Header Persistence profileparameters.")]
        public NSXTALBHdrPersistenceProfileType HdrPersistenceProfile { get; set; }
        /// <summary>
        /// Method used to persist clients to the same server for a
        /// duration of time or a session.
        /// Enum options - PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,
        /// PERSISTENCE_TYPE_HTTP_COOKIE, PERSISTENCE_TYPE_TLS,
        /// PERSISTENCE_TYPE_CLIENT_IPV6_ADDRESS,
        /// PERSISTENCE_TYPE_CUSTOM_HTTP_HEADER,
        /// PERSISTENCE_TYPE_APP_COOKIE, PERSISTENCE_TYPE_GSLB_SITE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// PERSISTENCE_TYPE_CLIENT_IP_ADDRESS.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Method used to persist clients to the same server for aduration of time or a session.Enum options - PERSISTENCE_TYPE_CLIENT_IP_ADDRESS,PERSISTENCE_TYPE_HTTP_COOKIE, PERSISTENCE_TYPE_TLS,PERSISTENCE_TYPE_CLIENT_IPV6_ADDRESS,PERSISTENCE_TYPE_CUSTOM_HTTP_HEADER,PERSISTENCE_TYPE_APP_COOKIE, PERSISTENCE_TYPE_GSLB_SITE.Default value when not specified in API or module isinterpreted by ALB Controller asPERSISTENCE_TYPE_CLIENT_IP_ADDRESS.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "PERSISTENCE_TYPE_CLIENT_IP_ADDRESS")]
        public NSXTAlbapplicationPersistenceProfilePersistenceTypeEnumType PersistenceType { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"This field describes the object&apos;s replication scope.If the field is set to false, then the object is visiblewithin the controller-cluster and its associatedservice-engines.If the field is set to true, then the object is replicatedacross the federation.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Specifies behavior when a persistent server has been marked
        /// down by a health monitor.
        /// Enum options - HM_DOWN_PICK_NEW_SERVER,
        /// HM_DOWN_ABORT_CONNECTION,
        /// HM_DOWN_CONTINUE_PERSISTENT_SERVER.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as HM_DOWN_PICK_NEW_SERVER.
        /// </summary>
        [JsonProperty(PropertyName = "server_hm_down_recovery")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies behavior when a persistent server has been markeddown by a health monitor.Enum options - HM_DOWN_PICK_NEW_SERVER,HM_DOWN_ABORT_CONNECTION,HM_DOWN_CONTINUE_PERSISTENT_SERVER.Default value when not specified in API or module isinterpreted by ALB Controller as HM_DOWN_PICK_NEW_SERVER.")]
        [NSXTDefaultProperty(Default: "HM_DOWN_PICK_NEW_SERVER")]
        public NSXTAlbapplicationPersistenceProfileServerHmDownRecoveryEnumType? ServerHmDownRecovery { get; set; }
    }
}