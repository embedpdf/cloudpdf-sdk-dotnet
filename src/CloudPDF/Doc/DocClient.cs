using CloudPDF.Core;
using CloudPDF.Doc;
using global::System.Text.Json;

namespace CloudPDF;

public partial class DocClient : IDocClient
{
    private readonly RawClient _client;

    internal DocClient(RawClient client)
    {
        _client = client;
        Annotations = new AnnotationsClient(_client);
        Forms = new FormsClient(_client);
        Metadata = new MetadataClient(_client);
        Pages = new PagesClient(_client);
        Redactions = new RedactionsClient(_client);
    }

    public IAnnotationsClient Annotations { get; }

    public IFormsClient Forms { get; }

    public IMetadataClient Metadata { get; }

    public IPagesClient Pages { get; }

    public IRedactionsClient Redactions { get; }

    private async Task<WithRawResponse<DocHead200Response>> HeadAsyncCore(
        HeadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudPDF.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudPDF.Core.HeadersBuilder.Builder()
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
                        "v1/docs/{0}/head",
                        ValueConvert.ToPathParameterString(request.DocId)
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
                var responseData = JsonUtils.Deserialize<DocHead200Response>(responseBody)!;
                return new WithRawResponse<DocHead200Response>()
                {
                    Data = responseData,
                    RawResponse = new CloudPDF.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CloudPDFApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new CloudPDF.RawResponse()
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
                            rawResponse: new CloudPDF.RawResponse()
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
            throw new CloudPDFApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<global::System.IO.Stream>> DownloadAsyncCore(
        DownloadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudPDF.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudPDF.Core.HeadersBuilder.Builder()
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
                        "v1/docs/{0}/layers/{1}/download",
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
            var stream = await response.Raw.Content.ReadAsStreamAsync();
            return new WithRawResponse<global::System.IO.Stream>()
            {
                Data = stream,
                RawResponse = new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                },
            };
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
                            rawResponse: new CloudPDF.RawResponse()
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
            throw new CloudPDFApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<DocManifest200Response>> ManifestAsyncCore(
        ManifestDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudPDF.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudPDF.Core.HeadersBuilder.Builder()
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
                        "v1/docs/{0}/layers/{1}/manifest",
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
                var responseData = JsonUtils.Deserialize<DocManifest200Response>(responseBody)!;
                return new WithRawResponse<DocManifest200Response>()
                {
                    Data = responseData,
                    RawResponse = new CloudPDF.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CloudPDFApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new CloudPDF.RawResponse()
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
                            rawResponse: new CloudPDF.RawResponse()
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
            throw new CloudPDFApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<global::System.IO.Stream>> RenderAsyncCore(
        RenderDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudPDF.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudPDF.Core.HeadersBuilder.Builder()
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
                        "v1/docs/{0}/layers/{1}/render/pages/{2}/data",
                        ValueConvert.ToPathParameterString(request.DocId),
                        ValueConvert.ToPathParameterString(request.LayerName),
                        ValueConvert.ToPathParameterString(request.Pon)
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
            var stream = await response.Raw.Content.ReadAsStreamAsync();
            return new WithRawResponse<global::System.IO.Stream>()
            {
                Data = stream,
                RawResponse = new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                },
            };
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
                            rawResponse: new CloudPDF.RawResponse()
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
            throw new CloudPDFApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<DocText200Response>> TextAsyncCore(
        TextDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new CloudPDF.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new CloudPDF.Core.HeadersBuilder.Builder()
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
                        "v1/docs/{0}/layers/{1}/text/pages/{2}/data",
                        ValueConvert.ToPathParameterString(request.DocId),
                        ValueConvert.ToPathParameterString(request.LayerName),
                        ValueConvert.ToPathParameterString(request.Pon)
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
                var responseData = JsonUtils.Deserialize<DocText200Response>(responseBody)!;
                return new WithRawResponse<DocText200Response>()
                {
                    Data = responseData,
                    RawResponse = new CloudPDF.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CloudPDFApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new CloudPDF.RawResponse()
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
                            rawResponse: new CloudPDF.RawResponse()
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
            throw new CloudPDFApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new CloudPDF.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <example><code>
    /// await client.Doc.HeadAsync(new HeadDocRequest { DocId = "docId" });
    /// </code></example>
    public WithRawResponseTask<DocHead200Response> HeadAsync(
        HeadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DocHead200Response>(
            HeadAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Doc.DownloadAsync(new DownloadDocRequest { DocId = "docId", LayerName = "layerName" });
    /// </code></example>
    public WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<global::System.IO.Stream>(
            DownloadAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Doc.ManifestAsync(new ManifestDocRequest { DocId = "docId", LayerName = "layerName" });
    /// </code></example>
    public WithRawResponseTask<DocManifest200Response> ManifestAsync(
        ManifestDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DocManifest200Response>(
            ManifestAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Render parameters (viewport, format) pass as flat dotted query keys, e.g. `?viewport.kind=width&viewport.width=800`; the full grammar is documented with the viewer.
    /// </summary>
    /// <example><code>
    /// await client.Doc.RenderAsync(
    ///     new RenderDocRequest
    ///     {
    ///         DocId = "docId",
    ///         LayerName = "layerName",
    ///         Pon = 1,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<global::System.IO.Stream> RenderAsync(
        RenderDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<global::System.IO.Stream>(
            RenderAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Doc.TextAsync(
    ///     new TextDocRequest
    ///     {
    ///         DocId = "docId",
    ///         LayerName = "layerName",
    ///         Pon = 1,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<DocText200Response> TextAsync(
        TextDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DocText200Response>(
            TextAsyncCore(request, options, cancellationToken)
        );
    }
}
