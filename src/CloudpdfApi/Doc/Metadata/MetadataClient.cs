using CloudpdfApi;
using CloudpdfApi.Core;
using global::System.Text.Json;

namespace CloudpdfApi.Doc;

public partial class MetadataClient : IMetadataClient
{
    private readonly RawClient _client;

    internal MetadataClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<DocMetadataGet200Response>> GetAsyncCore(
        GetMetadataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudpdfApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudpdfApi.Core.HeadersBuilder.Builder()
            .Add("X-Document-Password", request.DocumentPassword)
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "v1/docs/{0}/layers/{1}/metadata",
                        ValueConvert.ToPathParameterString(request.DocId),
                        ValueConvert.ToPathParameterString(request.LayerName)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<DocMetadataGet200Response>(responseBody)!;
                return new WithRawResponse<DocMetadataGet200Response>()
                {
                    Data = responseData,
                    RawResponse = new CloudpdfApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CloudpdfApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new CloudpdfApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<object>(responseBody),
                            rawResponse: new CloudpdfApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new CloudpdfApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudpdfApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <example><code>
    /// await client.Doc.Metadata.GetAsync(
    ///     new GetMetadataRequest { DocId = "docId", LayerName = "layerName" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DocMetadataGet200Response> GetAsync(
        GetMetadataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DocMetadataGet200Response>(
            GetAsyncCore(request, options, cancellationToken)
        );
    }
}
