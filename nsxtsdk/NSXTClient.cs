using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtapi;
using nsxtsdk.Authentication;
using nsxtsdk.Modules;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace nsxtsdk
{
    public class NSXTClient
    {
        private LoginRequestType credentials;
        private RestClient policyRestClient { get; set; }
        private RestClient managerRestClient { get; set; }
        private RestClient sessionRestClient { get; set; }
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public LoginResponseType LoginResponseDetails;

        public NSXTClient(string Host, string Username, string Password, bool? RemoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 100, int _retry = 2, string _defaultXAviVerion = null)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;

            credentials = new LoginRequestType(Username, Password);

            var managerUri = new UriBuilder(Host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port,
                Path = "/api/v1"
            }.Uri;
            var policyUri = new UriBuilder(Host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port,
                Path = "/policy/api/v1"
            }.Uri;
            var sessionUri = new UriBuilder(Host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port,
                Path = ""
            }.Uri;
            var policyRestOptions = new RestClientOptions() { BaseUrl = policyUri };
            var managerRestOptions = new RestClientOptions() { BaseUrl = managerUri };
            var sessionRestOptions = new RestClientOptions() { BaseUrl = sessionUri  };
            if (!RemoteCertificateValidation ?? false)
            {
                policyRestOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                managerRestOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                sessionRestOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            };
            policyRestClient = new RestClient(policyRestOptions);
            managerRestClient = new RestClient(managerRestOptions);
            sessionRestClient = new RestClient(sessionRestOptions);
            sessionRestClient.AcceptedContentTypes = new string[] { };

            if (DefaultSerializationSettings == null)
            {
                DefaultSerializationSettings = new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                    Converters = new List<JsonConverter>() { new Newtonsoft.Json.Converters.StringEnumConverter() }
                };
            };
            policyRestClient.UseNewtonsoftJson(DefaultSerializationSettings);
            managerRestClient.UseNewtonsoftJson(DefaultSerializationSettings);
            sessionRestClient.UseNewtonsoftJson(DefaultSerializationSettings);
            LoginResponseDetails = LoginAsync().Result;
        }
        public async Task<LoginResponseType> LoginAsync()
        {
            RestResponse<LoginResponseType> response = await AuthenticationHelper.LoginAsync(credentials, sessionRestClient, cancellationToken, timeout, retry);
            ArgumentNullException.ThrowIfNull(response.Data);
            ArgumentNullException.ThrowIfNull(response.Headers);
            ArgumentNullException.ThrowIfNull(response.Cookies);

            string xsrftoken = response.Headers.Single(x => x.Name == "X-XSRF-TOKEN").Value as string;
            Cookie jSessionID = response.Cookies.Single(x => x.Name == "JSESSIONID");
            ArgumentNullException.ThrowIfNull(xsrftoken);
            ArgumentNullException.ThrowIfNull(jSessionID);
            policyRestClient.AddCookie("JSESSIONID", jSessionID.Value, jSessionID.Path, jSessionID.Domain);
            managerRestClient.AddCookie("JSESSIONID", jSessionID.Value, jSessionID.Path, jSessionID.Domain);
            sessionRestClient.AddCookie("JSESSIONID", jSessionID.Value, jSessionID.Path, jSessionID.Domain);

            policyRestClient.AddDefaultHeader("X-XSRF-TOKEN", xsrftoken);
            managerRestClient.AddDefaultHeader("X-XSRF-TOKEN", xsrftoken);
            sessionRestClient.AddDefaultHeader("X-XSRF-TOKEN", xsrftoken);
            return response.Data;
        }
        public async Task LogoutAsync()
        {
            await AuthenticationHelper.LogoutAsync(sessionRestClient, cancellationToken, timeout, retry);
        }
        public PolicyEngine PolicyEngine => new PolicyEngine(policyRestClient);
        public ManagerEngine ManagerEngine => new ManagerEngine(managerRestClient);
    }
}