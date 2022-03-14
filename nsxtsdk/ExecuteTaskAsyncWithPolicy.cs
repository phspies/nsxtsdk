using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Polly;
using Polly.Timeout;
using RestSharp;

namespace nsxtsdk
{
    public static class RestSharpExtentions
    {
        public static async Task<IRestResponse> ExecuteTaskAsyncWithPolicy(this IRestClient client, IRestRequest request, CancellationToken cancellationToken = default(CancellationToken), int timeout = 5, int retry = 2)
        {
            var timeoutPolicy = Policy.TimeoutAsync<IRestResponse>(timeout);

            var timeoutRetryPolicy = Policy<IRestResponse>
                                        .Handle<TimeoutRejectedException>() // thrown by Polly's TimeoutPolicy if the inner call times out
                                        .WaitAndRetryAsync(
                                            retryCount: retry,
                                            sleepDurationProvider: attempt => TimeSpan.FromSeconds(0.25 * Math.Pow(2, attempt)), // Back off!  2, 4, 8 etc times 1/4-second = 0.5, 1, 2 seconds
                                            onRetryAsync: RetryDelegateAsync
                                        );

            var restResponsePolicy = Policy
                                        .HandleResult<IRestResponse>(result => result.ResponseStatus != ResponseStatus.Completed)
                                        .WaitAndRetryAsync(
                                        retryCount: retry, //2: retryCountOnBadResult
                                        sleepDurationProvider: attempt => TimeSpan.FromSeconds(0.25 * Math.Pow(2, attempt)), // Back off!  2, 4, 8 etc times 1/4-second = 0.5, 1, 2 seconds
                                        onRetryAsync: RetryDelegateAsync
                                        );

            // The goal is to place the timeoutPolicy inside the resultPolicy, to make it time out each try.
            var finalPolicy = Policy.WrapAsync(restResponsePolicy, timeoutRetryPolicy, timeoutPolicy); //timeoutPolicy is innermost and responseResultPolicy is outermost.

            var policyResult = await finalPolicy.ExecuteAndCaptureAsync((context, ct) => client.ExecuteAsync(request, ct),
                                        contextData: new Dictionary<string, object>
                                        {
                                    { "ParamToPassToRetryDelegate", "ParamValue" }
                                        },
                                        cancellationToken
                                        );

            if (policyResult.Outcome == OutcomeType.Successful)
            {
                return policyResult.Result;
            }
            else if (policyResult.FinalException != null)
            {
                return new RestResponse
                {
                    Request = request,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                return new RestResponse
                {
                    Request = request,
                    ErrorException = new Exception(policyResult.FinalHandledResult?.ErrorMessage)
                };
            }

        }

        public static async Task<IRestResponse<T>> ExecuteTaskAsyncWithPolicy<T>(this IRestClient client, IRestRequest request, CancellationToken cancellationToken = default(CancellationToken), int timeout = 5, int retry = 2)
        {
            var timeoutPolicy = Policy.TimeoutAsync<IRestResponse<T>>(timeout);

            var timeoutRetryPolicy = Policy<IRestResponse<T>>
                                        .Handle<TimeoutRejectedException>() // thrown by Polly's TimeoutPolicy if the inner call times out
                                        .WaitAndRetryAsync(
                                            retryCount: retry, 
                                            sleepDurationProvider: attempt => TimeSpan.FromSeconds(0.25 * Math.Pow(2, attempt)), // Back off!  2, 4, 8 etc times 1/4-second = 0.5, 1, 2 seconds
                                            onRetryAsync: RetryDelegateAsync
                                        );

            var restResponsePolicy = Policy
                                        .HandleResult<IRestResponse<T>>(result => result.ResponseStatus != ResponseStatus.Completed)
                                        .WaitAndRetryAsync(
                                        retryCount: retry, //2: retryCountOnBadResult
                                        sleepDurationProvider: attempt => TimeSpan.FromSeconds(0.25 * Math.Pow(2, attempt)), // Back off!  2, 4, 8 etc times 1/4-second = 0.5, 1, 2 seconds
                                        onRetryAsync: RetryDelegateAsync
                                        );

            // The goal is to place the timeoutPolicy inside the resultPolicy, to make it time out each try.
            var finalPolicy = Policy.WrapAsync(restResponsePolicy, timeoutRetryPolicy, timeoutPolicy); //timeoutPolicy is innermost and responseResultPolicy is outermost.

            var policyResult = await finalPolicy.ExecuteAndCaptureAsync((context, ct) => client.ExecuteAsync<T>(request, ct),
                                        contextData: new Dictionary<string, object>
                                        {
                                    { "ParamToPassToRetryDelegate", "ParamValue" }
                                        },
                                        cancellationToken
                                        );

            if (policyResult.Outcome == OutcomeType.Successful)
            {
                return policyResult.Result;
            }
            else if (policyResult.FinalException != null)
            {
                return new RestResponse<T>
                {
                    Request = request,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                return new RestResponse<T>
                {
                    Request = request,
                    ErrorException = new Exception(policyResult.FinalHandledResult?.ErrorMessage)
                };
            }

        }
        public static Task RetryDelegateAsync<T>(DelegateResult<T> result, TimeSpan calculatedWaitDuration, int retryCount, Context context)
        {
            // This is our new exception handler! 
            var msg = $"The control has fallen into Polly's retry method. This is retry attempt: {retryCount}.\n"; // msg is useful for logging
            if (result is TimeoutRejectedException) msg += $"Operation failed after a timeout.\n";

            if (result.Exception != null)
            {
                msg += $"Handled exception triggered this. Exception message is: {result.Exception.Message}.\n";
            }

            if (result.Result != null)
            {
                msg += "Handled exception didn't trigger this but defined policies did. It relates to HandleResult you have defined in your policy. Check error log to find more details about it.\n";
            }

            msg += $"A retry will be made after waiting {calculatedWaitDuration.TotalMilliseconds} milliseconds.";

            // Log this only if you want to. You don't have to though.
            // Access ParamValue of ParamToPassToRetryDelegate using context["ParamToPassToRetryDelegate"]
            var paramValue = context["ParamToPassToRetryDelegate"].ToString(); // Might be useful for logging
            return Task.CompletedTask;
        }
    }
}
