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
    /// Advanced load balancer HttpCacheConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HttpCacheConfig object")]
    public class NSXTALBHttpCacheConfigType 
    {
        /// <summary>
        /// Non-cacheable URI configuration with match criteria.
        /// </summary>
        [JsonProperty(PropertyName = "uri_non_cacheable")]
        [NSXTProperty(IsRequired: false, Description: @"Non-cacheable URI configuration with match criteria.")]
        public NSXTALBPathMatchType UriNonCacheable { get; set; }
        /// <summary>
        /// Whitelist string group of cacheable mime types.
        /// If both Cacheable Mime Types string list and string group
        /// are empty, this defaults to (STAR)/(STAR).
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_group_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Whitelist string group of cacheable mime types.If both Cacheable Mime Types string list and string groupare empty, this defaults to (STAR)/(STAR).It is a reference to an object of type StringGroup.")]
        public IList<string> MimeTypesGroupPaths { get; set; }
        /// <summary>
        /// Allow caching of objects whose URI included a query
        /// argument.
        /// When disabled, these objects are not cached.
        /// When enabled, the request must match the URI query to be
        /// considered a hit.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "query_cacheable")]
        [NSXTProperty(IsRequired: false, Description: @"Allow caching of objects whose URI included a queryargument.When disabled, these objects are not cached.When enabled, the request must match the URI query to beconsidered a hit.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? QueryCacheable { get; set; }
        /// <summary>
        /// Blacklist string group of non-cacheable mime types.
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_black_group_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Blacklist string group of non-cacheable mime types.It is a reference to an object of type StringGroup.")]
        public IList<string> MimeTypesBlackGroupPaths { get; set; }
        /// <summary>
        /// Add an Age header to content served from cache, which
        /// indicates to the client the number of seconds the object has
        /// been in the cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "age_header")]
        [NSXTProperty(IsRequired: false, Description: @"Add an Age header to content served from cache, whichindicates to the client the number of seconds the object hasbeen in the cache.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? AgeHeader { get; set; }
        /// <summary>
        /// Whitelist of cacheable mime types.
        /// If both Cacheable Mime Types string list and string group
        /// are empty, this defaults to (STAR)/(STAR).
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_list")]
        [NSXTProperty(IsRequired: false, Description: @"Whitelist of cacheable mime types.If both Cacheable Mime Types string list and string groupare empty, this defaults to (STAR)/(STAR).")]
        public IList<string> MimeTypesList { get; set; }
        /// <summary>
        /// Add an X-Cache header to content served from cache, which
        /// indicates to the client that the object was served from an
        /// intermediate cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "xcache_header")]
        [NSXTProperty(IsRequired: false, Description: @"Add an X-Cache header to content served from cache, whichindicates to the client that the object was served from anintermediate cache.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? XcacheHeader { get; set; }
        /// <summary>
        /// Enable/disable HTTP object caching.When enabling caching
        /// for the first time, SE Group app_cache_percent must beset to
        /// allocate shared memory required for caching (A service
        /// engine restart is needed after setting/resetting the SE
        /// group value).
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable/disable HTTP object caching.When enabling cachingfor the first time, SE Group app_cache_percent must beset toallocate shared memory required for caching (A serviceengine restart is needed after setting/resetting the SEgroup value).Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Default expiration time of cache objects received from the
        /// server without a Cache-Control expiration header.
        /// This value may be overwritten by the Heuristic Expire
        /// setting.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 600.
        /// </summary>
        [JsonProperty(PropertyName = "default_expire")]
        [NSXTProperty(IsRequired: false, Description: @"Default expiration time of cache objects received from theserver without a Cache-Control expiration header.This value may be overwritten by the Heuristic Expiresetting.Default value when not specified in API or module isinterpreted by ALB Controller as 600.")]
        [NSXTDefaultProperty(Default: "")]
        public long? DefaultExpire { get; set; }
        /// <summary>
        /// Max size, in bytes, of the cache.
        /// The default, zero, indicates auto configuration.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_cache_size")]
        [NSXTProperty(IsRequired: false, Description: @"Max size, in bytes, of the cache.The default, zero, indicates auto configuration.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxCacheSize { get; set; }
        /// <summary>
        /// Minimum size of an object to store in the cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "min_object_size")]
        [NSXTProperty(IsRequired: false, Description: @"Minimum size of an object to store in the cache.Default value when not specified in API or module isinterpreted by ALB Controller as 100.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MinObjectSize { get; set; }
        /// <summary>
        /// If a response object from the server does not include the
        /// Cache-Control header, but does include a Last-Modified
        /// header, the system will use this time to calculate the
        /// Cache-Control expiration.
        /// If unable to solicit an Last-Modified header, then the
        /// system will fall back to the Cache Expire Time value.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "heuristic_expire")]
        [NSXTProperty(IsRequired: false, Description: @"If a response object from the server does not include theCache-Control header, but does include a Last-Modifiedheader, the system will use this time to calculate theCache-Control expiration.If unable to solicit an Last-Modified header, then thesystem will fall back to the Cache Expire Time value.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? HeuristicExpire { get; set; }
        /// <summary>
        /// If a Date header was not added by the server, add a Date
        /// header to the object served from cache.
        /// This indicates to the client when the object was originally
        /// sent by the server to the cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "date_header")]
        [NSXTProperty(IsRequired: false, Description: @"If a Date header was not added by the server, add a Dateheader to the object served from cache.This indicates to the client when the object was originallysent by the server to the cache.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DateHeader { get; set; }
        /// <summary>
        /// Enable/disable caching objects without Cache-Control
        /// headers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "aggressive")]
        [NSXTProperty(IsRequired: false, Description: @"Enable/disable caching objects without Cache-Controlheaders.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? Aggressive { get; set; }
        /// <summary>
        /// Maximum size of an object to store in the cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4194304.
        /// </summary>
        [JsonProperty(PropertyName = "max_object_size")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum size of an object to store in the cache.Default value when not specified in API or module isinterpreted by ALB Controller as 4194304.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxObjectSize { get; set; }
        /// <summary>
        /// Blacklist of non-cacheable mime types.
        /// </summary>
        [JsonProperty(PropertyName = "mime_types_black_list")]
        [NSXTProperty(IsRequired: false, Description: @"Blacklist of non-cacheable mime types.")]
        public IList<string> MimeTypesBlackList { get; set; }
        /// <summary>
        /// Ignore client's cache control headers when fetching or
        /// storing from and to the cache.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_request_cache_control")]
        [NSXTProperty(IsRequired: false, Description: @"Ignore client&apos;s cache control headers when fetching orstoring from and to the cache.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? IgnoreRequestCacheControl { get; set; }
    }
}