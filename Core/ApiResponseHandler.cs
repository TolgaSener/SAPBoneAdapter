﻿using System;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using BaseLibrary.Core.Contracts;

namespace BaseLibrary.Hosting.Api.Core
{
    public class ApiResponseHandler : DelegatingHandler
    {
        protected override async System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            System.Threading.CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            return BuildApiResponse(request, response);
        }

        private HttpResponseMessage BuildApiResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            object content = null;
            string errorMessage = string.Empty;

            ValidateApiResponse(response, ref content, ref errorMessage);

            var newResponse = CreateHttpResponseMessage(request, response, content, errorMessage);

            foreach (var loopHeader in response.Headers)
            {
                newResponse.Headers.Add(loopHeader.Key, loopHeader.Value);
            }

            return newResponse;
        }

        private HttpResponseMessage CreateHttpResponseMessage<T>(HttpRequestMessage request, HttpResponseMessage response, T content, string errorMessage)
        {
            return request.CreateResponse(response.StatusCode,
                new ApiResponse<T>(response.StatusCode, content, errorMessage));
        }

        private void ValidateApiResponse(HttpResponseMessage response, ref object content, ref string errorMessage)
        {
          //  if (content == null) throw new ArgumentNullException(nameof(content));
            if (response.TryGetContentValue(out content) && !response.IsSuccessStatusCode)
            {
                var error = content as HttpError;

                if (error != null)
                {
                    content = null;
                    var sb = new StringBuilder();

                    foreach (var loopError in error)
                    {
                        sb.Append($"{loopError.Key} {loopError.Value}");
                    }

                    errorMessage = sb.ToString();
                }
            }
        }
    }
}